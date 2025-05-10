using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataIndividual.Kata1
{
    public class Dog : IAnimal
    {
        public void fly()
        {
            throw new NotImplementedException("Dog can't fly");
        }

        public void Run()
        {
            Console.WriteLine("Dog is running");
        }

        public void Swim()
        {
            Console.WriteLine("Dog is swimming");
        }
    }
}
