using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FisrtgithubProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Github!");
            /* first max min funksion*/
            int firstnumber, secondnumber,third;
            firstnumber = Convert.ToInt32(Console.ReadLine());
            secondnumber = Convert.ToInt32(Console.ReadLine());
            third = Convert.ToInt32(Console.ReadLine());
            Maxnumber(firstnumber, secondnumber);
            Max3(firstnumber, secondnumber, third);
         


        }
        public static void Maxnumber(int number_1,int number_2)
        {
           
            string M ="";
            M = (number_1 > number_2) ?
                "Max firstnumber,Min secondnumber" :
                (number_1 < number_2) ?
                "Max second number,Min first Number" : 
                (number_1 == number_2) ?
                "firstnumber equal to second number" : M;
            Console.WriteLine(M);
        }
        public static void Minnumber(int number_1, int number_2)
        {

            string M = "";
            M = (number_1 < number_2) ?
                "Min firstnumber,Max secondnumber" :
                (number_1 > number_2) ?
                "Min second number,Max first Number" :
                (number_1 == number_2) ?
                "firstnumber equal to second number" : M;
            Console.WriteLine(M);
        }
        public static void Max3(int number_1, int number_2,int third)
        {
            
            string M = "";
            M = (number_1 > number_2&&number_1>third) ?
                "Max firstnumber" :
                (number_1 < number_2&&number_2>third) ?
                "Max second number" :
                 (number_1 < number_2 && number_2 < third) ?
                "Max third number" :
                (number_1 == number_2&&number_2==third) ?
                "firstnumber equal to second number equal to third number" :
                M;
            Console.WriteLine(M);
        }
        public static void MaxnumberArray(int[]a)
        {
            int n, max = a[0];
            n = a.Length;
            for (int i = 0; i < n; i++)
            {
                if (max < a[i])
                {
                    max = a[i];
                }
            }
                Console.WriteLine(max);
            
        }
        public static void MinnumberArray(int[] a)
        {
            int n, min = a[0];
            n = a.Length;
            for (int i = 0; i < n; i++)
            {
                if (min > a[i])
                {
                    min = a[i];
                }
            }
            Console.WriteLine(min);

        }

    }
}
