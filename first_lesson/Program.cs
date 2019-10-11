using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_lesson
{
    class Program
    {
        static void test1(double a,double b, double c)
        {
                if(a!=0 && b!=0 && (b*b-4*a*c)>=0)
                {
                    Console.WriteLine((((b + (Math.Sqrt(Math.Pow(b, 2) + 4 * a * c))) / 2 * a) - Math.Pow(a, 3) * c + Math.Pow(b, -2)));
                } else
            {
                Console.WriteLine("Error!");
            }
            
        }

        static void Main(string[] args)
        {
           /* Console.Write("Enter option number:");
            int  f = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input a:");
            string a1 = Console.ReadLine();
            a1 = a1.Replace(".", ",");
            double a = Convert.ToDouble(a1);
            Console.Write("Input b:");
            string b1 = Console.ReadLine();
            b1 = b1.Replace(".", ",");
            double b = Convert.ToDouble(b1);
            Console.Write("Input c:");
            string c1 = Console.ReadLine();
            c1 = c1.Replace(".", ",");
            double c = Convert.ToDouble(c1);
            switch (f)
            {
                case 1:
                    Console.Write("Output:");
                    test1(a,b,c);
                break;
                case 2:
                    string d1 = Console.ReadLine();
                    d1 = d1.Replace(".", ",");
                    double d = Convert.ToDouble(d1);
                    Console.Write("Output:");
                    Console.WriteLine((a/c)*(b/d)-((a*b-c)/c*d));
                break;
                case 36:
                    Console.Write("Output:");
                    Console.WriteLine(Math.Pow(b,2)-4*a*c);
                    break;
                case 39:
                    Console.Write("Output:");
                    Console.WriteLine(a*b*Math.Sin(c));
                    break;
                case 40:
                    Console.Write("Output:");
                    Console.WriteLine(Math.Sqrt(Math.Pow(a,2)+ Math.Pow(b, 2)-2*a*b* Math.Cos(c)));
                    break;
                case 41:
                    string d2 = Console.ReadLine();
                    d2 = d2.Replace(".", ",");
                    double d3 = Convert.ToDouble(d2);
                    Console.Write("Output:");
                    Console.WriteLine((a*d3+b*c)/a*d3); 
                    break;*/
                double x;
                    while (true)
                    {
                        Console.WriteLine("Enter num:");
                        string input = Console.ReadLine();
                        
                        if (Double.TryParse(input.Replace(".",","), out x))
                        {
                            break;
                        }
                        Console.Clear();
                        Console.WriteLine("Error!");
                    }
                    Console.WriteLine("Num x="+x);
            }
        }
}
