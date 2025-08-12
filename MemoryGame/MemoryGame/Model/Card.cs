using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame.Model
{
    internal class Card
    {
        public int Id { get; set; }
        public string Symbol { get; set; }
        public bool IsFlipped { get; set; }
        public bool IsMatched { get; set; }


        public Card(int id, string symbol, bool isFlipped, bool isMatched) 
        {
            this.Id = id;
            this.Symbol = symbol;
            this.IsFlipped = isFlipped;
            this.IsMatched = isMatched;
        }
        

    }
}
