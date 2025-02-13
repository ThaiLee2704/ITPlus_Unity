namespace Test
{
    internal class Program
    {
        static List<Warrior> listWarrior = new List<Warrior>()
        {
            new Warrior(10, 50, 100, 1),
            new Warrior(10, 60, 100, 1),
            new Warrior(10, 40, 100, 1),
        };

        static List<Mage> listMage = new List<Mage>()
        {
            new Mage(100, 10, 4, 2),
            new Mage(100, 40, 4, 2),
            new Mage(100, 70, 4, 2),
        };

        static List<Creep> listCreep = new List<Creep>()
        {
            new Creep(50, 20, 10, 1),
            new Creep(60, 20, 10, 1),
            new Creep(70, 20, 10, 1),
            new Creep(80, 20, 10, 1),
            new Creep(80, 20, 10, 1),
            new Creep(80, 20, 10, 1),
            new Creep(80, 20, 10, 1),
            new Creep(80, 20, 10, 1),
        };

        static void Main(string[] args)
        {
            Warrior w;
            Mage m;
            Creep c;

            while (!IsEndCombat())
            {
                w = getWarrior();
                m = getMage();
                c = getCreep();

                Random rd = new Random();
                int r = rd.Next(100);
                if(r > 50)
                {
                    if (w != null)
                    {
                        Console.WriteLine("c atk w");
                        c.CreepAtk(w);
                    }
                    else
                    {
                        Console.WriteLine("c atk m");
                        c.CreepAtk(m);
                    }
                }
                else{
                    if(w != null)
                    {
                        Console.WriteLine("w atk c");
                        w.MeleeAtk(c);
                    }else if(m != null)
                    {
                        Console.WriteLine("m atk c");
                        m.MageAtk(c);
                    }
                }
            }

            Warrior warrior1 = getWarrior();
            Mage mage1 = getMage();

            if(warrior1 == null && mage1 == null)
            {
                Console.WriteLine("creep win");
            }
            else
            {
                Console.WriteLine("character win");
            }
        }

        static bool IsEndCombat()
        {
            if ((getWarrior() == null && getMage() == null) || getCreep() == null)
                return true;
            return false;
        }

        static Warrior getWarrior()
        {
            foreach (Warrior warrior in listWarrior)
            {
                if (!warrior.isAlive()) continue;
                return warrior;
            }
            return null;
        }

        static Creep getCreep()
        {
            foreach (Creep creep in listCreep)
            {
                if (!creep.isAlive()) continue;
                return creep;
            }
            return null;
        }

        static Mage getMage()
        {
            foreach (Mage mage in listMage)
            {
                if (!mage.isAlive()) continue;
                return mage;
            }
            return null;
        }
        
    }
}
