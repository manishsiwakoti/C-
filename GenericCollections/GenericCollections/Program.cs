using System;
using System.Collections.Generic;

namespace GenericCollections
    {
    class Program
        {
        static void Main(string[] args)
            {
            var ints = new List<int>();
            ints.Add(1);
            ints.Add(2);
            ints.Add(3);
            Console.WriteLine($"Number of ints is {ints.Count}");
            foreach (var anInt in ints)
                {
                Console.WriteLine($"{anInt}");
                }

            ints.Remove(2);
            Console.WriteLine($"Number of ints is {ints.Count}");
            foreach (var anInt in ints)
                {
                Console.WriteLine($"{anInt}");
                }

            var Name = new List<string>(12);
            Name.Add("Manish");
            Name.Add("Vaugh");
            Name.Add("Traci");
            Name.Add("Danae");
            Name.Add("Parker");
            Name.Add("Georger");
            Name.Add("Ian");
            Name.Add("Pratica");
            Name.Add("Sarah");
            Name.Add("Abc");
            Name.Add("Xyz");


            foreach (var Student in Name)
                {
                Console.WriteLine($"{Student}");
                }

            // Generic aray of strings

            var customers = new List<Customer>();
            var amazon = new Customer(1, "Amazon", true);
            var pg = new Customer(2, "P&G", true);
            var meijer = new Customer { Id = 3, Name = "Meijer", Active = true };
            var target = new Customer { Id = 4, Name = "Target", Active = true };
            var microsoft = new Customer { Id = 5, Name = "Microsoft", Active = false };

            customers.Add(amazon);
            customers.Add(pg);
            var custArray = new Customer[] { meijer, target, microsoft };
            customers.AddRange(custArray);


                         // if (Customer.Active == true)
                        //   {
                    //Console.WriteLine($"{Customer.Id}, {Customer.Name}, {Customer.Active}");
                   // }

                  // if (Customer.Active == false)
                // {
                 //    continue;
                // }
               //   Console.WriteLine($"{Customer.Id}, {Customer.Name},{Customer.Active}");
              //   }
        
            var customerDictionary = new Dictionary<int, Customer>();
            customerDictionary.Add(amazon.Id, amazon);
            customerDictionary.Add(target.Id, target);
            customerDictionary.Add(pg.Id, pg);
            customerDictionary.Add(meijer.Id, meijer);
            customerDictionary.Add(microsoft.Id, microsoft);

            var customer2 = customerDictionary[3];
            Console.WriteLine($"Customer Id 3 is {customer2.Name}");

            var customer1 = customerDictionary[2];
            Console.WriteLine($"Customer Id 2 is {customer1.Name}");

            foreach(var key in customerDictionary.Keys)
                {
                var customer = customerDictionary[key];
                Console.WriteLine($"{customer.Name}");
                }
            
            }
        }
    }
