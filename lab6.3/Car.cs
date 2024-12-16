﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6._3
{
    internal class Car
    {
        public string Name { get; set; }
        public string Color { get; set; }

        public Car(string name, string color)
        {
            Name = name;
            Color = color;
        }

        public void Display()
        {
            System.Console.WriteLine($"Car Name: {Name}, Color: {Color}");
        }
    }
}

