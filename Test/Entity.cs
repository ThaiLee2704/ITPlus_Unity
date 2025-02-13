using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Entity
    {
        protected float HP, DMG, GOLD;
        protected int LEVEL;

        public Entity(float hp, float dmg, float gold, int level)
        {
            this.HP = hp;
            this.DMG = dmg;
            this.GOLD = gold;
            this.LEVEL = level;
        }

        public void takeDmg(float dmg)
        {
            this.HP -= dmg;
            if (!isAlive())
                Console.WriteLine("Dead");
        }

        public bool isAlive()
        {
            if (this.HP <= 0)
                return false;
            return true;
        }
    }
}
