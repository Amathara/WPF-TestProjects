using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MemoryGame.Model;

namespace MemoryGame.Model.Repos.RepoInterfaces
{
    public interface IGameStatsRepo
    {
        public void SaveGame();

        public List<GameStat> GetTop10();

        public void GetGamesPlayer();

    }
}
