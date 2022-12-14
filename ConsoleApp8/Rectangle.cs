using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Rectangle
    {
        protected double width;
        protected double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public virtual double Perimeter()
        {
            return width * 2 + height * 2;
        }

        public virtual double Area()
        {
            return width * height;
        }

        public virtual void MultByTwo() 
        {
            width *= 2;
            height *= 2;
        }

        public virtual string GetInformation() {
            return $"Width: {width}; Height: {height}\nPerimeter: {Perimeter()}\nArea: {Area()}\n";
        }
    }
}
