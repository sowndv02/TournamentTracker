using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess.TextHelper
{
    internal static class TextConnectorProcess
    {
        public static string FullFilePath(this string fileName) //PrizeModels.csv
        {
            return $"{ConfigurationManager.AppSettings["filePath"]}\\{fileName}";
        }


        public static List<PersonModel> ConvertToPeopleModels(this List<string> lines)
        {
            List<PersonModel> output = new List<PersonModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                PersonModel model = new PersonModel();
                model.Id = int.Parse(cols[0]);
                model.FirstName = cols[1];
                model.LastName = cols[2];
                model.EmailAddress = cols[3];
                model.PhoneNumber = cols[4];
                output.Add(model);
            }
            return output;
        }

        public static List<TournamentModel> ConvertToTournamentModels(
            this List<string> lines)
        {

            // id,tournamentName,entryFee,(id|id|id-Entered Teams),(id|id|id-Prizes),(Rounds- id^id^id|id^id^id) 
            List<TournamentModel> output = new List<TournamentModel>();
            List<TeamModel> teams = GlobalConfig.TeamFile.FullFilePath().LoadFile().ConvertToTeamModels();
            List<PrizeModel> prizes = GlobalConfig.PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();
            List<MatchupModel> matchups = GlobalConfig.MatchupFile.FullFilePath().LoadFile().ConvertToMatchupModels();
            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                TournamentModel model = new TournamentModel();
                model.Id = int.Parse(cols[0]);
                model.TournamentName = cols[1];
                model.EntryFee = decimal.Parse(cols[2]);
                string[] teamIds = cols[3].Split("|");

                foreach(string id in teamIds)
                {
                    model.EnteredTeams.Add(teams.Where(x => x.Id == int.Parse(id)).First());
                }

                if (cols[5].Length >0)
                {
                    string[] prizesId = cols[4].Split("|");
                    foreach (string id in prizesId)
                    {
                        model.Prizes.Add(prizes.Where(x => x.Id == int.Parse(id)).First());
                    }
                }

                // Capture Rounds information
                string[] rounds = cols[5].Split('|');
                List<MatchupModel> ms = new List<MatchupModel>();
                foreach(string round in rounds)
                {
                    string[] msText = round.Split("^");   
                    foreach(string matchupModelTextId in msText)
                    {
                        ms.Add(matchups.Where(x => x.Id == int.Parse(matchupModelTextId)).First());
                    }

                    model.Rounds.Add(ms);
                }

                output.Add(model);
            }
            return output;
        }

        public static List<TeamModel> ConvertToTeamModels(this List<string> lines)
        {
            // id, teamname, list of ids separated the pipe
            // 3,Tim's Team,1|3|5

            List<TeamModel> output = new List<TeamModel>();
            List<PersonModel> people = GlobalConfig.PeopleFile.FullFilePath().LoadFile().ConvertToPeopleModels();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                TeamModel model = new TeamModel();
                model.Id = int.Parse(cols[0]);
                model.TeamName = cols[1];
                string[] personIds = cols[2].Split("|");

                foreach (string personId in personIds)
                {
                    model.TeamMembers.Add(people.Where(x => x.Id == int.Parse(personId)).FirstOrDefault());
                }
                output.Add(model);
            }
            return output;
        }

        public static List<string> LoadFile(this string file)
        {
            if(!File.Exists(file))
            {
                return new List<string>() ;
            }
            return File.ReadLines(file).ToList();
        }

        public static List<PrizeModel> ConvertToPrizeModels(this List<string> lines)
        {
            List<PrizeModel> output = new List<PrizeModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                PrizeModel prizeModel = new PrizeModel();
                prizeModel.Id = int.Parse(cols[0]);
                prizeModel.PlaceNumber = int.Parse(cols[1]);
                prizeModel.PlaceName = cols[2]; 
                prizeModel.PrizeAmount = decimal.Parse(cols[3]);    
                prizeModel.PrizePercentage = double.Parse(cols[4]);
                output.Add(prizeModel);
            }
            return output;
        }

        public static void SaveToPrizeFile(this List<PrizeModel> models)
        {
            List<string> lines = new List<string>();
            foreach(PrizeModel p in models)
            {
                lines.Add($"{p.Id},{p.PlaceNumber},{p.PlaceName},{p.PrizeAmount},{p.PrizePercentage}");
            }
            File.WriteAllLines(GlobalConfig.PrizesFile.FullFilePath(), lines);
        }

        public static void SaveToTournamentFile(this List<TournamentModel> models)
        {
            List<string> lines = new List<string>();
            foreach (TournamentModel p in models)
            {
                lines.Add($"{p.Id},{p.TournamentName},{p.EntryFee},{ConvertTeamListToString(p.EnteredTeams)},{ConvertPrizeListToString(p.Prizes)},{ConvertRoundListToString(p.Rounds)}");
            }
            File.WriteAllLines(GlobalConfig.TournamentFile.FullFilePath(), lines);
        }

        private static string ConvertRoundListToString(List<List<MatchupModel>> models)
        {
            //id^id^id|id^id^id
            if (models.Count == 0) return "";
            string output = "";
            foreach (List<MatchupModel> p in models)
            {
                output += $"{ConvertMatchupListToString(p)}|";
            }

            output = output.Substring(0, output.Length - 1);
            return output;
        }

        private static string ConvertMatchupListToString(List<MatchupModel> models)
        {
            if (models.Count == 0) return "";
            string output = "";
            foreach (MatchupModel p in models)
            {
                output += $"{p.Id}^";
            }

            output = output.Substring(0, output.Length - 1);
            return output;
        }

        private static string ConvertPrizeListToString(List<PrizeModel> models)
        {
            if (models.Count == 0) return "";
            string output = "";
            foreach (PrizeModel p in models)
            {
                output += $"{p.Id}|";
            }

            output = output.Substring(0, output.Length - 1);
            return output;
        }

        private static string ConvertTeamListToString(List<TeamModel> models)
        {
            if (models.Count == 0) return "";
            string output = "";
            foreach (TeamModel p in models)
            {
                output += $"{p.Id}|";
            }

            output = output.Substring(0, output.Length - 1);
            return output;
        }

        public static void SaveToPeopleFile(this List<PersonModel> models)
        {
            List<string> lines = new List<string>();
            foreach (PersonModel p in models)
            {
                lines.Add($"{p.Id},{p.FirstName},{p.LastName},{p.EmailAddress},{p.PhoneNumber}");
            }
            File.WriteAllLines(GlobalConfig.PeopleFile.FullFilePath(), lines);
        }

        public static void SaveToTeamFile(this List<TeamModel> models)
        {
            List<string> lines = new List<string>();
            foreach (TeamModel p in models)
            {
                lines.Add($"{p.Id},{p.TeamName},{ConvertPeopleListToString(p.TeamMembers)}");
            }
            File.WriteAllLines(GlobalConfig.TeamFile.FullFilePath(), lines);
        }

        private static string ConvertPeopleListToString(List<PersonModel> models)
        {
            if (models.Count == 0) return "";
            string output = "";
            foreach(PersonModel p in models)
            {
                output += $"{p.Id}|";
            }

            output=output.Substring(0, output.Length-1);
            return output;
        }

        private static MatchupModel LookupMatchupById(int id)
        {
            List<string> matchups = GlobalConfig.MatchupFile.FullFilePath().LoadFile();

            foreach(string matchup in matchups)
            {
                string[] cols = matchup.Split(',');
                if (cols[0] == id.ToString())
                {
                    List<string> mathchingMatchup = new List<string>();
                    mathchingMatchup.Add(matchup);  
                    return mathchingMatchup.ConvertToMatchupModels().First();
                }
            }
            return null;
        }

        public static List<MatchupEntryModel> ConvertToMatchupEntryModels(this List<string> lines)
        {
            List<MatchupEntryModel> output = new List<MatchupEntryModel>();

            foreach (string line in lines)
            {
                MatchupEntryModel model = new MatchupEntryModel();  
                string[] cols = line.Split(',');
                model.Id = int.Parse(cols[0]);
                if (cols[1].Length == 0)
                {
                    model.TeamCompeting = null;
                }else model.TeamCompeting = LookupTeamById(int.Parse(cols[1]));
                model.Score = double.Parse(cols[2]);
                int parentId = 0;
                if (int.TryParse(cols[3], out parentId))
                {
                    model.ParentMatchup = LookupMatchupById(parentId);
                }
                else
                {
                    model.ParentMatchup = null;
                }
                
                output.Add(model);  
            }
            return output;
        }

        private static List<MatchupEntryModel> ConvertStringToMatchupEntryModels(string input)
        {
            string[] ids = input.Split('|');
            List<MatchupEntryModel> output = new List<MatchupEntryModel>();
            List<string> entries = GlobalConfig.MatchupEntryFile.FullFilePath().LoadFile();
            List<string> matchingEntries = new List<string>();
            foreach(string id in ids) 
            {
                foreach(string entry in entries)
                {
                    string[] cols =  entry.Split(",");
                    if (cols[0] == id)
                    {
                        matchingEntries.Add(entry); 
                    }
                }
            }

            output= matchingEntries.ConvertToMatchupEntryModels();
            return output;
        }

        private static TeamModel LookupTeamById(int id)
        {
            List<string> teams = GlobalConfig.TeamFile.FullFilePath().LoadFile();

            foreach(string team in teams) 
            {
                string[] cols = team.Split(",");
                if (cols[0] == id.ToString())
                {
                    List<string> matchingTeans = new List<string>();
                    matchingTeans.Add(team);
                    return matchingTeans.ConvertToTeamModels().First();
                }
            }
            return null;
        }

        public static List<MatchupModel> ConvertToMatchupModels(this List<string> lines)
        {
            List<MatchupModel> output = new List<MatchupModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                
                MatchupModel model = new MatchupModel();
                model.Id = int.Parse(cols[0]);
                
                model.Entries = ConvertStringToMatchupEntryModels(cols[1]);
                if (cols[2].Length == 0) model.Winner = null;
                else model.Winner = LookupTeamById(int.Parse(cols[2]));
                model.MatchupRound = int.Parse(cols[3]);
                output.Add(model);
            }
            return output;
        }

        public static void SaveMatchupToFile(this MatchupModel matchup)
        {
            List<MatchupModel> matchups = GlobalConfig.MatchupFile.FullFilePath().LoadFile().ConvertToMatchupModels();
            int currentId = 1;
            if (matchups.Count > 0)
            {
                currentId = matchups.OrderByDescending(x => x.Id).FirstOrDefault().Id + 1;
            }
            matchup.Id = currentId;
            matchups.Add(matchup);

            foreach (MatchupEntryModel entry in matchup.Entries)
            {
                entry.SaveEntryToFile();
            }
            
            // Save to file
            List<string> lines = new List<string>();   
            foreach(MatchupModel m in matchups)
            {
                string winner = "";
                if (m.Winner != null)
                {
                    winner = m.Winner.Id.ToString();
                }
                lines.Add($"{m.Id},{ConvertMatchupEntryListToString(m.Entries)},{winner},{m.MatchupRound}");
            }
            File.WriteAllLines(GlobalConfig.MatchupFile.FullFilePath(), lines);

        }

        public static void UpdateMatchupToFile(this MatchupModel matchup)
        {
            List<MatchupModel> matchups = GlobalConfig.MatchupFile.FullFilePath().LoadFile().ConvertToMatchupModels();
            MatchupModel oldMatchup = new MatchupModel();

            foreach (MatchupModel m in matchups)
            {
                if(m.Id == matchup.Id)
                {
                    oldMatchup = m;
                }
            }

            matchups.Remove(oldMatchup);

            matchups.Add(matchup);

            foreach (MatchupEntryModel entry in matchup.Entries)
            {
                entry.UpdateEntryToFile();
            }

            // Save to file
            List<string> lines = new List<string>();
            foreach (MatchupModel m in matchups)
            {
                string winner = "";
                if (m.Winner != null)
                {
                    winner = m.Winner.Id.ToString();
                }
                lines.Add($"{m.Id},{ConvertMatchupEntryListToString(m.Entries)},{winner},{m.MatchupRound}");
            }
            File.WriteAllLines(GlobalConfig.MatchupFile.FullFilePath(), lines);
        }


        public static void UpdateEntryToFile(this MatchupEntryModel entry)
        {
            List<MatchupEntryModel> entries = GlobalConfig.MatchupEntryFile.FullFilePath().LoadFile().ConvertToMatchupEntryModels();
            
            MatchupEntryModel oldEntry = new MatchupEntryModel();

            foreach(MatchupEntryModel m in entries)
            {
                if(m.Id == entry.Id)
                {
                    oldEntry = m;
                }
            }
            entries.Remove(oldEntry);
            entries.Add(entry);
            List<string> lines = new List<string>();
            foreach (MatchupEntryModel p in entries)
            {
                string parent = "";
                if (p.ParentMatchup != null)
                {
                    parent = p.ParentMatchup.Id.ToString();
                }
                string teamCompeting = "";
                if (p.TeamCompeting != null) teamCompeting = p.TeamCompeting.Id.ToString();
                lines.Add($"{p.Id},{teamCompeting},{p.Score},{parent}");
            }
            File.WriteAllLines(GlobalConfig.MatchupEntryFile.FullFilePath(), lines);
        }

        public static void SaveEntryToFile(this MatchupEntryModel entry)
        {
            List<MatchupEntryModel> entries = GlobalConfig.MatchupEntryFile.FullFilePath().LoadFile().ConvertToMatchupEntryModels();
            int currentId = 1;
            if (entries.Count > 0)
            {
                currentId = entries.OrderByDescending(x => x.Id).First().Id + 1;
            }
            entry.Id = currentId;
            entries.Add(entry); 
            List<string> lines = new List<string>();
            foreach (MatchupEntryModel p in entries)
            {
                string parent = ""; 
                if(p.ParentMatchup != null)
                {
                    parent = p.ParentMatchup.Id.ToString();
                }
                string teamCompeting = "";
                if (p.TeamCompeting != null) teamCompeting = p.TeamCompeting.Id.ToString();
                lines.Add($"{p.Id},{teamCompeting},{p.Score},{parent}");
            }
            File.WriteAllLines(GlobalConfig.MatchupEntryFile.FullFilePath(), lines);
        }


        public static void SaveRoundsToFile(this TournamentModel model)
        {
            // Loop through each round
            // Loop through each matchup
            // Get the id for the new matchup and save the record
            // Loop through each Entry, get the id, and save it

            foreach (List<MatchupModel> round in model.Rounds)
            {
                foreach (MatchupModel matchup in round)
                {
                    // Load all of the matchups from file
                    // Get the top id and add one
                    // Store the id
                    // Save the matchup record 
                    matchup.SaveMatchupToFile();
                    

                }
            }
        }

        private static string ConvertMatchupEntryListToString(List<MatchupEntryModel> models)
        {
            if (models.Count == 0) return "";
            string output = "";
            foreach (MatchupEntryModel p in models)
            {
                output += $"{p.Id}|";
            }

            output = output.Substring(0, output.Length - 1);
            return output;
        }

    }
}
