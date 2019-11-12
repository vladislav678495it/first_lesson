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

            //Lab6(task1072)
            //const int n = 16;
            //Console.WriteLine("n=15 ");
            //Console.Write("m= ");
            //int m = int.Parse(Console.ReadLine());
            //int[,] a = new int[n, m];
            //int[] b = new int[m];
            //Random r = new Random();
            //for (int i = 1; i < n ; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {
            //        a[i, j] = r.Next(0, 100);
            //        Console.Write(a[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //    if (i % 3 == 0)
            //    {
            //        for (int j = 0; j < m; j++)
            //        {
            //            b[j] = r.Next(0);
            //            Console.Write(b[j] + " ");
            //        }
            //        Console.WriteLine();
            //    }
            //}
            //Console.ReadKey();
            //Lab6(task1073)
            //const int m = 21;
            //Console.Write("n= ");
            //int n = int.Parse(Console.ReadLine());
            //int[,] a = new int[n, m];
            //int[,] b = new int[n, m];
            //Console.WriteLine("m= 20 ");
            //Random r = new Random();
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 1; j < m; j++)
            //    {
            //        a[i, j] = r.Next(1,50);
            //        Console.Write(a[i, j] + "\t");
            //        if (j % 2 == 0)
            //        {
            //            b[i,j] = 10;
            //            Console.Write(b[i,j] + " ");
            //        }
            //    }
            //    Console.WriteLine();
            //}
            //Lab6(task1074(а))
            //Console.Write("n= ");
            //int n = int.Parse(Console.ReadLine());
            //Console.Write("m= ");
            //int m = int.Parse(Console.ReadLine());
            //int sum = 0;
            //int[,] a = new int[n, m];
            //int[] b = new int[m];
            //Random r = new Random();
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {
            //        a[i, j] = r.Next(1, 50);
            //        Console.Write(a[i, j] + "\t");
            //        sum += a[i, j];
            //    }
            //    Console.WriteLine();
            //    if (sum > 100)
            //    {
            //        for (int j = 0; j < m; j++)
            //        {
            //            b[j] = 100;
            //            Console.Write(b[j] + " ");
            //        }
            //    }
            //    sum = 0;
            //    Console.WriteLine();
            //}
            //Lab6(task1074(б))
            //Console.Write("n= ");
            //int n = int.Parse(Console.ReadLine());
            //Console.Write("m= ");
            //int m = int.Parse(Console.ReadLine());
            //int num = -1;
            //int[,] a = new int[n, m];
            //int[] b = new int[m];
            //Random r = new Random();
            //for (int j = 0; j < m; j++)
            //{
            //    for (int i = 0; i < n; i++)
            //    {
            //        a[i, j] = r.Next(1, 50);
            //        Console.WriteLine(a[i, j] + " "); 
            //        if (a[i, j] % 2 == 0)
            //        {
            //            num++;
            //        }
            //    }
            //    Console.WriteLine();
            //    if (num > -1)
            //    {
            //        for (int p = 0; p < n; p++)
            //        {
            //            b[p] = -1;
            //            Console.WriteLine(b[p] + " ");
            //        }
            //    }
            //    Console.WriteLine();
            //    num = 0;
            //}
            //Lab6(task1075)
            //const int m = 10;
            //const int n = 26;
            //int[,] a = new int[n, m];
            //Random r = new Random();
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {
            //        a[i, j] = r.Next(1, 12);
            //        Console.Write(a[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("Если хотите добавить ученике введите 1: ");
            //int p = int.Parse(Console.ReadLine());
            //Console.WriteLine("Укажите номер строки где нужно добавить нового учиника: ");
            //int f = int.Parse(Console.ReadLine());
            //if (p == 1)
            //{
            //    for (int i = 0; i < n; i++)
            //    {
            //        for (int j = 0; j < m; j++)
            //        {
            //            if (i != f-1)
            //            {
            //                a[i, j] = r.Next(1, 12);
            //                Console.Write(a[i, j] + "\t");
            //            }
            //            else {
            //                a[i, j] = int.Parse(Console.ReadLine());
            //                Console.Write(a[i, j] + "\t");
            //            }
            //        }
            //        Console.WriteLine();
            //    }
            //}
            //Lab6(task1076)
            //    const int m = 5;
            //    const int n = 3;
            //    int[,] a = new int[n, m];
            //    Random r = new Random();
            //    for (int i = 0; i < n; i++)
            //    {
            //        for (int j = 0; j < m; j++)
            //        {
            //            a[i, j] = r.Next(1, 12);
            //            Console.Write(a[i, j] + " ");
            //        }
            //        Console.WriteLine();
            //    }
            //    Console.WriteLine("Если хотите добавить предмет введите 1: ");
            //    int p = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Укажите номер столбца где нужно добавить новый предмет: ");
            //    int f = int.Parse(Console.ReadLine());
            //    Console.WriteLine();
            //    if (p == 1)
            //    {
            //        for (int j = 0; j < m; j++)
            //        {
            //            for (int i = 0; i < n; i++)
            //            {
            //                if (j == f-1)
            //                {
            //                    a[i, j] = int.Parse(Console.ReadLine());
            //                }
            //                else
            //                {
            //                    Console.WriteLine(a[i, j] + "\t"); 
            //                }
            //            }
            //            Console.WriteLine();
            //        }
            //    }
        }
    }
}
