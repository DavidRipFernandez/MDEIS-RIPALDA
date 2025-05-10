using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataIndividual.Kata5Refactorizacion
{
    public class SmartSpeaker : IPowerControllable, IWiFiConnectable, IMusicPlayable
    {
        public void ConnectToWiFi()
        => Console.WriteLine($"[Refactor] SmartSpeaker conectada a WiFi");
        public void PlayMusic()
        => Console.WriteLine($"[Refactor] SmartSpeaker reproduciendo");
        public void TurnOff()
        => Console.WriteLine("[Refactor] SmartSpeaker apagado");
        public void TurnOn()
        => Console.WriteLine("[Refactor] SmartSpeaker encendido");
    }
}
