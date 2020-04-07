using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Person
    {
        private string name; //поле
        private int age;     //
        private List<BankAccount> account = new List<BankAccount>();
        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }

        }
        
        public List<BankAccount> BankAccounts
        {
            get {return accounts; }
            set { BankAccounts = value; }
        }

        public void IntroduceYourcelf()
            {
            Console.WriteLine($"Здравейте. Аз съм {name} и съм на {age} години." );
            }

    }
}
