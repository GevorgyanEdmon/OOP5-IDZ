using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4_IDZ
{
    internal class Куб : Геометрия, IPloshad
    {
        protected float storona;
        public Куб(string pName, float pStorona, bool pIs3D=true) : base(pIs3D=true, pName)
        {
            is3D = true;
            storona = pStorona;
        }
        public override void GetPerimeter()
        {
            Console.WriteLine($"Периметр куба = {12*storona}");
        }

        public void GetPloshad()
        {
            Console.WriteLine("Площадь куба: "+storona*storona*storona);
        }
    }
}
