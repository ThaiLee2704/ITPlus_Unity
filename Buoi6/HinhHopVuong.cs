using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class HinhHopVuong : HinhHop
{
    public string name;

    public HinhHopVuong()
    {
        Console.WriteLine("CD = CR = CC = " + this.CR);
    }

    public override void Test()
    {
        base.Test();    //Gọi ra để có thể mở rộng dựa trên lớp cha chứ không ghi đè hoàn toàn lớp cha
        Console.WriteLine("Day la hinh hop vuong");
    }
}

