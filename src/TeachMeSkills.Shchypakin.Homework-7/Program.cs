using System;
using TeachMeSkills.Shchypakin.Homework_7.Manager;
using TeachMeSkills.Shchypakin.Homework_7.Manager.Controller;

namespace TeachMeSkills.Shchypakin.Homework_7
{
    class Program
    {
        static void Main(string[] args)
        {
            UiFitnessOperationController operationController = new UiFitnessOperationController();
            ConsoleUi<UiFitnessOperationController> Ui = new ConsoleUi<UiFitnessOperationController>(operationController);
            Ui.Run();
        }
    }
}
