using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        void program_1()
        {
            for (int i = 1; i < 100; i++)
            {
                if (i % 2 == 0) Console.Write(i + " ");
            }
            Console.WriteLine("");
        }
        void program_2()
        {
            bool printX = false;
            bool printO = false;
            for (int i = 0; i < 4; i++)
            {
                if (i % 2 == 0)
                {
                    printX = true;
                    printO = false;
                }
                else
                {
                    printX = false;
                    printO = true;
                }
                if (printX)
                {
                    for (int j = 0; j <= 5; j++)
                    {
                        if (j % 2 == 0) Console.Write("X");
                        else Console.Write("0");
                    }
                }
                else if (printO)
                {
                    for (int j = 0; j <= 5; j++)
                    {
                        if (j % 2 == 0) Console.Write("0");
                        else Console.Write("X");
                    }
                }
                Console.Write("\n");

            }
        }
        void program_3()
        {
            for (int i = 1; i <= 5; i++)
            {
                int start = i;
                for (int j = 0; j < 5; j++)
                {

                    Console.Write(start);
                    start++;
                }
                Console.Write("\n");
            }
        }
        void program_4()
         {
            bool odd = true;
            int sumOdd = 0;
            int sumEven = 0;
        
            for (int i = 1; i < 100; i++)
            {
                if (i % 2 == 0) odd = false;
                else odd = true;

                if (odd) sumOdd += i;
                if (!odd) sumEven += i;
            }
            Console.WriteLine("sum of Odd numbers : " + sumOdd);
            Console.WriteLine("sum of Even numbers : " + sumEven);

        }
        void program_5()
        {
            for (int i = 1; i <= 5; i++)
            {
                int start = i;
                for (int j = 1; j <= 5; j++)
                {
                    if(j==start) Console.Write(start);
                    else Console.Write(" ");

                }
                start++;
                Console.Write("\n");
            }
        }
        void program_6()
        {
            int i, fact = 1, number;
            Console.Write("Enter Number: ");
            number = int.Parse(Console.ReadLine());
            for (i = 1; i <= number; i++)
            {
                fact = fact * i;
            }
            Console.Write("Factorial of " + number + " is: " + fact +"\n");
        }
        void program_7()
        {
            for (int i = 1; i < 5; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
            for (int i = 5; i >= 0; i--)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
            Console.WriteLine();
        }
            static void Main(string[] args)
        {
            Program p = new Program();
            
            //remove the comment syntax to test the methods please

            //p.program_1();
            //p.program_2();
           // p.program_3();
           // p.program_4();
            //p.program_5();
            //p.program_6();
            //p.program_7();
        }
    }
}
