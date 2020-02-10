using System;

namespace Arrays
    {
    class Program
        {
        static void Main(string[] args)
            { 

            var numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            var total = 0;
            foreach (var idx in numbers)
                {
                if ((idx % 3 == 0) || (idx % 5 == 0))
                    {
                    continue;
                    }
                total += idx * 3;
                }


            Console.WriteLine($"answer is {total}");




                {





                }




            //var randomNumbers = new int[5];




            //randomNumbers[0] = 123;
            //randomNumbers[1] = 456;
            //randomNumbers[2] = 789;
            //randomNumbers[3] = 1;
            //randomNumbers[4] = 0;

            //var sum = randomNumbers[0] + randomNumbers[1] + randomNumbers[2];


            }
        }
    }
