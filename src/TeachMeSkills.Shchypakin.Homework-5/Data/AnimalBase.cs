﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachMeSkills.Shchypakin.Homework_5.Data
{
    public abstract class AnimalBase
    {
        public AnimalBase(string name)
        {
            Name = name;
            AllAnimals.Add(Name, this);
            MakeSound();
        }
        public static Dictionary<string, AnimalBase> AllAnimals { get; } = new Dictionary<string, AnimalBase>();
        /// <summary>
        /// Name of the animal
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Used to fead the animal
        /// </summary>
        /// <param name="food"></param>
        public abstract void Eat(Food food);

        public abstract void Move();

        public abstract void MakeSound();

    }
}
