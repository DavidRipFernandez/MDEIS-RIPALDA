using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataIndividual.Kata2Refactorizacion
{
    public class Fish : ISwimmable
    {
        public void Swim()
        {
            Console.WriteLine("Fish is swimming");
        }
    }
}
