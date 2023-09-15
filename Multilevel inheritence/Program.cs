using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multilevel_inheritence
{
    class Program
    {
        static void Main(string[] args)
        {
            Bird myObj = new Bird();
            Console.WriteLine(myObj.persondet());
            Console.ReadLine();
        }
    }
    public class Person
    {
        public string persondet()
        {
            return "this is the person class";
        }
    }
    public class Bird : Person
    {
        public string birddet()
        {
            persondet();
            return "this is the birddet Class";
        }
    }
    public class Animal : Bird
    {
        public string animaldet()
        {
            persondet();
            birddet();
            return "this is the Animal Class";
        }
    }
}
