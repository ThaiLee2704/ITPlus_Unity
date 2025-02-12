using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class ITStudent : Student, ISkillA, ISkillB
{
    public ITStudent(string name) : base(name) 
    { 
    }

    public override void setScore(float score)
    {
        base.setScore(score);
        if (score < 5.5f)
            Console.WriteLine("Diem trung binh thap");

        
    }

    public void SkillA()
    {
        Console.WriteLine("Using skill A");
    }

    public void SkillB()
    {
        Console.WriteLine("Using skill B");
    }
}

