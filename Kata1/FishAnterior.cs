using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataIndividual.Kata1
{
    public class FishAnterior : IAnimal
    {
        public void fly()
        {
            throw new NotImplementedException("Fish can't fly");
        }

        public void Run()
        {
            throw new NotImplementedException("Fish can't run");
        }

        public void Swim()
        {
            Console.WriteLine("Fish is swimming");
        }
    }
}
