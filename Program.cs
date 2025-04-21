using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Ex1REDO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            double grade;

            //asks user to input their grade
            Console.WriteLine("Input grade to the nearest tenth of decimal");
            grade = Convert.ToDouble(Console.ReadLine());

            //function to create switch statement
            int grade10 = (int)Math.Round(grade) / 10;

            //processing switch statement
            switch (grade10)
            {
                case 10:
                case 9:
                    Console.WriteLine("Your grade is an A");
                    break;
                case 8:
                    Console.WriteLine("Your grade is a B");
                    break;
                case 7:
                    Console.WriteLine("Your grade is a C");
                    break;
                case 6:
                    Console.WriteLine("Your grade is a D");
                    break;
                case 5:
                    Console.WriteLine("Your grade is a F");
                    break;
                default:
                    Console.WriteLine("Your grade is a F");
                    break;
            }
            Console.Read();



        }
    }
}
