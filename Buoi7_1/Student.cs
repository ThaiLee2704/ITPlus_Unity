using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi7_1
{
    public class Student : Person
    {
        public Student()
        {
        }
        public void GoToClasses()
        {
            Console.WriteLine("Toi di hoc");
        }

        public void showAge()
        {
            Console.WriteLine("Tuoi cua toi la: " + this.Age);
        }
    }


}
