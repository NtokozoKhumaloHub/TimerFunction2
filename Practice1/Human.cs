using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    internal class Human
    {
        private string FirstName;
        private string LastName;
        private string Eyecolor;
        private int age;

        public Human(string firstName, string lastName, string eyecolor, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Eyecolor = eyecolor;
            this.age = age;
        }

        public void IntroduceYourself()
        {
            Console.WriteLine($"Hi my name is {FirstName}, and my surname is {LastName}.");
            Console.WriteLine($"My eyecolor is {this.Eyecolor} and my age is {this.age}.");
        }
    }
}
