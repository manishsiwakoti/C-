using System;

namespace HelloWorldProject
    {
    class Program
        {
        static void Main(string[] args)
            {
            var s1 = new Student();
            s1.Name = "Fred";
            s1.FavoriteColor = "Blue";
            s1.FavoriteNumber = 88;
            s1.ToConsole();

            var s2 = new Student();
            s2.Name = "Betty";
            s2.FavoriteColor = "Green";
            s2.FavoriteNumber = 27;
            s2.ToConsole();

            Console.WriteLine("This is my Hello World, c# program!");
            Console.WriteLine("This is another line");

            var counter = 1;
           // counter = "123";
            var name = "Greg";
            name = "123";

            if (counter == 0) {

                Console.WriteLine("Counter is zero");

                } else
                {
                Console.WriteLine("Counter is not zero");
                }

            counter = counter + 1;
            Console.WriteLine("count value is " + counter);

            counter += 1;
            Console.WriteLine("Count value is {0}", counter);

            counter++;
            Console.WriteLine($"Count value is {counter}");

            // add 1-25 practice (for loope)
            var sum = 0;
            for (var Index = 0; Index <= 1000; Index++) {
                sum += Index;
                }

            Console.WriteLine($"Sum is {sum}");

            } 

        }
    }
