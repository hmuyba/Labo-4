using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_4
{
    public class RobotFacade
    {
        private RobotHead robotHead { get; set; }
        private RobotBody robotBody { get; set; }
        private RobotArms robotArms { get; set; }
        private RobotHands robotHands { get; set; }
        private RobotLegs robotLegs { get; set; }
        private RobotFeet robotFeet { get; set; }
        private RobotColor robotColor { get; set; }

        public  RobotFacade()
        {
            robotHead = new RobotHead();
            robotBody = new RobotBody();
            robotArms = new RobotArms();
            robotHands = new RobotHands();
            robotLegs = new RobotLegs();
            robotFeet = new RobotFeet();
            robotColor = new RobotColor();
        }
        public void ChooseColor()
        {
            string color;
            Console.WriteLine("Insert color");
            color = Console.ReadLine();
            robotColor.SetColor(color);
        }
        public void AssemblingRobotParts()
        {
            ChooseColor();
            Console.Clear();
            Console.WriteLine("-----Assembling parts-----");
            robotBody.AssembleBody();
            robotArms.AssembleArms();
            robotHands.AssembleHands();
            robotLegs.AssembleLegs();
            robotFeet.AssembleFeet();
            robotHead.AssembleHead();
            Console.WriteLine("-----Robot ready-----");
        }
    }
}
