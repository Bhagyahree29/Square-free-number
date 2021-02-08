using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Square_Free_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            double sqrnum;
            long  chksqr;
            int i;
            int j=0;
           
            int count = 0, k;
           int temp ;
            

            Console.WriteLine("Enter the number");
            n = Convert.ToInt32(Console.ReadLine());
             double sqr = Math.Pow(n, 2);

             for (i = 2; i <= n / 2; i++)
             {
                 if (n % i == 0)
                 {
                     count++;
                     sqrnum = sqr(i);
                     chksqr = sqrnum;
                     if (chksqr == sqrnum)
                     {
                         count--;
                         temp[j] = i;
                         j++;
                     }
                     else
                     {
                         for (k = 0; k < j; k++)
                         {
                             if (i > temp[k] && j != 0)
                             {
                                 if (i % temp[k] == 0)
                                 {
                                     count--;
                                     k = j + 1;
                                 }
                             }
                         }
                     }

            if (n == temp)
            {
                Console.WriteLine(" Number is Square Free Number");
            }

            else
            {
                Console.WriteLine(" Number is Not Square Free Number");
            }

            Console.ReadLine();

        }

    }
       