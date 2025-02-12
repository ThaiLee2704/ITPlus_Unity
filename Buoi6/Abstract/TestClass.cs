using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class TestClass
{
    public abstract void CallSomething();

    public void NormalFunc()
    {
        Console.WriteLine("BBBBBB");
    }

    public virtual void VirFunc()
    {
        Console.WriteLine("CCCCCCCCC");
    }
}

