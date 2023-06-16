using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    public interface IDataConnection
    {
        void CreatePrize(PrizeModel prize);
        void UpdateMatchup(MatchupModel model);
        void CreatePerson (PersonModel person);
        void CreateTeam (TeamModel team);
        List<TeamModel> GetAll_Team();
        List<PersonModel> GetPerson_All();
        void CreateTournament(TournamentModel model);
        List<TournamentModel> GetTournament_All();
        void CompleteTournament(TournamentModel model);
    }
}
