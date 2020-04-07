using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Program
    {
        static void Main(string[] args)
        {
            Person firstP = new Person();
            firstP.Name = "Halil";
            firstP.Age = 23;

            firstP.IntroduceYourcelf();
        }
    }
}
