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
            if (args.Length > 0 && args[0] == "test")
            {
                TestAll();
                return; // exits the program
            }

            // other wise, the program continues executing

            // TODO(jcollard 2022-02-11):
            // 1. Prompt the user to get their input from GetValidInt
            // 2. Create an Elements List
            // 3. Create a Powers List
            // 4. Call GenerateRandomLoot with the proper arguments
        }


        public static void TestAll()
        {
            bool testGetValidInt = TestGetValidInt.RunTest();
            Console.WriteLine($"Test GetValidInt(filename): {testGetValidInt}");

            bool testGenerateRandomLoot = TestGenerateRandomLoot.RunTest();
            Console.WriteLine($"Test GenerateRandomLoot(options): {testGenerateRandomLoot}");
        }

        // TODO(jcollard 2022-02-02): This method should probably named GenerateRandomLoot
        // What options should it accept as parameters?
        // I would suggest List<string> weapons, List<string> powers, List<string> elements
        public static int GetValidInt(string prompt)
        {

            // 1. Validate the prompt is a string
            // 2. Display the prompt
            // 3. read input from the user 
            // 4. If the user entered an invalid weapon, power, or element type,
            // - display an error message
            //  - go to step 2
            // 5. Otherwise, return the users input

            int userChoice;

            do
            {

                Console.Write("Enter a number that is ");

                string input = Console.ReadLine();

                bool isANumber = int.TryParse(input, out userChoice);

                if (isANumber == false)
                {
                    Console.Error.WriteLine("you did not enter a number");
                }
                else if (userChoice >= 4) //TODO(jcollard 2022-02-11): What if the user selects 0? or -5?
                {
                    Console.WriteLine("That is not a number 1-3");
                }
            }
            while (userChoice < 4); //TODO(jcollard 2022-02-11): Are you sure you should keep looping if the user selected a number less than 4?

            return userChoice;

        }
        //TODO(jcollard: 2022-01-28): You should add a method stub for each of your methods. Here is an example:

        /// <summary>
        /// Given a prompt to show the user, displays the prompt then reads input from the keyboard until the user enters a valid type. If the user enters an invalid type, this method displays an error message and prompts the user to try again.
        /// </summary>
        /// <param name="prompt">The message to display to the user</param>
        /// <returns>TODO: The valid categories the user chose</returns>
        public static string GenerateRandomLoot(string weapon, List<string> elements, List<string> powers)
        {
            // Feedback(jcollard 2022-02-02): This step-by-step algorithm does not seem
            // to match the description above. This method's summary suggests it should
            // be asking the user a question and then validating that they are entering
            // an integer.

            // 1. Create a random number generator
            // 2. Generate a random number, first index, between 0 and weapons.Count
            // 3. Generate a random number, midIndex, between 0 and powers.count
            // 4. Generate a random number, lastIndex, between 0 and elements.count
            // 5. Combine the weapon, power, and element together
            //     - weapons[firstIndex] + " " + power[midIndex] + " " + element[lastIndex];
            // 6. Return the loot

            // TODO(jcollard 2022-02-11): You're almost done! This method is a
            // little tricky but I've created an example that I hope will help:
            // https://jcollard.github.io/IntroToCSharpSite/examples/random-dog-generator
            return null;
        }
    }
}
