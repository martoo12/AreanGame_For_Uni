using ArenaGame.Special_Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Heroes
{
    public class Assassin : Hero
    {
        public Assassin(string name, double armor, double strenght, IWeapon weapon) : 
            base(name, armor, strenght, weapon)
        {
            SpecialWeapon = new FlamingDagger("flaming dagger");
        }

        public override double Attack()
        {
            double damage = base.Attack() + SpecialWeapon.AttackDamage;

            double probability = random.NextDouble();
            if (probability < 0.10)
            {
                damage *= 3;
            }
            return damage;
        }
    }
}
