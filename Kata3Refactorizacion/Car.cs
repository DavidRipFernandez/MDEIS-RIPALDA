using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataIndividual.Kata3Refactorizacion
{
    public class Car : IDrivable
    {
        public void Drive() => Console.WriteLine("[Refactor] Car is driving");
    }
}
