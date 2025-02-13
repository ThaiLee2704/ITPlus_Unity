using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi7_1.Vidu
{
    public class Entity
    {
        protected float HP, DMG, GOLD;
        protected int LEVEL;

        public Entity(float HP, float DMG, float GOLD, int LEVEL)
        {
            this.HP = HP;
            this.DMG = DMG;
            this.GOLD = GOLD;
            this.LEVEL = LEVEL;
        }

        public void takeDmg(float dmg)
        {

            this.HP -= dmg;
            if (!this.isAlive())
            {
                Console.WriteLine("Dead");
            }
        }

        public bool isAlive()
        {
            if (this.HP <= 0)
                return false;
            return true;
        }

        //protected float HP, DMG, GOLD;
        //protected int level;

        //public Entity(float hp, float dmg, float gold, int level)
        //{
        //    HP = hp;
        //    DMG = dmg;
        //    GOLD = gold;
        //    this.level = level;
        //}

        //public void takeDMG(float dmg)
        //{
        //    HP -= dmg;
        //    if (!this.isAlive())
        //    {
        //        Console.WriteLine("Dead");
        //    }
        //}

        //public bool isAlive()
        //{
        //    if (this.HP <= 0)
        //        return false;
        //    return true;
        //}
    }
}
