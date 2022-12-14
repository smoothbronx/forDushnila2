using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{

    internal class RoundedRectangle : Rectangle
    {
        private double radius;

        public RoundedRectangle(double radius, double width, double height) : base(width, height)
        {
            this.radius = radius;
        }

        public override void MultByTwo() {
            base.MultByTwo();
            radius *= 2;
        }

        public override double Perimeter() 
        {
            return base.Perimeter() - 8 * radius + 2 * Math.PI * radius;
        }

        public override double Area()
        {
            return base.Area() - 4 * Math.Pow(radius, 2) + Math.PI * Math.Pow(radius, 2);
        }

        public override string GetInformation()
        {
            return base.GetInformation() + $"Radius: {radius}\n";
        }
    }
}
