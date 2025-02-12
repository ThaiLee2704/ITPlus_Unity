using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

public class HinhHop
{
    protected float CD;
    //public readonly float _CD = 3;    //Chỉ cho phép đọc không cho set giá trị 
    //và chỉ được thay đổi trong constructor
    protected float CR;
    protected float ChieuCao;

    public HinhHop()
    {

    }
    public HinhHop(float _CD, float initCR, float initCC)
    {
        this.CD = _CD;
        this.CR = initCR;
        this.ChieuCao = initCC;
    }

    public virtual void Test()
    {
        Console.WriteLine("Hello World!");
    }
}

