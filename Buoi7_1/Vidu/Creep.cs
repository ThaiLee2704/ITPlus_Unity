using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi7_1.Vidu
{
    public class Creep : Entity
    {
        public Creep(float HP, float DMG, float GOLD, int LEVEL) : base(HP, DMG, GOLD, LEVEL)
        {
        }

        public void Atk(Entity target)
        {
            target.takeDmg(this.DMG);
        }

        //public Creep(float hp, float dmg, float gold, int level) : base(hp, dmg, gold, level)
        //{
        //}

        //public void Atk(Entity target)
        //{
        //    target.takeDMG(this.DMG);
        //}
    }
}
