using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Special_Weapons
{
    internal class MagicWand : ISpecialWeapons
    {
        public string Name { get; set; }

        public double AttackDamage { get; private set; }

        public double BlockingPower { get; private set; }

        public string SpecialPower { get; private set; }
        public MagicWand(string name)
        {
            Name = name;
            AttackDamage = 10;
            BlockingPower = 2;
            SpecialPower = "when your health is lower it deals 50% bonus damage";
        }
    }
}
