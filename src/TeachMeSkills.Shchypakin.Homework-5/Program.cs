using System;
using System.Linq;
using TeachMeSkills.Shchypakin.Homework_5.Data;
using TeachMeSkills.Shchypakin.Homework_5.Data.Manager;

namespace TeachMeSkills.Shchypakin.Homework_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Chicken chicken = new Chicken("Chicken 1");
            Chicken chicken1 = new Chicken("Chicken 2");
            Chicken chicken2 = new Chicken("Chicken 3");
            Seal seal1 = new Seal("Seal 1");
            Elephant elephant1 = new Elephant("Elephant 1");
            Tiger tiger1 = new Tiger("Tiger 1");
            Elephant elephant2 = new Elephant("Elephant 2");
            
            AnimalFeeder animalFeader = new AnimalFeeder();
            animalFeader.FeedAnimals();
            AnimalReleaser animalReleaser = new AnimalReleaser();
            animalReleaser.ReleaseAnimals();

        }


        
    }
}
