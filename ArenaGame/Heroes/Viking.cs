using ArenaGame.Special_Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Heroes
{
    public class Viking:Hero
    {
        private double hitCount;
        private double damageCoef;
        public Viking(string name, double armor, double strenght, IWeapon weapon  ) : base(name, armor, strenght, weapon)
        {
            hitCount = 0;
            damageCoef = 0.6;
            SpecialWeapon = new IceAxe("ice axe");
        }

        public override double Attack()
        {
            double damage = base.Attack();
            double realDamage = damage * damageCoef + SpecialWeapon.AttackDamage;
            if (damageCoef < 1) damageCoef += 0.1;
            return realDamage;
        }

        public override double Defend(double damage)
        {
            hitCount++;
            if (hitCount == 3)
            {
                hitCount = 0;
                return 0;
            }
            return base.Defend(damage - SpecialWeapon.BlockingPower/10);
        }
    }
}
