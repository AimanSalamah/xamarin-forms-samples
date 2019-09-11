﻿using System.Collections.Generic;

namespace CarouselViewDemos.Models
{
    public class AnimalGroup : List<Animal>
    {
        public string Name { get; private set; }

        public AnimalGroup(string name, List<Animal> animals) : base(animals)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
