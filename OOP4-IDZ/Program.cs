using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4_IDZ
{
    class Programm
    {
        static void Main(string[] args)
        {
            List<Геометрия> list = new List<Геометрия>();
            list.Add(new Геометрия(false, "Десятиугольник"));
            list.Add(new Четырехугольник(false, "Четырехугольник", 10, 12, 14, 6));
            list.Add(new Треугольник(false, "равнобедреный Треугольник",3,4,5));
            list.Add(new Квадрат(false, "Квадрат",1,2,3,4));
            list.Add(new Ромб(false, "Ромб", 3,6,9,1,4));
            list.Add(new Прямоугольник(false, "Прямоугольник", 3,4,3,4));
            list.Add(new Круг(false, "Колобок", 12));
            list.Add(new Куб("Куб",12));
            foreach (var geo in list)
            {
                geo.GetPerimeter();
                geo.GetName();
                Console.WriteLine();
            }

            var p = new Куб("Куб", 12);
            p.GetPloshad();
            var p2 = new Круг(false, "Колобок", 12);
            p2.GetPloshad();
            var p3 = new Прямоугольник(false, "Прямоугольник", 3, 4, 3, 4);
            p3.GetPloshad();
        }
    }
}
