using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //int[] omas = { 1, 3, 4, 5, 6 };
            //for ( int i=omas.Length-1; i>=0;  i--)
            //{
            //    Console.WriteLine($"omas [{i}] = {omas[i]}");
            //}


            //Заполнить о.м. слуычайным образом, подсччитать кол-во отрицательных элементов

            //Console.Write("n=");
            //byte n = Convert.ToByte(Console.ReadLine());
            //int[] omas = new int[n];
            //Random random = new Random();
            //for (int i = 0; i < omas.Length; i++)
            //{
            //    omas[i] = random.Next(-10, 10);
            //    Console.WriteLine($"omas[{i}]={omas[i]}");
            //}
            //byte count = 0;
            //foreach (  int elem in omas) // через цикл foreach
            //{
            //    if (elem < 0) count++;
            //}

            ////for ( int i=0; i<omas.Length; i++) // через цикл for
            ////{
            ////    if (omas[i] < 0) count++;
            ////}
            //Console.WriteLine($"Кол-во отрицательных элементов = { count}");


            // В о.м. значение всех элементов увеличить в два раза

            int[] omas = { -5, 5, -6, 6, -7, 7 };
            for ( int i=0; i<omas.Length; i++)
            {
                omas[i] = omas[i] * 2; // omas [i] *=2;
                //Console.WriteLine($"{omas[i]}\t");
            }


            foreach (int elem in omas) //через цикл foreach 
            {
                Console.Write($"{elem}\t");
            }
        }
    }
}
