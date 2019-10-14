using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_lesson
{
    class Program
    {
static void Main(string[] args)
        {
            //  Lab2 ( task 1)
            /* Console.WriteLine("Вычисление частного.");
             Console.WriteLine("Введите в одной строке делимое и делитель, затем нажмите <Enter>.");
             string a1 = Console.ReadLine();
             a1 = a1.Replace('.', ',');
             double a = Convert.ToDouble(a1);
             string b1 = Console.ReadLine();
             b1 = b1.Replace('.', ',');
             double b = Convert.ToDouble(b1);
             if (b == 0)
             {
                 Console.WriteLine("Вы ошиблись.Делитель не должен быть равен нулю.");
             } else
             {
             a /= b;
             Console.WriteLine(a);
             }
             */
            //  Lab2 ( task 2)
            /* Console.WriteLine("Вычисление площади кольца.");
             Console.WriteLine("Введите исходные данные:");
             Console.WriteLine("Радиус кольца(см) ->");
             string a1 = Console.ReadLine();
             a1 = a1.Replace('.', ',');
             double a = Convert.ToDouble(a1);
             Console.WriteLine("Радиус отверстия (см) ->");
             string b1 = Console.ReadLine();
             b1 = b1.Replace('.', ',');
             double b = Convert.ToDouble(b1);
             if(b>a)
             {
                 Console.WriteLine("Ошибка! Радиус отверстия не может быть больше радиуса кольца.");
             }
             else
             {
                 double s = Math.PI *(a*a-b*b);
                 Console.WriteLine(s);
             } */
            //  Lab2 ( task 3)
            /* Console.WriteLine("Введите время(минут секунд) ->");
             string a1 = Console.ReadLine();
             a1 = a1.Replace('.', ',');
             int min = Convert.ToInt32(a1);
             string b1 = Console.ReadLine();
             b1 = b1.Replace('.', ',');
             int sec = Convert.ToInt32(b1);
             if(sec>60)
             {
                 Console.WriteLine("Ошибка!Количество секунд не может быть больше 60");
             }
             else
             {
                 int time = min * 60 + sec;
                 Console.WriteLine("Результат: "+time+ " sec");
             }
              Console.WriteLine("Для завершения нажмите <Enter>");*/

            //  Lab2 ( task 4)
            /*Console.WriteLine("Введите год, например 2000, и нажмите <Enter>");
            Console.WriteLine("-> ");
            string a1 = Console.ReadLine();
            int year = Convert.ToInt32(a1);
            if ((year%4==0) && year != 1700 && year != 1800 && year != 1900 && year != 2100 && year != 2200 && year != 2300)
            {
                Console.WriteLine(year + " год является високосным");
            }
            else 
            {
                Console.WriteLine(year + " год - не високосный");
            }  
            Console.WriteLine("Для завершения нажмите <Enter>"); */
            //  Lab2 ( task 5)
            /*Console.WriteLine("Вычисление сопротивления электрической цепи.");
            Console.WriteLine("Введите исходные данные:");
            Console.WriteLine("Величина первого сопротивления (Ом) ->");
            string a1 = Console.ReadLine();
            a1 = a1.Replace('.', ',');
            double a = Convert.ToDouble(a1);
            Console.WriteLine("Величина второго сопротивления (Ом)-> ");
            string b1 = Console.ReadLine();
            b1 = b1.Replace('.', ',');
            double b = Convert.ToDouble(b1);
            Console.WriteLine("Тип соединения(1 — последовательное, 2 — параллельное) ->");
            string c1 = Console.ReadLine();
            c1 = c1.Replace('.', ',');
            int c = Convert.ToInt32(c1);
            if (c==1)
            {
                a += b;
                Console.WriteLine("Сопротивление цепи:"+ a + "Ом ");
            } else if ( c==2 )
            {
                double r = (1 / a)+ ( 1 / b);
                Console.WriteLine("Сопротивление цепи: " + (1/r) + " Ом ");
            }*/
            //  Lab2 ( task 6)
            Console.WriteLine("Решение квадратного уравнения");
            Console.WriteLine("Введите в одной строке значения коэффициентов и нажмите < Enter > ->");
            string a1 = Console.ReadLine();
            a1 = a1.Replace('.', ',');
            double a = Convert.ToDouble(a1);
            string b1 = Console.ReadLine();
            b1 = b1.Replace('.', ',');
            double b = Convert.ToDouble(b1);
            string c1 = Console.ReadLine();
            c1 = c1.Replace('.', ',');
            double c = Convert.ToDouble(c1);
            Console.WriteLine("Корни уравнения:");
            if (a != 0)
            {
                double d = b * b - 4 * a * c;
                if (d>0)
                {
                    double x1 = (-b - Math.Sqrt(d)) / (2 * a);
                    double x2 = (-b + Math.Sqrt(d)) / (2 * a);
                    Console.WriteLine("x1= " + x1);
                    Console.WriteLine("x2= " + x2);
                }
                if (d==0)
                {
                    double x = -b / 2 * a;
                    Console.WriteLine("x= " + x);
                }
                if (d<0)
                {
                    Console.WriteLine("Уравнение не имеет корней.");
                }
            } else
            {
                Console.WriteLine(" коэффициент при второй степени неизвестного не должен быть равен нулю");
            }
        }
    }
}
