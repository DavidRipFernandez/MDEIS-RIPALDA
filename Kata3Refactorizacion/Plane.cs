using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataIndividual.Kata3Refactorizacion
{
    public class Plane : IFlyable
    {
        public void fly() => Console.WriteLine("[Refactor] Plane is flying");
    }
}
