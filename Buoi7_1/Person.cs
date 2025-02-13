using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi7_1
{
    public class Person
    {
        protected int Age;

        public Person() 
        {
            Console.WriteLine("Hello");
        }

        public void SetAge(int newAge)
        {
            this.Age = newAge;
        }
    
    }
}
