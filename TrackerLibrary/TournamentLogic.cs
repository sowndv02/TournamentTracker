using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary
{
    public static class TournamentLogic
    {
        // order our list randomly of teams 
        // Check if it is big enough - if not, add in byes: 2*2*2*2 = 2^4 
        // Create every round after that - 8 matchup - 4 matchup - 2 matchup - 1 matchup

        public static void CreateRounds(TournamentModel model)
        {
            List<TeamModel> randomizedTeams = RandomizeTeamOrder(model.EnteredTeams);
            int rounds = FindNumberOfRounds(randomizedTeams.Count);
            int byes = NumberOfByes(rounds, randomizedTeams.Count);
            model.Rounds.Add(CreateFirstRound(byes,randomizedTeams));

            CreateOtherRounds(model, rounds);

        }

        public static void UpdateTournamentResults(TournamentModel model)
        {
            int startingRound = model.CheckCurrentRound();
            List<MatchupModel> toScore = new List<MatchupModel>();  
            foreach(List<MatchupModel> round in model.Rounds) 
            {
                foreach(MatchupModel rm in round)
                {
                    if(rm.Winner==null && (rm.Entries.Any(x => x.Score != 0)) || rm.Entries.Count() == 1)
                    {
                        toScore.Add(rm);    
                    }

                }
            }

            MarkWinnerInMatchups(toScore);

            AdvanceWinners(toScore, model);

            toScore.ForEach(x => GlobalConfig.Connection.UpdateMatchup(x));

            int endingRound = model.CheckCurrentRound();
            if(endingRound > startingRound)
            {
                //EmailLogic.SendEmail();
                model.AlertUserToNewRound();
            }
        }

        public static void AlertUserToNewRound(this TournamentModel model)
        {
            int currentRoundNumber = model.CheckCurrentRound();
            List<MatchupModel> currentRound = model.Rounds.Where(x => x.First().MatchupRound == currentRoundNumber).First();

            foreach(MatchupModel matchup in currentRound)
            {
                foreach (MatchupEntryModel me in matchup.Entries)
                {
                    foreach (PersonModel p in me.TeamCompeting.TeamMembers)
                    {
                        AlertUserToNewRound(p, me.TeamCompeting.TeamName, matchup.Entries.Where(x => x.TeamCompeting != me.TeamCompeting).FirstOrDefault());
                    }
                }
            }
        }

        private static void AlertUserToNewRound(PersonModel p, string teamName, MatchupEntryModel competitor)
        {
            if(p.EmailAddress.Length == 0)
            {
                return;
            }
            
            string to = "";
            string subject = "";
            string body = "";
            StringBuilder sb = new StringBuilder();
            if (competitor != null)
            {
                subject = $"You have a new matchup with{competitor.TeamCompeting.TeamName}";
                sb.AppendLine("<h1>You have a new matchup</h1>");
                sb.Append("<strong>Competitor: </strong>");
                sb.Append(competitor.TeamCompeting.TeamName);
                sb.AppendLine();
                sb.AppendLine();
                sb.AppendLine("Have a great time!");
                sb.AppendLine("~Tournament Tracker");
            }
            else
            {
                subject = "You have a bye week this round.";
                sb.AppendLine("Enjoy your round off!");
                sb.AppendLine("~Tournament Tracker");
            }
            to= p.EmailAddress;
            EmailLogic.SendEmail(to, subject, body);
        }

        private static int CheckCurrentRound(this TournamentModel model)
        {
            int output = 1;
            foreach(List<MatchupModel> round in model.Rounds)
            {
                if(round.All(x => x.Winner != null))
                {
                    output += 1;
                }
                else
                {
                    return output;
                }
            }
            //Tournament is complete
            CompleteTournament(model);
            return output - 1;
        }

        private static void CompleteTournament(TournamentModel model)
        {
            GlobalConfig.Connection.CompleteTournament(model);
            TeamModel winners = model.Rounds.Last().First().Winner;
            TeamModel runnerUp = model.Rounds.Last().First().Entries.Where(x => x.TeamCompeting != winners).First().TeamCompeting;

            decimal winnerPrize = 0;
            decimal runnerUpPrize = 0;



            if(model.Prizes.Count > 0)
            {
                decimal totalIncome = model.EnteredTeams.Count * model.EntryFee;
                PrizeModel firstPlacePrize =model.Prizes.Where(x => x.PlaceNumber == 1).FirstOrDefault();
                PrizeModel secondPlacePrize =model.Prizes.Where(x => x.PlaceNumber == 1).FirstOrDefault();
                if (firstPlacePrize != null)
                {
                    winnerPrize = firstPlacePrize.CalculatePrizePayout(totalIncome);
                }
                if (secondPlacePrize != null)
                {
                    runnerUpPrize = secondPlacePrize.CalculatePrizePayout(totalIncome);
                }
                string subject = "";
                StringBuilder body = new StringBuilder();
                
                    subject = $"In {model.TournamentName}, {winners.TeamName} has won!";
                body.AppendLine("<h1>We have a WINNER!</h1>");
                body.Append("<p>Congratulations to our winner on a reat tournament.</p>");
                body.Append("</br>");
                body.AppendLine();
                body.AppendLine();
                
                if(winnerPrize > 0)
                {
                    body.AppendLine($"<p>{winners.TeamName} will reveive ${winnerPrize}</p>");
                }
                if(runnerUpPrize > 0)
                {
                    body.AppendLine($"<p>{runnerUp.TeamName} will reveive ${runnerUpPrize}</p>");
                }
                body.AppendLine("<p>Thanks for a great tournament everyone!</p>");
                body.AppendLine("~Tournament Tracker");

                List<string> bcc =new List<string>();
                foreach (TeamModel t in model.EnteredTeams)
                {
                    foreach(PersonModel p in t.TeamMembers)
                    {
                        if(p.EmailAddress.Length > 0)
                        {
                            bcc.Add(p.EmailAddress);    
                        }
                    }
                }
                EmailLogic.SendEmail(new List<string>(), bcc,subject, body.ToString());

                model.CompleteTournament();
            }

        }

        private static decimal CalculatePrizePayout(this PrizeModel prize, decimal totalIncome)
        {
            decimal output = 0;
            if(prize.PrizeAmount > 0)
            {
                output = prize.PrizeAmount;
            }
            else
            {
                output = Decimal.Multiply(totalIncome * Convert.ToDecimal(prize.PrizePercentage / 100));
            }
            return output;
        }

        private static void AdvanceWinners(List<MatchupModel> models, TournamentModel tournament)
        {
            foreach (MatchupModel m in models)
            {
                foreach (List<MatchupModel> round in tournament.Rounds)
                {
                    foreach (MatchupModel matchup in round)
                    {
                        foreach (MatchupEntryModel entry in matchup.Entries)
                        {
                            if (entry.ParentMatchup != null)
                            {
                                if (entry.ParentMatchup.Id == m.Id)
                                {
                                    entry.TeamCompeting = m.Winner;
                                    GlobalConfig.Connection.UpdateMatchup(matchup);
                                }
                            }
                        }
                    }
                }
            }
        }
        private static void MarkWinnerInMatchups(List<MatchupModel> models)
        {
            string greaterWins = ConfigurationManager.AppSettings["greaterWins"];

            foreach(MatchupModel model in models)
            {
                if(model.Entries.Count == 1)
                {
                    model.Winner = model.Entries[0].TeamCompeting;
                    continue;
                }
                if (greaterWins == "0")
                {
                    if (model.Entries[0].Score < model.Entries[1].Score)
                    {
                        model.Winner = model.Entries[0].TeamCompeting;
                    } else if (model.Entries[1].Score < model.Entries[0].Score)
                    {
                        model.Winner = model.Entries[1].TeamCompeting;
                    }else throw new Exception("We do not allow ties in this application.");
                }
                else
                {
                    if (model.Entries[0].Score > model.Entries[1].Score)
                    {
                        model.Winner = model.Entries[0].TeamCompeting;
                    }
                    else if (model.Entries[1].Score > model.Entries[0].Score)
                    {
                        model.Winner = model.Entries[1].TeamCompeting;
                    }
                    else throw new Exception("We do not allow ties in this application.");
                }
            }
            
        }

        private static void CreateOtherRounds(TournamentModel model, int rounds)
        {
            int round = 2;
            List<MatchupModel> previousRound = model.Rounds[0];
            List<MatchupModel> currRound = new List<MatchupModel>();
            MatchupModel currMatchup = new MatchupModel();
            while(round <= rounds)
            {
                foreach(MatchupModel matchup in previousRound)
                {
                    currMatchup.Entries.Add(new MatchupEntryModel { ParentMatchup = matchup });
                    if(currMatchup.Entries.Count > 1)
                    {
                        currMatchup.MatchupRound = round;
                        currRound.Add(currMatchup);
                        currMatchup = new MatchupModel();
                    }
                }
                model.Rounds.Add(currRound);
                previousRound = currRound;
                currRound = new List<MatchupModel>();   
                round += 1;
            }
        }

        private static List<MatchupModel> CreateFirstRound(int byes, List<TeamModel> teams)
        {
            List<MatchupModel> output = new List<MatchupModel>();
            MatchupModel curr = new MatchupModel();

            foreach (TeamModel team in teams)
            {
                curr.Entries.Add(new MatchupEntryModel { TeamCompeting = team });
                if (byes > 0 || curr.Entries.Count > 1)
                {
                    curr.MatchupRound = 1;
                    output.Add(curr);
                    curr = new MatchupModel();

                    if (byes > 0)
                    {
                        byes -= 1;
                    }
                }
                
            }
            return output;
        }

        private static  int NumberOfByes(int rounds, int numberOfTeams)
        {
            int output = 0;
            int totalTeams = 1;
            for(int i = 1; i<= rounds; i++) 
            {
                totalTeams *= 2;
            }
            output = totalTeams - numberOfTeams ;
            return output;
        }

        private static int FindNumberOfRounds(int teams)
        {
            int output = 1;
            int val = 2;

            while (val <= teams)
            {
                output += 1;
                val *= 2;
            }
            return output;

        }

        private static List<TeamModel> RandomizeTeamOrder(List<TeamModel> teams)
        {
            return teams.OrderBy(x => Guid.NewGuid()).ToList(); 
        }
    }
}
