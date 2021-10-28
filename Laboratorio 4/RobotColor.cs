using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_4
{
    public class RobotColor
    {
        public string Color { get; set; }
        public void SetColor(string color)
        {
            Color = color;
            Console.WriteLine("Color: Choose Color " + Color);
        }
    }
}
