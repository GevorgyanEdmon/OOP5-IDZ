using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4_IDZ
{
    internal class Геометрия: IInfo
    {
        protected string name;
        protected bool is3D;

        public Геометрия(bool pIs3D, string pName)
        {
            is3D = pIs3D;
            name = pName;
        }

        public bool PIs3D { get; }

        public void GetName()
        {
            Console.WriteLine(name);
        }

        public virtual void GetPerimeter()
        {
            Console.WriteLine("Периметр фигуры не определен");
        }
    }
}
