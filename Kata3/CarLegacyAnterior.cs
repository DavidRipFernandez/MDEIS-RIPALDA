using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataIndividual.Kata3
{
    public class CarLegacyAnterior : IVehicleAnterior
    {
        public void Drive() => Console.WriteLine("[Legacy] Car is driving");
        public void Fly() => throw new NotSupportedException("CarLegacy no puede volar");
        public void Sail() => throw new NotSupportedException("CarLegacy no puede navegar");
    }
}
