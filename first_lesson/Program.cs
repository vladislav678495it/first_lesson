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
            if ((year%4==0) && (year%400==0)
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
            /*Console.WriteLine("Решение квадратного уравнения");
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
            }*/
            //  Lab2 ( task 7)
            /*Console.WriteLine("Вычисление стоимости покупки с учетом скидки");
            Console.WriteLine("Введите сумму покупки и нажмите <Enter>->");
            string a1=Console.ReadLine();
            a1 = a1.Replace('.', ',');
            double a = Convert.ToDouble(a1);
            if(a>1000)
            {
                double b = a / 10;
                a -= b;
                Console.WriteLine("Вам предоставляется скидка 10%");
                Console.WriteLine("Сумма покупки с учетом скидки: "+ a +" грн.");
            }else
            {
                Console.WriteLine("Сумма покупки : " + a + " грн.");
            }*/
            //  Lab2 ( task 8)
            /* Console.WriteLine("Вычисление стоимости покупки с учетом скидки");
             Console.WriteLine("Введите сумму покупки и нажмите <Enter>->");
             string a1 = Console.ReadLine();
             a1 = a1.Replace('.', ',');
             double a = Convert.ToDouble(a1);
             if (a>500 && a < 1000)
             {
                 double b = a * 0.03;
                 a -= b;
                 Console.WriteLine("Вам предоставляется скидка 3% ");
                 Console.WriteLine("Сумма  с учетом скидки: " + a + " грн.");
             } else if (a>1000)
             {
                 double b = a / 20;
                 a -= b;
                 Console.WriteLine("Вам предоставляется скидка 5% ");
                 Console.WriteLine("Сумма  с учетом скидки: " + a + " грн.");
             }
             Console.WriteLine("Сумма покупки : " + a + " грн.");*/
            //  Lab2 ( task 9)
            /*Console.WriteLine("В каком году была основана Одесса ?");
            Console.WriteLine("Введите число и нажмите <Enter>->");
            string a1 = Console.ReadLine();
            a1 = a1.Replace('.', ',');
            double a = Convert.ToDouble(a1);
            if(a==1794)
            {
                Console.WriteLine("Ответ правильный !");
            }
            else
            {
                Console.WriteLine("Вы ошиблись, Одесса была основана в 1794 году.");
            }*/
            //  Lab2 ( task 10)
            /*Console.WriteLine("В каком году началась вторая мировая война?");
            Console.WriteLine("Введите число и нажмите <Enter>->");
            string a1 = Console.ReadLine();
            a1 = a1.Replace('.', ',');
            double a = Convert.ToDouble(a1);
            if (a==1939)
            {
                Console.WriteLine("Правильно.");
            } else
            {
                Console.WriteLine("Не правильно.");
            }*/
            //  Lab2 ( task 11)
            /*Console.WriteLine("Архитектор Исаакиевского собора:");
            Console.WriteLine("\t 1.Доменико Трезини");
            Console.WriteLine("\t 2.Огюст Монферран");
            Console.WriteLine("\t 3.Карл Росси");
            Console.WriteLine("Введите номер правильного ответа и нажмите <Enter>->");
            string a1 = Console.ReadLine();
            a1 = a1.Replace('.', ',');
            double a = Convert.ToDouble(a1);
            if(a==2)
            {
                Console.WriteLine(" Ответ правильный"); 
            } else
            {
                Console.WriteLine("Вы ошиблись. Архитектор Исаакиевского собора — Огюст Монферран.");
            }*/
            //  Lab2 ( task 12)
            /*Console.WriteLine("Невский проспект получил свое название:");
            Console.WriteLine("1. По имени реки, на берегах которой расположен Санкт-Петербург");
            Console.WriteLine("2. По имени близлежащего монастыря Александро-Невской лавры");
            Console.WriteLine("3. В память о знаменитом полководце Александре Невском");
            Console.WriteLine("Введите номер правильного ответа и нажмите <Enter> ->");
            string a1 = Console.ReadLine();
            a1 = a1.Replace('.', ',');
            double a = Convert.ToDouble(a1);
            if(a==2)
            {
                Console.WriteLine("Ответ правильный");
            } else
            {
                Console.WriteLine("Вы ошиблись.");
                Console.WriteLine("Правильный ответ: 2.");
            }*/
            //  Lab2 ( task 13)
            /*Console.WriteLine("Введите в одной строке два целых числа и нажмите <Enter>.->");
            string a1 = Console.ReadLine();
            a1 = a1.Replace('.', ',');
            double a = Convert.ToDouble(a1);
            string b1= Console.ReadLine();
            b1 = b1.Replace('.', ',');
            double b=Convert.ToDouble(b1);
            if(a<b)
            {
                Console.WriteLine(a+ " меньше " + b);
            } else if(a>b)
            {
                Console.WriteLine(a + " больше " + b);
            } else if (a==b)
            {
                Console.WriteLine(a + " равно " + b);
            }*/
            //  Lab2 ( task 14)
            /*Console.WriteLine("Введите два числа и нажмите <Enter>->");
            string a1 = Console.ReadLine();
            a1 = a1.Replace('.', ',');
            double a = Convert.ToDouble(a1);
            string b1 = Console.ReadLine();
            b1 = b1.Replace('.', ',');
            double b = Convert.ToDouble(b1);
            Console.WriteLine("Сколько будет "+a+"*"+b+" ? Введите ответ и нажмите <Enter>");
            string c1 = Console.ReadLine();
            c1 = c1.Replace('.', ',');
            double c = Convert.ToDouble(c1);
            double d=a*b;
            if(d==c)
            {
                Console.WriteLine("Правильно.");
            }
            else
            {
                Console.WriteLine("Вы ошиблись. "+a+"*"+b+"="+d);
            }*/
            //  Lab2 ( task 15)
            /*Console.WriteLine("Введите два числа и нажмите <Enter>->");
            string a1 = Console.ReadLine();
            a1 = a1.Replace('.', ',');
            double a = Convert.ToDouble(a1);
            string b1 = Console.ReadLine();
            b1 = b1.Replace('.', ',');
            double b = Convert.ToDouble(b1);
            Console.WriteLine("Сколько будет " + a + "-" + b + " ? Введите ответ и нажмите <Enter>");
            string c1 = Console.ReadLine();
            c1 = c1.Replace('.', ',');
            double c = Convert.ToDouble(c1);
            double d = a-b;
            if (d == c)
            {
                Console.WriteLine("Правильно.");
            }
            else
            {
                Console.WriteLine("Вы ошиблись. " + a + "-" + b + "=" + d);
            }*/
            //  Lab2 ( task 16)
            /*Console.WriteLine("Введите целое число и нажмите <Enter>->");
            string a1 = Console.ReadLine();
            a1 = a1.Replace('.', ',');
            int a = Convert.ToInt32(a1);
            if(a%2==0)
            {
                Console.WriteLine("Число "+ a +" - четное.");
            }
            else
            {
                Console.WriteLine("Число " + a + " - нечетное.");
            }*/
            //  Lab2 ( task 17)
            /*Console.WriteLine("Введите целое число и нажмите <Enter>->");
            string a1 = Console.ReadLine();
            a1 = a1.Replace('.', ',');
            int a = Convert.ToInt32(a1);
            if(a%3==0)
            {
                Console.WriteLine("Число "+ a + " делится на три.");
            } else
            {
                Console.WriteLine("Число " + a + " нацело на три не делится.");
            }*/
            //  Lab2 ( task 18)
            /* Console.WriteLine("Вычисление стоимости разговора по телефону.");
             Console.WriteLine("Введите исходные данные:");
             Console.WriteLine("Длительность разговора (целое количество минут) -> ");
             string a1 = Console.ReadLine();
             a1 = a1.Replace('.', ',');
             int a = Convert.ToInt32(a1);
             Console.WriteLine("День недели (1 — понедельник, ... 7 — воскресенье) ->");
             string b1 = Console.ReadLine();
             b1 = b1.Replace('.', ',');
             int b = Convert.ToInt32(b1);
             if(b>0 && b<8)
             {
                 a *= 2;
                 if (b==6 || b==7)
                 {
                     double c= a/5 ;
                     double d= a-c;
                     Console.WriteLine("Предоставляется скидка 20%.");
                     Console.WriteLine("Стоимость разговора: "+ d +" грн.");
                 } else
                 {
                     Console.WriteLine("Стоимость разговора: " + a + " грн.");
                 }
             } else
             {
                 Console.WriteLine("Error!");
             }*/
            //  Lab2 ( task 19)
            /*Console.WriteLine("Введите в одной строке через пробел рост (см) и вес (кг), затем нажмите <Enter>->");
            string a1 = Console.ReadLine();
            a1 = a1.Replace('.', ',');
            int a = Convert.ToInt32(a1);
            string b1 = Console.ReadLine();
            b1 = b1.Replace('.', ',');
            int b = Convert.ToInt32(b1);
            if(a>100)
            {
                int c=a-100;
                if(c==b)
                {
                    Console.WriteLine("Всё хорошо !");
                }else if (c > b)
                {
                    c -= b;
                    Console.WriteLine("Вам надо поправиться на "+ c +" грн.");
                } else if (c < b)
                {
                    b -= c;
                    Console.WriteLine("Вам надо похудеть на " + b + " грн.");
                }
            } else
            {
                Console.WriteLine("Error!");
            }*/
            //  Lab2 ( task 20)
            /*Console.WriteLine("Введите номер месяца (число от 1 до 12)");
            string a1 = Console.ReadLine();
            a1 = a1.Replace('.', ',');
            int a = Convert.ToInt32(a1);
            if(a !=0 && a<=12)
            {
                if(a<=2 || a==12)
                {
                    Console.WriteLine("Зима ");
                }else if (3 <=a && a < 6)
                {
                    Console.WriteLine("Весна ");
                }
                else if (6 <= a && a < 9 )
                {
                    Console.WriteLine("Лето ");
                } else if ( 9 <= a && a <12)
                {
                    Console.WriteLine("Осень ");
                }
            } else
            {
                Console.WriteLine("Ошибка ввода данных.");
            }*/
            //  Lab2 ( task 21)
            /*Console.WriteLine("Введите номер дня недели (число от 1 до 7)-> ");
            string a1 = Console.ReadLine();
            a1 = a1.Replace('.', ',');
            int a = Convert.ToInt32(a1);
            if(a>0 && a<=5)
            {
                Console.WriteLine("Это рабочий день");
            } else if (a==6)
            {
                Console.WriteLine("Суббота");
            } else if (a==7)
            {
                Console.WriteLine("Воскресенье");
            }*/
            //  Lab2 ( task 22)
            /*Console.WriteLine("Сколько раз хочешь вводить: ");
            string q1 = Console.ReadLine();
            q1 = q1.Replace('.', ',');
            int q = Convert.ToInt32(q1);
            for (int j = 0; j < q; j++)
            {
                Console.WriteLine("Введите целое число рублей (число от 1 до 999)->");
                string a1 = Console.ReadLine();
                a1 = a1.Replace('.', ',');
                int a = Convert.ToInt32(a1);
                if (a < 999 && a > 0)
                {

                    if ((a % 10 == 1) && a != 11)
                    {
                        Console.WriteLine(a + " рубль");
                    }
                    else if (a > 11 && a < 15)
                    {
                        Console.WriteLine(a + " рублей");
                    }else if (a % 10 == 2 || a % 10 == 3 || a % 10 == 4)
                    { 
                        Console.WriteLine(a + " рубля");
                    } else if (a%10==0||a==11)
                    {
                        Console.WriteLine(a + " рублей");
                    }
                    for (int y = 5; y < 10; y++)
                    {
                        if (a % 10 == y)
                        {
                            Console.WriteLine(a + " рублей");
                        }
                    }
                }
            }*/
            //  Lab2 ( task 23)
           /* Console.WriteLine("Сколько раз хочешь вводить: ");
            string q1 = Console.ReadLine();
            q1 = q1.Replace('.', ',');
            int q = Convert.ToInt32(q1);
             for (int j = 0; j < q; j++)
             {
                    Console.WriteLine("Введите целое число рублей (число от 1 до 99)->");
                    string a1 = Console.ReadLine();
                    a1 = a1.Replace('.', ',');
                    int a = Convert.ToInt32(a1);
                if (a > 0 && a < 100)
                {
                    if (a % 10 == 1 && a != 11)
                    {
                        Console.WriteLine(a + " копейка");
                    }
                    else if (a == 10 || a == 11 || a == 12 || a == 13 || a==14)
                    {
                        Console.WriteLine(a + " копеек");
                    }
                    else if (a % 10 == 2 || a % 10 == 3 || a % 10 == 4)
                    {
                        Console.WriteLine(a + " копейки");
                    }
                    else
                    {
                        Console.WriteLine(a+" копеек");
                    }
                }
                else
                {
                    Console.WriteLine("Error!");
                }
             }*/
        }
    }
}
