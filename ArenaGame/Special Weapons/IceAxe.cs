using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Special_Weapons
{
    internal class IceAxe : ISpecialWeapons
    {
        public string Name { get; set; }

        public double AttackDamage { get; private set; }

        public double BlockingPower { get; private set; }

        public string SpecialPower { get; private set; }
        public IceAxe(string name)
        {
            Name = name;
            AttackDamage = 6;
            BlockingPower = 9;
            SpecialPower = "on every 2 attacks stuns the enemy for 0.3 seconds";
        }
    }
}

