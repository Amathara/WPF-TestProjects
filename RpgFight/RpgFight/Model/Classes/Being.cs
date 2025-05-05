using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgFight.Model.Classes
{
    internal class Being
    {
      public string Name { get; set; }
      public int HealthPoints { get; set; }
      public bool IsAlive { get; set; }
      public string AttackType { get; set; }
      public int AttackPower { get; set; }


    public Being() { }

    

    }
}
