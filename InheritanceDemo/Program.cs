using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape S1 = new Shape();
            S1.H = 10;
            S1.W = 5;
            S1.Draw();
            S1.CalculateArea();

            Rectangle r1 = new Rectangle();
            r1.H = 20;
            r1.W = 10;
            r1.Draw();
            r1.CalculateArea();

        }


    }
    
   class Shape
    {
        public int H { get; set; }

        public int W { get; set; }
        public void Draw()
        {
            Console.WriteLine("Drawing shape");
        }

        public void CalculateArea()
        {
            Console.WriteLine($"area is {H * W}");
        }
    }

    class Rectangle : Shape
    {
        
    }
}
