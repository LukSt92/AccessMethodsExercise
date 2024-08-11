﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessMethodsExercise
{
    class Wolf : Canine
    {
        public Wolf(bool belongsToPack)
        {
            BelongsToPack = belongsToPack;
        }
        public override void MakeNoise()
        {
            if (BelongsToPack)
                Console.WriteLine("I'm in a pack.");
            Console.WriteLine("Arooooo!");
        }
        public void HuntInPack()
        {
            if (BelongsToPack)
                Console.WriteLine("I'm going hunting with my pack!");
            else
                Console.WriteLine("I'm not in a pack.");
        }
    }
}
