using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgFight.Model.Classes
{
    internal class Player : Being
    {
        public string Class {  get; set; }
        public int Wealth { get; set; }

        public Player()
        {
            
        }
    }
}
