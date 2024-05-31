using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Special_Weapons
{
    internal class DiamondSword : ISpecialWeapons
    {    
    public string Name { get; set; }

        public double AttackDamage { get; private set; }

        public double BlockingPower{ get; private set; }

        public string SpecialPower { get; private set; }
        public DiamondSword(string name)
        {
            Name = name;
            AttackDamage = 7;
            BlockingPower = 10;
            SpecialPower = "damage the enemy for 3 times more damage in 10 attack duratin";
        }
    }
}

