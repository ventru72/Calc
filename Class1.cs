using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Calc
{
     public  class Calc
    {

        protected double radius;
        protected double a;
        protected double b;
        protected double c;
        protected const double PI = 3.14;
        protected double result;

        public Calc() { }

        public Calc(double radius)
        {
            this.radius = radius;
        }
        private Calc(double radius,  double PI)
        {
            this.radius = radius;
        }
        public Calc(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;

        }
    }
    public class Square : Calc
    {
        public Square() { }
        public Square(double radius) : base(radius) { }

        public Square(double a, double b, double c) : base(a, b, c) { }
        /// <summary>
        /// Расчет площади круга и треугольника
        /// </summary>
        /// <param name="Result"></param>
        public void Result(double radius)
        {
            result = PI * radius * radius;
            Console.Write($"\nПлощадь круга = {result}");
            Console.ReadKey();
        }
        public void Result(double a, double b, double c)
        {

            List<double> list = new List<double>();

            list.Add(a);
            list.Add(b);
            list.Add(c);

            double p = (a + b + c) / 2;
            result = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.Write($"\nПлощадь треугольника = {result}");
            list.Sort();
            if (list[2] == Math.Sqrt(Math.Pow(list[1], 2) + Math.Pow(list[0], 2)))
            {
                Console.WriteLine("\nТреугольник прямоугольный!");
            }
            Console.ReadKey();
        }
    }
}