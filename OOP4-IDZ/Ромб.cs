using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4_IDZ
{
    internal class Ромб : Четырехугольник
    {
        protected float visota;
        public Ромб(bool pIs3D, string pName, float pSt1, float pSt2, float pSt3, float pSt4, float pVisota) : base(pIs3D, pName, pSt1, pSt2, pSt3, pSt4)
        {
            visota = pVisota;
        }
        public override void GetPerimeter()
        {
            Console.WriteLine($"Периметр ромба = {st1+st2+st3+st4}");
        }
    }
}
