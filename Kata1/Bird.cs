using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataIndividual.Kata1
{
    public class Bird : IAnimal
    {
        public void fly()
        {
            Console.WriteLine("Bird is flying");
        }

        public void Run()
        {
            Console.WriteLine("Bird is running");
        }

        public void Swim()
        {
            throw new NotImplementedException("Bird can´t swim");
        }
    }
}
