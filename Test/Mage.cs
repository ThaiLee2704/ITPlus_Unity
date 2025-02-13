using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Mage : Entity
    {
        public Mage(float hp, float dmg, float gold, int level) : base(hp, dmg, gold, level)
        {

        }

        public void MageAtk(Entity entity)
        {
            entity.takeDmg(this.DMG);
        }
    }
}
