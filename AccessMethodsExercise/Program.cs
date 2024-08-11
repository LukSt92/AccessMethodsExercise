﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessMethodsExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals =
            {
                new Wolf(false),
                new Hippo(),
                new Wolf(true),
                new Wolf(false),
                new Hippo(),
            };
            foreach (Animal animal in animals)
            {
                animal.MakeNoise();
                if (animal is Hippo hippo)
                    hippo.Swim();
                if (animal is Wolf wolf)
                    wolf.HuntInPack();
            }
            Console.WriteLine();
        }
    }
}
