
using KataIndividual.Kata1;
using KataIndividual.Kata1Refactorizacion;
using KataIndividual.Kata2;
using KataIndividual.Kata2Refactorizacion;
using KataIndividual.Kata3;
using KataIndividual.Kata3Refactorizacion;
using KataIndividual.Kata4;
using KataIndividual.Kata4Refactorizacion;
using KataIndividual.Kata5;
using KataIndividual.Kata5Refactorizacion;
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


            Console.WriteLine("\n=== Kata 2 Sistema Legacy con Métodos no Utilizados (SIN SOLID)===");
            ILegacyPrinterAnterior legacy = new BasicPrinterAnterior();
            legacy.Print("Documento1.pdf");
            TryAction(() => legacy.Scan("Documento1.pdf"));
            TryAction(() => legacy.Fax("Documento1.pdf"));

            Console.WriteLine("\n=== Kata 2 - Solución con Refactorización ===");
            var BasicPrinter = new BasicPrinter();
            var Scanner = new Scanner();

            BasicPrinter.Print("CartaTrabajo.doc");
            Scanner.Scan("Escanner1.jpg");


            Console.WriteLine("\n=== Kata 3 Operaciones no soportadas (SIN SOLID)===");

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

            Console.WriteLine("\n=== Kata 3 - Solucion con Refactorización ===");
            Console.WriteLine("\n– Car –");
            var car = new Car();
            car.Drive();

            Console.WriteLine("\n– Plane –");
            var plane = new Plane();
            plane.fly();

            Console.WriteLine("\n– Boat –");
            var boat = new Boat();
            boat.Sail();


            Console.WriteLine("\n=== Kata 4 Gestión de Sensores en un sistema de monitoreo (SIN SOLID)===");
            ISensorLegacy[] MonitoreoSensors = {
                new TemperatureSensorLegacy(),
                new PreassureSensorLegacy(),
                new HumiditySensorLegacy()
            };
            foreach (var v in MonitoreoSensors)
            {
                Console.WriteLine($"\n– {v.GetType().Name} –");
                try { v.ReadTemperature(); } catch (NotSupportedException e) { Console.WriteLine($"  {e.Message}"); }
                try { v.ReadPreassure(); } catch (NotSupportedException e) { Console.WriteLine($"  {e.Message}"); }
                try { v.ReadHumidity(); } catch (NotSupportedException e) { Console.WriteLine($"  {e.Message}"); }
            }

            Console.WriteLine("\n=== Kata 4 - Solución con Refactorización");


            Console.WriteLine("\n– HumiditySensor –");
            var humidity = new HumiditySensor();
            Console.WriteLine($"Humidity: {humidity.ReadHumidity()}");

            Console.WriteLine("\n– PressureSensor –");
            var pres = new PreassureSensor();
            Console.WriteLine($"Pressure: {pres.ReadPreassure()}");

            Console.WriteLine("\n=== Kata 5 - Intefaz de Dispositivo IOT (SIN SOLID)");
            ISmartDeviceLegacy[] SmartDevices = {
                new SmartLightLegacy(),
                new SmartSpeakerLegacy()
            };
            foreach (var v in SmartDevices)
            {
                Console.WriteLine($"\n– {v.GetType().Name} –");
                try { v.TurnOff(); } catch (NotSupportedException e) { Console.WriteLine($"  {e.Message}"); }
                try { v.TurnOn(); } catch (NotSupportedException e) { Console.WriteLine($"  {e.Message}"); }
                try { v.ConnectToWiFi(); } catch (NotSupportedException e) { Console.WriteLine($"  {e.Message}"); }
                try { v.PlayMusic(); } catch (NotSupportedException e) { Console.WriteLine($"  {e.Message}"); }
            }

            Console.WriteLine("\n=== Kata 5 - Solucion con Refactorización");
            Console.WriteLine("\n– SmartLight –");
            var light = new SmartLight();
            light.TurnOn();
            light.ConnectToWiFi();
            light.TurnOff();

            Console.WriteLine("\n– SmartSpeaker –");
            var speaker = new SmartSpeaker();
            speaker.TurnOn();
            speaker.ConnectToWiFi();
            speaker.PlayMusic();
            speaker.TurnOff();



            Console.WriteLine("\n=== Kata 6 - Sistema de Pago en E-Commerce (SIN SOLID)");


            Console.WriteLine("\n=== Kata 6 - Solucióin con Refactorización");


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