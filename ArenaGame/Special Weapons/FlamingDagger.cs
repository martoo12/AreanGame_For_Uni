using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Special_Weapons
{
    internal class FlamingDagger : ISpecialWeapons
    {
        public string Name { get; set; }

        public double AttackDamage { get; private set; }

        public double BlockingPower { get; private set; }

        public string SpecialPower { get; private set; }
        public FlamingDagger(string name)
        {
            Name = name;
            AttackDamage = 9;
            BlockingPower = 12;
            SpecialPower = "burn effect on 2 attacks duration";
        }
    }
}
