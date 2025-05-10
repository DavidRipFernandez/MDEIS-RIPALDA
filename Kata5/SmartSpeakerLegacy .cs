using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataIndividual.Kata5
{
    public class SmartSpeakerLegacy : ISmartDeviceLegacy
    {
        public void ConnectToWiFi() => Console.WriteLine($"[Legacy] SmartSpeaker conectada a WiFi");
        public void PlayMusic() => Console.WriteLine($"[Legacy] SmartSpeaker reproduciendo");
        public void TurnOff() => Console.WriteLine("[Legacy] SmartSpeaker apagado");
        public void TurnOn() => Console.WriteLine("[Legacy] SmartSpeaker encendido");
    }
}
