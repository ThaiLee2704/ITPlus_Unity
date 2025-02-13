using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Creep : Entity
    {
        public Creep(float hp, float dmg, float gold, int level) : base(hp, dmg, gold, level)
        {
        }

        public void CreepAtk(Entity entity)
        {
            entity.takeDmg(this.DMG);
        }
    }
}
