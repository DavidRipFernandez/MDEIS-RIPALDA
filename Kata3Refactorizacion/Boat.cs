using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataIndividual.Kata3Refactorizacion
{
    public class Boat : ISailable
    {
        public void Sail() => Console.WriteLine("[Refactor] Boat is sailing");
    }
}
