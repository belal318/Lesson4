﻿////===============================================Question1=======================================================
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int i;
//            int fact = 1;
//            Console.WriteLine("enter a number");
//            int num = int.Parse(Console.ReadLine());
//            for (i = 2; i <= num; i++)
//            {
//                fact *= i;
//            }
//            Console.WriteLine("the sum is :" + fact);
//        }
//    }
//}

////===============================================Question2=======================================================
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int i;
//            Console.WriteLine("enter a number");
//            int max = int.Parse(Console.ReadLine());
//            for (i = 1; i <= max; i++)
//            {
//                if (i % 7 == 0)
//                {
//                    Console.WriteLine("BOOM");
//                    continue;
//                }
//                else
//                    Console.WriteLine(i);
//            }

//        }
//    }
//}


////===============================================Question3=======================================================
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int i;
//            int sum = 0;
//            int counter = 0;
//            Console.Write("enter a number : ");
//            string input = Console.ReadLine();
//            for (; input!="done";counter++)
//            {
//                int num = int.Parse(input);
//                sum += num;
//                Console.Write("enter a number : ");
//                input = Console.ReadLine();
//            }
//            Console.WriteLine("the avarage of the numbers is :" + sum/(counter*1.0));


//        }
//    }
//}

////===============================================Question4=======================================================
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.Write("Enter A Number :.. ");
            int num = int.Parse(Console.ReadLine());
            bool isPrime = true;
            for (i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                Console.WriteLine($"{num} is prime !");
            }
            else
            {
                Console.WriteLine($"{num} is not prime !");
            }

        }
    }
}



