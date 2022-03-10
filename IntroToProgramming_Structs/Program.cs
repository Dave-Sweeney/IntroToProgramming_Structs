using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToProgramming_Structs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            name myName = new name("John", "", "Smith", "Jr.");
            Console.WriteLine(myName.firstName);
            Console.WriteLine(myName.middleName);
            Console.WriteLine(myName.getFullName());
            myName.middleName = "Billy";
            Console.WriteLine(myName.middleName);
            Console.WriteLine(myName.getFullName());

            Console.ReadLine();
        }

        public struct name
        {
            public string firstName;
            public string middleName;
            private string lastName;
            private string suffix;

                        
            public name(string first, string middle, string last, string suffix)
            {
                this.firstName = first;
                this.middleName = middle;  
                this.lastName = last;
                this.suffix = suffix;
            }

            public string getFullName()
            {
                return $"{ firstName } { middleName } { lastName } { suffix }";
            }

            

        }
    }
}
