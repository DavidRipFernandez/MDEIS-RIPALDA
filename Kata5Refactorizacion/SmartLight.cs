using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataIndividual.Kata5Refactorizacion
{
    public class SmartLight : IPowerControllable, IWiFiConnectable
    {
        public void ConnectToWiFi() => Console.WriteLine($"[Refactor] SmartLight conectada a WiFi");

        public void TurnOff() => Console.WriteLine("[Refactor] SmartLight apagada");

        public void TurnOn() => Console.WriteLine("[Refactor] SmartLight encendida");
    }
}
