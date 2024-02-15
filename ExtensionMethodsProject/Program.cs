using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodsProject
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonModel person = new PersonModel();

            
            person.FirstName = "What is your first name : ".RequestString();

           
            person.LastName = "What is your Last name : ".RequestString();


            person.Age = "What is your Age : ".RequestInt(0,120);


            Console.ReadLine();
        }
    }
}
