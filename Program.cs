using System;
using System.Collections.Generic;

namespace ALootGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Checks if the user added a command line argument
            // Also checks if the first argument is "test"
            if (args.Length > 0 && args [0] == "test")
            {
                TestAll();
                return; // exits the program
            }

            // other wise, the program continues executing
        }


        public static void TestAll()
        {
            bool testGetValidInt = TestGetValidInt.RunTest();
            Console.WriteLine($"Test GetValidInt(filename): {testGetValidInt}");
            
            bool testGenerateRandomLoot = TestGenerateRandomLoot.RunTest();
            Console.WriteLine($"Test GenerateRandomLoot(options): {testGenerateRandomLoot}");
        }
        public static int GetValidInt(string prompt)
        {
            // 1. Validate the prompt is a string
            // 2. Display the prompt
            // 3. read input from the user 
            // 4. If the user entered an invalid weapon, power, or element type,
            // - display an error message
            //  - go to step 2
            // 5. Otherwise, return the users input
            return -1;
        }
        //TODO(jcollard: 2022-01-28): You should add a method stub for each of your methods. Here is an example:

        /// <summary>
        /// Given a prompt to show the user, displays the prompt then reads input from the keyboard until the user enters a valid type. If the user enters an invalid type, this method displays an error message and prompts the user to try again.
        /// </summary>
        /// <param name="prompt">The message to display to the user</param>
        /// <returns>TODO: The valid categories the user chose</returns>
        public static string GenerateRandomLoot(string weapon, List<string> elements, List<string> powers)
        {
            // 1. Create a random number generator
// 2. Generate a random number, first index, between 0 and weapons.Count
// 3. Generate a random number, midIndex, between 0 and powers.count
// 4. Generate a random number, lastIndex, between 0 and elements.count
// 5. Combine the weapon, power, and element together
//     - weapons[firstIndex] + " " + power[midIndex] + " " + element[lastIndex];
// 6. Return the loot
            return null;
        }
    }
}
