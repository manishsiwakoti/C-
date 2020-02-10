using System;

namespace StringTutorialProject1
    {
    class Program
        {
        static void Main(string[] args)
            {
            var st1 = new StringTutorial();
           var Fullname = st1.Fullname();
            Console.WriteLine($"Fullname is {Fullname}");

            Console.WriteLine($"Fullname2 is {st1.Fullname2()}");

            var denise = new StringTutorial("Denise", "Bartick");

             Console.WriteLine($"Denise {denise.Fullname()}");
            Console.WriteLine($"Denise {denise.Fullname2()}");
            }
        }
    }
