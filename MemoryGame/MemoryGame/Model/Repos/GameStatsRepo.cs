using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MemoryGame.Model.Repos.RepoInterfaces;

namespace MemoryGame.Model.Repos
{
    public class GameStatsRepo : IGameStatsRepo
    {
        private string _filePath;
        public GameStatsRepo(string filePath)
        {
            _filePath = filePath;
        }


        public void SaveGame()
        {
            throw new NotImplementedException();
        }

        public List<GameStat> GetTop10()
        {
            throw new NotImplementedException();
        }
        public void GetGamesPlayer()
        {
            throw new NotImplementedException();
        }

    }
}
