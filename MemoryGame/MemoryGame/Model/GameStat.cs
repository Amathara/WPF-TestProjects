using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame.Model
{
    public class GameStat
    {
        public string PlayerName { get; set; }

        public int Moves { get; set; }

        public TimeSpan GameTime { get; set; }

        public DateTime CompletedAt { get; set; }

        public GameStat(string playerName, int moves, TimeSpan gameTime, DateTime completedAt) 
        { 
            this.PlayerName = playerName;
            this.Moves = moves;
            this.GameTime = gameTime;
            this.CompletedAt = completedAt;
        }

        public string ToString()
        {
            return$"GameStat,{PlayerName},{Moves},{GameTime},{CompletedAt}";
        }
        //public string FromString(string input)
        //{
        //    string[] parts = input.Split(',');
        //    return new GameStat(

        //        playerName: parts[0],
        //        moves: Int32.Parse(parts[1]),
        //        gameTime: TimeSpan.Parse(parts[2]),
        //        completedAt: DateTime.Parse(parts[3])

        //        );
        //}
}
}
