using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwith_Constructore
{
    class Program
    {
        int Num = 10;
        

        public Program()
        {
            int no = Num;
        }

        int x = 10;
        int y = 20 ;
        public Program(int num1, int num2)
    {
        x =num1;
        y = num2;
    }

        static void Main(string[] args)
        {
            Program obj = new Program();
            Console.WriteLine(obj.Num);

            Class1 obj2 = new Class1("Microsoft", "Asp.net");
            Console.WriteLine(obj2.param1+"Welcomes you in  "+ obj2.param2+ "world");

            Program obj3 = new Program();
            Console.WriteLine(obj3.x + ": x value and " + obj3.y + "y value");
            Console.ReadKey();
        }
    }
}
