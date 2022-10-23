using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4_IDZ
{
    internal class Круг : Геометрия, IPloshad
    {
        protected float diameter;
        public Круг(bool pIs3D, string pName, float pDiameter) : base(pIs3D, pName)
        {
            diameter = pDiameter;
        }
        public override void GetPerimeter()
        {
            Console.WriteLine($"Периметр круга = {diameter/2*3,14}");
        }
        public void GetPloshad()
        {
            Console.WriteLine("Площадь круга: " + 3.14*diameter/2*diameter/2);
        }
    }
}
