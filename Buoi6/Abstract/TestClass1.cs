using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class TestClass1 : TestClass
{
    public override void CallSomething()
    {
        Console.WriteLine("AAAAAAAAA");
    }

    public override void VirFunc()
    {
        base.VirFunc();
    }
}

