using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi7_1.Vidu
{
    public class Mage : Entity
    {
        string Name;
        public string _Name => Name;
        public Mage(float HP, float DMG, float GOLD, int LEVEL, string Name) : base(HP, DMG, GOLD, LEVEL)
        {
            this.Name = Name;
        }

        public void SpellAtk(Entity target)
        {
            target.takeDmg(this.DMG);
        }

        //private string name;
        //public string _name => name;
        //public Mage(float hp, float dmg, float gold, int level, string name) : base(hp, dmg, gold, level)
        //{
        //    this.name = name;
        //}

        //public void SpellAtk(Entity target)
        //{
        //    target.takeDMG(this.DMG);
        //}
    }
}
