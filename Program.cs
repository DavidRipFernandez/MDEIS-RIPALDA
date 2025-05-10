
using KataIndividual.Kata1;
using KataIndividual.Kata1Refactorizacion;
using KataIndividual.Kata2;
using KataIndividual.Kata2Refactorizacion;
using KataIndividual.Kata3;
using KataIndividual.Kata3Refactorizacion;
using System;

namespace KataIndividual
{
    class Program
    {
        static void Main(string[] args)
        {
            // KATA 1 - INTERFAZ MONOLITICA QUE VIOLE ISP
            Console.WriteLine("\n=== Kata 1 - Violación del ISP con interfaz monolítica ===");
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

            Console.WriteLine("\n=== Kata 1 - Solución aplicando ISP ===");

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


            Console.WriteLine("\n=== Kata 2 Sistema Legacy con Métodos no Utilizados ===");
            ILegacyPrinterAnterior legacy = new BasicPrinterAnterior();
            legacy.Print("Documento1.pdf");
            TryAction(() => legacy.Scan("Documento1.pdf"));
            TryAction(() => legacy.Fax("Documento1.pdf"));

            Console.WriteLine("\n=== Kata 2 - Solución ===");
            var BasicPrinter = new BasicPrinter();
            var Scanner = new Scanner();

            BasicPrinter.Print("CartaTrabajo.doc");
            Scanner.Scan("Escanner1.jpg");


            Console.WriteLine("\n=== Kata 3 Operaciones no soportadas ===");

            IVehicleAnterior[] vehicles = {
                new CarLegacyAnterior(),
                new PlaneLegacyAnterior(),
                new BoatLegacyAnterior()
            };

            foreach (var v in vehicles)
            {
                Console.WriteLine($"\n– {v.GetType().Name} –");
                try { v.Drive(); } catch (NotSupportedException e) { Console.WriteLine($"  {e.Message}"); }
                try { v.Sail(); } catch (NotSupportedException e) { Console.WriteLine($"  {e.Message}"); }
                try { v.Fly(); } catch (NotSupportedException e) { Console.WriteLine($"  {e.Message}"); }
            }

            Console.WriteLine("\n=== Kata 3 Gestión de Sensores en un sistema de Monitoreo ===");
            Console.WriteLine("\n– Car –");
            var car = new Car();
            car.Drive();

            Console.WriteLine("\n– Plane –");
            var plane = new Plane();
            plane.fly();

            Console.WriteLine("\n– Boat –");
            var boat = new Boat();
            boat.Sail();



            // SALIR
            Console.WriteLine("\nPresiona una tecla para salir...");
            Console.ReadKey();
        }
        static void TryAction(Action action)
        {
            try
            {
                action();
            }
            catch(NotImplementedException ex)
            {
                Console.WriteLine($"  [Error] {ex.Message}");
            }
        }
    }
}