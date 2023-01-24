﻿/* 
 Author: Enzo Tafarello Negrao
Date: 1/24/23
Description: C# console application for calculating letter grade
*/

using System;

namespace Deliverable2_ConditionalStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a numeric grade: ");
            
            try
            {
                decimal grade = decimal.Parse(Console.ReadLine());

                if (grade >= 90)
                {
                    Console.WriteLine("Your letter grade for ISM 4300 is A");
                }

                else if (grade >= 80 && grade < 90)
                {
                    Console.WriteLine("Your letter grade for ISM 4300 is B");
                }

                else if (grade >= 70 && grade < 80)
                {
                    Console.WriteLine("Your letter grade for ISM 4300 is C");
                }

                else if (grade >= 60 && grade < 70)
                {
                    Console.WriteLine("Your letter grade for ISM 4300 is D");
                }

                else if (grade >= 0 && grade < 60)
                {
                    Console.WriteLine("Your letter grade for ISM 4300 is F");
                }
            }


            catch
            {
                Console.WriteLine("Enter a numeric value");
            }
        }
    }
}
