﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataIndividual.Kata1Refactorizacion
{
    public class Bird : IFlyable, IRunnable
    {
        public void fly()
        {
            Console.WriteLine("Bird is flying");
        }

        public void Run()
        {
            Console.WriteLine("Bird is running");
        }
    }
}
