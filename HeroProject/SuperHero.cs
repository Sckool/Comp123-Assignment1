using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroProject
{
    class SuperHero
    {
        public SuperHero()
        {
           
        }
        private string[] originalArray = { "Super Speed", "Super Strength", "Body Armour", "Flight", "Fire Generation", "Weather Control" };
        private string[] finalArray = new string[3]; // constructor Notation
        
        private void generateRandomPowers()
        {
             // Literal Notation or Array Initializer 

            string[] tempArray = new string[originalArray.Length];


            

            Random rnd = new Random();

            int randomElement;


            // Copy each element of the originalArray to tempArray
            for (int element = 0; element < originalArray.Length; element++)
            {
                tempArray[element] = originalArray[element];
            }



            // Assign cells from one array to another

            int index = 0;

            while (index < finalArray.Length)
            {
                randomElement = generateRandomElement(rnd, originalArray.Length); // Generate random number

                if (tempArray[randomElement] != "unavailable")
                {
                    finalArray[index] = tempArray[randomElement];

                    tempArray[randomElement] = "unavailable";

                    index++;
                }


            }



            /* Alternate Looping Structure
            for (int index = 0; index < finalArray.Length; index++)
            {
                
                randomElement = generateRandomElement(rnd);
                if (originalArray[randomElement] != "unavailable")
                {
                    finalArray[index] = originalArray[randomElement];
                    originalArray[randomElement] = "unavailable";
                } 
            }
             */



            /* Alternate way to declare and initialize an array
            string[] originalArray = new string[6];
            originalArray[0] = "Honda";
            originalArray[1] = "BMW";
            originalArray[2] = "Mercedes";
            originalArray[3] = "Jeep";
            originalArray[4] = "Ford";
            originalArray[5] = "Jaguar";
            */
        }
            public void showPowers()
            {
            Console.WriteLine("++++++++++++++++++++++++++++++");
            Console.WriteLine("+  Original SuperPower  List +");
            Console.WriteLine("++++++++++++++++++++++++");

            // Output the value of the each cell in each array
            for (int index = 0; index < this.originalArray.Length; index++)
            {
                Console.WriteLine(originalArray[index]);
            }

            Console.WriteLine("+++++++++++++++++++++++++++++");
            Console.WriteLine("+     New SuperPower  List  +");
            Console.WriteLine("+++++++++++++++++++++++++++++");

            for (int index = 0; index < finalArray.Length; index++)
            {

                Console.WriteLine(finalArray[index]);
            }
            Console.WriteLine();
            Console.WriteLine("+++++++++++++++++++++++++");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();



        }

        private static int generateRandomElement(Random rnd, int max)
        {
            int number;
            number = rnd.Next(max);
            //Console.WriteLine("My Random car is {0}", number); // Debugging line
            return number;
        }

    }

}


