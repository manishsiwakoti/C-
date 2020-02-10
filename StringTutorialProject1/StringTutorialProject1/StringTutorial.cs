using System;
using System.Collections.Generic;
using System.Text;

namespace StringTutorialProject1
    {
    class StringTutorial
        {

        public string Firstname;
        public string Lastname;


        public StringTutorial() {

            Firstname = "Manish";
            Lastname = "Siwakoti";

            }

        public StringTutorial(String firstname, string lastname)  {
            Firstname = firstname;
            Lastname = lastname;

            }

        public string Fullname()
            {
            //var Firstname = "Manish";
            //var Lastname = "Siwakoti";

            // var Fullname = Firstname +" "+ Lastname;
            var Fullname = $"{Lastname} {Firstname}";
            return Fullname;

         }

        public string Fullname2() 
            
         {

                //var Firstname = "Manish";
                //var Lastname = "Siwakoti";

                var Fullname = $"{Firstname} {Lastname}";
                return Fullname;    




         }
            

     }
 }
    
