using System;

namespace Laboratorio_4
{
    public class MainApp
    {
        static void Main(string[] args)
        {
            RobotFacade robotFacade = new RobotFacade();
            robotFacade.AssemblingRobotParts();
            Console.ReadKey();
        }
    }
}
