using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectExercise_1
{
    class Program
    {
        class Person
        {
            public string firstName = "", lastName = "";
        }
        static void Main(string[] args)
        {
            Person P = new Person() 
            { 
                firstName = "Kalle",
                lastName = "Anka" 
            };
            Person Q = new Person()
            {
                firstName = "Kajsa",
                lastName = "Anka"
            };

        }
    }
}
