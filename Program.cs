using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp04
{
    class Program
    {
        static void Main(string[] args)
        {
            #region //Act 12

            Console.WriteLine("Введите радиус для вычисления длинны окружности");
            Сircle.CirLC(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Введите радиус для вычисления площади круга");
            Сircle.CirSC(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Введите радиус, координаты точки Х и У, для определения находится ли точка в пределах окружности");
            Сircle.PointToCir(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
            Console.ReadKey();
            #endregion


        }
        static class Сircle
        {


            internal static void CirLC(int R)
            {
                Console.WriteLine("Длинна окружности: {0}", (2 * Math.PI * R));
            }
            internal static void CirSC(int R)
            {
                Console.WriteLine("Площадь круга: {0}", (Math.PI * R * R));
            }
            internal static void PointToCir(int R, int Point1, int Point2)
            {
                if ((R * R) >= (Point1 * Point1 + Point2 * Point2))
                {
                    Console.WriteLine("Точка принадлежит радиусу окружности");
                }
                else
                {
                    Console.WriteLine("Точка не принадлежит радиусу окружности");
                }
            }
        }
    
    }
}
