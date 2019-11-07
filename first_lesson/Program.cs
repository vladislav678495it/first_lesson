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
            // Lab5(task1)
            //const int n = 8;
            //int[] a = new int[n];
            //for( int i=0; i<n;i++)
            //{
            //    Console.WriteLine("A[{0}]=",i);
            //    a[i] = int.Parse(Console.ReadLine());
            //}
            //foreach(int elem in a)
            //    Console.WriteLine("{0}",elem);
            //Console.ReadKey();

            // Lab5(task4)
            //Console.WriteLine("n= ");
            //int n = int.Parse(Console.ReadLine());
            //int[] a = new int[n];
            //Random r = new Random();
            //for (int i = 0; i < n; i++)
            //    a[i] = r.Next(163,191);
            //foreach (int elem in a)
            //    Console.WriteLine(" "+ elem);
            //Console.ReadKey();

            // Lab5(task26)
            //Console.WriteLine("n= ");
            //int n = int.Parse(Console.ReadLine());
            //int[] a = new int[n];
            //for (int i = 0; i < n; i++)
            //{
            //        Console.WriteLine("A[{0}]=", i);
            //        a[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("input k:");
            //int k = int.Parse(Console.ReadLine());
            //int b = 0;
            //foreach (int elem in a)
            //    if (elem % k == 0)
            //    {
            //     b += elem;
            //     Console.WriteLine(" " + elem);
            //    }
            //Console.WriteLine("sum= "+b);
            //Console.ReadKey();

            // Lab5(task27)
            //Console.WriteLine("n= ");
            //int n = int.Parse(Console.ReadLine());
            //int[] a = new int[n];
            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine("A[{0}]=", i);
            //    a[i] = int.Parse(Console.ReadLine());

            //}
            //for (int i = 0; i < n; i++)
            //{
            //    if (a[i] == 0)
            //    { Console.WriteLine(i); }
            //}

            // Lab5(task28)
            // Console.WriteLine("n= ");
            // int n = int.Parse(Console.ReadLine());
            // int[] a = new int[n];
            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine("A[{0}]=", i);
            //    a[i] = int.Parse(Console.ReadLine());
            //    if (i==(n-1))
            //    { if (a[0] > 0)
            //        {
            //            Console.WriteLine(a[0] + " явл. положительным");
            //        }
            //        else
            //        {
            //            Console.WriteLine(a[0] + " явл. отрицательным");
            //        }
            //    }
            //}

            // Lab5(task62)
            /*int sum = 0;
            Console.WriteLine("n= ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("A[{0}]=", i);
                a[i] = int.Parse(Console.ReadLine());
                if(i%2==0)
                {
                    sum += i;
                }
            }
            Console.WriteLine("sum= "+ sum);*/

            // Lab5(task63)
            //Console.WriteLine("n= ");
            //const int n = 30;
            //int[] a = new int[n];
            //Random r = new Random();
            //for (int i = 0; i < n; i++)
            //{
            //    a[i] = r.Next(100, 300);

            //}
            //foreach (int elem in a)
            //    Console.WriteLine(" " + elem);
            //for (int i = 0; i < n; i++)
            //{
            //    if (a[i] > 200)
            //    {
            //        Console.WriteLine("у модели под № " + i + " мощность > 200 л.с." + "\tмощность= "+  a[i]);
            //    }
            //}
            //Console.ReadKey();

            // Lab5(task176) Не получилась
            //Console.WriteLine("n= ");
            //int n = int.Parse(Console.ReadLine());
            //int[] a = new int[n];
            //int c = 0;
            //int d = 0;
            //int f = 0;
            //for (int i = 0; i < a.Length; i++)
            //{
            //    Console.WriteLine("A[{0}]=", i);
            //    a[i] = int.Parse(Console.ReadLine());
            //    c = a[1] - a[0];
            //    int t = a[1] / a[0];
            //    if (i > 1)
            //    {
            //        if (i != a.Length)
            //        {
            //            if (a[i + 1] - a[i] == c)
            //            {
            //                d++;
            //            }
            //            else
            //            {
            //                Console.WriteLine("Это не арифметическая прогрессия");
            //                break;
            //            }
            //            if(a[i+1] / a[i] == t)
            //            {
            //                f++;
            //            }
            //            else
            //            {
            //                Console.WriteLine("Это не геометрическая прогрессия");
            //                break;
            //            }
            //        }
                    
            //    }

            //}
            //if(d==a.Length-1)
            //{
            //    Console.WriteLine("Арифметическая прогрессия");
            //}
            //if(f==a.Length-1)
            //{
            //    Console.WriteLine("Геометрическая прогрессия");
            //}
            //Console.ReadKey();
        }
    }
}
