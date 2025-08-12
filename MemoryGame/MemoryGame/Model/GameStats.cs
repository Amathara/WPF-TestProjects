using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame.Model
{
    public class GameStats
    {
        public string PlayerName { get; set; }

        public int Moves { get; set; }

        public TimeSpan GameTime { get; set; }

        public DateTime CompletedAt { get; set; }

        public GameStats(string playerName, int moves, TimeSpan gameTime, DateTime completedAt) 
        { 
            this.PlayerName = playerName;
            this.Moves = moves;
            this.GameTime = gameTime;
            this.CompletedAt = completedAt;

        }
    }
}
