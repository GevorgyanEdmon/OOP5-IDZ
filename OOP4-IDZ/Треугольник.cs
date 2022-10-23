using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4_IDZ
{
    internal class Треугольник : Геометрия
    {
        protected float st1;
        protected float st2;
        protected float st3;
        public Треугольник(bool pIs3D, string pName, float pSt1, float pSt2, float pSt3) : base(pIs3D, pName)
        {
            st1 = pSt1;
            st2 = pSt2;
            st3 = pSt3;
        }
        public override void GetPerimeter()
        {
            Console.WriteLine($"Периметр ромба = {st1 + st2 + st3}");
        }
    }
}
