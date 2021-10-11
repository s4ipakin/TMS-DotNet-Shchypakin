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
            Chicken chicken = new Chicken("Ch");
            Chicken chicken1 = new Chicken("Ch1");
            Chicken chicken2 = new Chicken("Ch2");
            Seal seal1 = new Seal("Seal1");
            Elephant elephant1 = new Elephant("Elephant1");
            Tiger tiger1 = new Tiger("Tiger1");

            AnimalFeeder animalFeader = new AnimalFeeder();
            animalFeader.FeedAnimals();
            AnimalReleaser animalReleaser = new AnimalReleaser();
            animalReleaser.ReleaseAnimals();

        }


        
    }
}
