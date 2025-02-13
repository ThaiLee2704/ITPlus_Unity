using System;
using System.Collections;
using System.Collections.Generic;
using Buoi7_1.Vidu;

    class StudentAndTeacherTest
{
    //static void Main(string[] args)
    //{
    //    new Person();

    //    List<Student> students = new List<Student>()
    //    {
    //        new Student(),
    //        new Student(),
    //        new Student(),
    //        new Student(),
    //        new Student()
    //    };

    //    Teacher teacher = new Teacher();

    //    foreach (Student std in students)
    //    {
    //        std.SetAge(20);
    //        std.showAge();
    //    }

    //    teacher.Explain();
    //}
    //////////////////////////////////////////////////////////
    //Vidu

    static List<Warrior> Allience1 = new List<Warrior>()
        {
            new Warrior(HP: 100, DMG: 50, LEVEL: 0, GOLD: 0, Name: "W1"),
            new Warrior(HP: 100, DMG: 30, LEVEL: 0, GOLD: 0, Name: "W2")
        };

    static List<Mage> Allience2 = new List<Mage>()
        {
            new Mage(HP: 60, DMG: 80, LEVEL: 0, GOLD: 0, Name: "M1"),
            new Mage(HP: 60, DMG: 75, LEVEL: 0, GOLD: 0, Name: "M2"),
            new Mage(HP: 60, DMG: 70, LEVEL: 0, GOLD: 0, Name: "M3")
        };

    static List<Creep> Horde = new List<Creep>()
        {
            new Creep(HP: 100, DMG: 50, LEVEL: 0, GOLD: 0),
            new Creep(HP: 100, DMG: 50, LEVEL: 0, GOLD: 0),
            new Creep(HP: 100, DMG: 50, LEVEL: 0, GOLD: 0),
            new Creep(HP: 100, DMG: 50, LEVEL: 0, GOLD: 0),
        };
    static void Main(string[] args)
    {
        Console.WriteLine("Start Combat");

        while (!checkEndCombat())
        {
            Mage m = getMage();
            Warrior w = getWarrior();
            Creep c = getCreep();

            Random rd = new Random();
            int dice = rd.Next(100);
            Console.WriteLine("Dice: " + dice);


            if (dice > 50)
            {
                if (m != null)
                {
                    Console.WriteLine("Creep atk " + m._Name);
                    c.Atk(m);
                }
                else
                {
                    Console.WriteLine("Creep atk " + w._Name);
                    c.Atk(w);
                }

            }
            else
            {
                if (m != null)
                {
                    Console.WriteLine(m._Name + " Atk creep");
                    m.SpellAtk(c);
                }
                else if (w != null)
                {
                    Console.WriteLine(w._Name + " Atk creep");
                    w.MeleeAtk(c);
                }
            }
        }

        Mage m1 = getMage();
        Warrior w1 = getWarrior();

        if (m1 == null && w1 == null)
        {
            Console.WriteLine("Creep win");
        }
        else
        {
            Console.WriteLine("Allience win");
        }

    }

    static bool checkEndCombat()
    {
        if ((getMage() == null && getWarrior() == null) || getCreep() == null)
        {
            return true;
        }
        return false;
    }

    static Warrior getWarrior()
    {
        foreach (Warrior e in Allience1)
        {
            if (!e.isAlive())
                continue;
            return e;
        }

        return null;
    }

    static Mage getMage()
    {
        foreach (Mage e in Allience2)
        {
            if (!e.isAlive())
                continue;
            return e;
        }

        return null;
    }

    static Creep getCreep()
    {
        foreach (Creep e in Horde)
        {
            if (!e.isAlive())
                continue;
            return e;
        }

        return null;
    }

    //#region a hieu
    //static List<Warrior> Allience1 = new List<Warrior>()
    //    {
    //        new Warrior(HP: 100, DMG: 50, LEVEL: 0, GOLD: 0, Name: "W1"),
    //        new Warrior(HP: 100, DMG: 30, LEVEL: 0, GOLD: 0, Name: "W2")
    //    };

    //private static List<Mage> Allience2 = new List<Mage>()
    //    {
    //        new Mage(HP: 100, DMG: 80, LEVEL: 0, GOLD: 0, Name: "M1"),
    //        new Mage(HP: 100, DMG: 70, LEVEL: 0, GOLD: 0, Name: "M2"),
    //        new Mage(HP: 100, DMG: 75, LEVEL: 0, GOLD: 0, Name: "M2")
    //    };

    //static List<Creep> Horde = new List<Creep>()
    //    {
    //        new Creep(HP: 100, DMG: 50, LEVEL: 0, GOLD: 0),
    //        new Creep(HP: 100, DMG: 50, LEVEL: 0, GOLD: 0),
    //        new Creep(HP: 100, DMG: 50, LEVEL: 0, GOLD: 0),
    //        new Creep(HP: 100, DMG: 50, LEVEL: 0, GOLD: 0),
    //        new Creep(HP: 100, DMG: 50, LEVEL: 0, GOLD: 0)
    //    };
    //static void Main(string[] args)
    //{
    //    Console.WriteLine("Start Combat");

    //    while (!checkEndCombat())
    //    {
    //        Mage m = getMage();
    //        Warrior w = getWarrior();
    //        Creep c = getCreep();

    //        Random rd = new Random();
    //        int dice = rd.Next(100);

    //        Console.WriteLine("Dice: " + dice);
    //        if (dice > 50)
    //        {
    //            if (m != null)
    //            {
    //                Console.WriteLine("Creep attack mage " + m._Name); // 
    //                c.Atk(m);
    //            }
    //            else
    //            {
    //                Console.WriteLine("Creep attack warrior " + w._Name);
    //                c.Atk(w);
    //            }

    //        }
    //        else
    //        {
    //            if (m != null)
    //            {
    //                Console.WriteLine("Mage " + m._Name + " attack creep");
    //                m.SpellAtk(c);
    //            }
    //            else if (w != null)
    //            {
    //                Console.WriteLine("Warrior " + w._Name + " attack creep");
    //                w.MeleeAtk(c);
    //            }
    //        }
    //    }

    //    Mage m1 = getMage();
    //    Warrior w1 = getWarrior();

    //    if (m1 == null && w1 == null)
    //        Console.WriteLine("Creep win");
    //    else
    //        Console.WriteLine("Alliance win");
    //}

    //static bool checkEndCombat()
    //{
    //    if ((getMage() == null && getWarrior() == null) || getCreep() == null)
    //        return true;
    //    return false;
    //}

    //static Warrior getWarrior()
    //{
    //    foreach (Warrior e in Allience1)
    //    {
    //        if (!e.isAlive())
    //            continue;
    //        return e;
    //    }

    //    return null;
    //}

    //static Mage getMage()
    //{
    //    foreach (Mage e in Allience2)
    //    {
    //        if (!e.isAlive())
    //            continue;
    //        return e;
    //    }

    //    return null;
    //}

    //static Creep getCreep()
    //{
    //    foreach (Creep e in Horde)
    //    {
    //        if (!e.isAlive())
    //            continue;
    //        return e;
    //    }

    //    return null;
    //}
    //#endregion
}

