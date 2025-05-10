using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataIndividual.Kata5
{
    public class SmartLightLegacy : ISmartDeviceLegacy
    {
        public void ConnectToWiFi() => Console.WriteLine($"[Legacy] SmartLight conectada a WiFi");
        public void PlayMusic() => throw new NotSupportedException("SmartLightLegacy no puede reproducir música");
        public void TurnOff() => Console.WriteLine("[Legacy] SmartLight apagada");
        public void TurnOn() => Console.WriteLine("[Legacy] SmartLight encendida");
    }
}
