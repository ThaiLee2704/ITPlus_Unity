using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Student
{
    protected string name;
    protected float score;

    public Student(string name) 
    { 
    }

    public virtual void setScore(float score)
    {
        this.score = score;
    }
}

