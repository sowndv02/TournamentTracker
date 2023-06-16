using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelper;
using System.Xml.Linq;
using System.Reflection;

namespace TrackerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        
        public void CreatePrize(PrizeModel prize)
        {
            List<PrizeModel> prizes = GlobalConfig.PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();
            int currentId = 1;
            if(prizes.Count > 0)
            {
                currentId = prizes.OrderByDescending(x => x.Id).FirstOrDefault().Id + 1;
            }
            prize.Id = currentId;
            prizes.Add(prize);
            prizes.SaveToPrizeFile();

        }

        public void CreatePerson(PersonModel model)
        {

            // Load the text file
            // Convert the text file to List<PrizeModel>
            List<PersonModel> people = GlobalConfig.PeopleFile.FullFilePath().LoadFile().ConvertToPeopleModels();

            // Find the ID
            int currentId = 1;
            if (people.Count > 0)
            {
                currentId = people.OrderByDescending(x => x.Id).FirstOrDefault().Id + 1;
            }
            model.Id = currentId;

            // Add the new record with the new Id (max + 1)
            people.Add(model);

            // Convert the prizes to List<string>
            // Save the list<string> to the text file
            people.SaveToPeopleFile();

        }

        public List<PersonModel> GetPerson_All()
        {
            return GlobalConfig.PeopleFile.FullFilePath().LoadFile().ConvertToPeopleModels();
        }

        public void CreateTeam(TeamModel model)
        {
            List<TeamModel> team = GlobalConfig.TeamFile.FullFilePath().LoadFile().ConvertToTeamModels();

            int currentId = 1;
            if (team.Count > 0)
            {
                currentId = team.OrderByDescending(x => x.Id).FirstOrDefault().Id + 1;
            }
            model.Id = currentId;

            team.Add(model);

            team.SaveToTeamFile();
        }

        public List<TeamModel> GetAll_Team()
        {
            return GlobalConfig.TeamFile.FullFilePath().LoadFile().ConvertToTeamModels();
        }

        public void CreateTournament(TournamentModel model)
        {
            List<TournamentModel> tournaments = GlobalConfig.TournamentFile
                .FullFilePath()
                .LoadFile()
                .ConvertToTournamentModels();

            int currentId = 1;
            if (tournaments.Count > 0)
            {
                currentId = tournaments.OrderByDescending(x => x.Id).FirstOrDefault().Id + 1;
            }
            model.Id = currentId;

            model.SaveRoundsToFile();
            tournaments.Add(model);
            tournaments.SaveToTournamentFile();

            TournamentLogic.UpdateTournamentResults(model);


        }

        public List<TournamentModel> GetTournament_All()
        {
            return GlobalConfig.TournamentFile
                .FullFilePath()
                .LoadFile()
                .ConvertToTournamentModels();
        }

        public void UpdateMatchup(MatchupModel model)
        {
            model.UpdateMatchupToFile();
        }

        public void CompleteTournament(TournamentModel model)
        {
            List<TournamentModel> tournaments = GlobalConfig.TournamentFile
                .FullFilePath()
                .LoadFile()
                .ConvertToTournamentModels();

            
            tournaments.Remove(model);

            tournaments.SaveToTournamentFile();

            TournamentLogic.UpdateTournamentResults(model);
        }
    }
}
