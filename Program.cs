
using KataIndividual.Kata1;
using KataIndividual.Kata2Refactorizacion;
using System;

namespace KataIndividual
{
    class Program
    {
        static void Main(string[] args)
        {
            // KATA 1 - INTERFAZ MONOLITICA QUE VIOLE ISP
            Console.WriteLine("\n=== Violación del ISP con interfaz monolítica ===");
            IAnimal[] Monolitico = new IAnimal[] {
            new BirdAnterior(),
            new FishAnterior(),
            new DogAnterior()
            };
            foreach (var a in Monolitico)
            {
                Console.WriteLine($"\n– {a.GetType().Name} –");
                try { a.fly(); } catch (NotImplementedException e) { Console.WriteLine($"  {e.Message}"); }
                try { a.Swim(); } catch (NotImplementedException e) { Console.WriteLine($"  {e.Message}"); }
                try { a.Run(); } catch (NotImplementedException e) { Console.WriteLine($"  {e.Message}"); }
            }

            // KATA 1 - SOLUCION CON REFACTORIZACION DEL CODIGO

            Console.WriteLine("\n=== Solución aplicando ISP ===");

            var bird = new Bird();
            var fish = new Fish();
            var dog = new Dog();

            Console.WriteLine("== Bird ==");
            bird.fly();
            bird.Run();

            Console.WriteLine("\n== Fish ==");
            fish.Swim();

            Console.WriteLine("\n== Dog ==");
            dog.Run();
            dog.Swim();

            Console.WriteLine("\nPresiona una tecla para salir...");
            Console.ReadKey();
        }
    }
}