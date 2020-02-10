using System;

namespace EdApp
    {
    class Program
        {
        static void Main(string[] args)
            { 
            var majors = new Major[] {
            new Major(100, "Accounting", 1000),
            new Major(200, "Business", 1000),
            new Major(300, "Engineering", 1200),
            new Major(400, "Math", 1300),
            new Major(500, "Education", 1100)

                };
            // Arrays 
            
            //majors[0] = accounting;
            //majors[1] = business;
            //majors[2] = engineering;
            //majors[3] = math;

           for(var idx =0; idx < majors.Length; idx++)
                {
               var major = majors[idx];
               major.Print();


                }


            var Students = new Student[]
                {

                     new Student(1, "Chris", "List", 1250, 3.2, majors[0]),
                     new Student(2, "Kim", "Kessling", 1175, 3.4, majors[2]),
                     new Student(3, "Tracy", "Tusky", 1350, 3.5, majors[1]),
                     new Student(4, "Fred", "Flinstone", 600, 1.0, majors[1])
                    };

                // foreach statement---  foreach(var student in students(arrays)) {

            foreach(var student in Students)
                {
                student.Print();
                }



           // accounting.Print();
           // business.Print();
           //engineering.Print();

             
                
                
              //  chris.Print();
                //kim.Print();
               // tracy.Print();
               //  fred.Print();
                
            }
        }
    }
