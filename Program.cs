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
            int combos = GetValidInt("How many loot combinations would you like out of 3?");


            List<string> weapons = new List<string>();
            weapons.Add("sword");
            weapons.Add("Mace");
            weapons.Add("Pistol");
            weapons.Add("bow");
            weapons.Add("dagger");
            weapons.Add("rifle");
            weapons.Add("revolver");

            // 2. Create an Elements List 
            List<string> elements = new List<string>();
            elements.Add("fire");
            elements.Add("water");
            elements.Add("lightning");
            elements.Add("dark");
            elements.Add("light");
            elements.Add("earth");

            List<string> powers = new List<string>();
            powers.Add("magic");
            powers.Add("chakra");
            powers.Add("nen");
            powers.Add("chi");

            // 3. Create a Powers List
            // 4. Call GenerateRandomLoot with the proper arguments
            while (combos > 0)
            {

                string loot = GenerateRandomLoot(weapons, elements, powers);
                Console.WriteLine($"You got {loot}");
                combos = combos - 1;
            }
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

        
        
            /// <summary>
            /// given a method prompt to show the user, this method reads user input and checks if the input is an integer and if it falls between one and three. If it is than the method returns the user's choice
            /// If the user does not input an integer then the program recognizes an error and prompts the user to try again.
            /// If the user inputs an integer but it does not fall between 1 and 3 then the program recognizes an error and prompts the user to try again.
            /// </summary>
            /// <param name="prompt"></param>
            /// This method prompts the user to select a number between one and three and then returns the users choice

        public static int GetValidInt(string prompt)
        {

            // 1. Validate the prompt is a string
            // 2. Display the prompt
            // 3. read input from the user 
            // 4. If the user entered an invalid weapon, power, or element type,
            // - display an error message
            //  - go to step 2
            // 5. Otherwise, return the users input

            // TODO(jcollard 2022-02-12): This should go above the method signature (rather than inside the method)
            /// <summary>
            /// given a method prompt to show the user, this method reads user input and checks if the input is an integer and if it falls between one and three. If it is than the method returns the user's choice
            /// If the user does not input an integer then the program recognizes an error and prompts the user to try again.
            /// If the user inputs an integer but it does not fall between 1 and 3 then the program recognizes an error and prompts the user to try again.
            /// </summary>
            /// <param name="prompt"></param>
            /// This method prompts the user to select a number between one and three and then returns the users choice
            
            // TODO(jcollard 2022-02-12): This looks great. However, to meet the requirements for proficient you need to validate
            // the parameter input (prompt). Something like this:

            if (prompt == null)
            {
                // TODO: throw an exception
            }

            int userChoice;

            do
            {

                Console.Write(prompt);

                string input = Console.ReadLine();

                bool isANumber = int.TryParse(input, out userChoice);

                if (isANumber == false)
                {
                    Console.Error.WriteLine("you did not enter a number");
                }
            
                else if (userChoice >= 4) //TODO(jcollard 2022-02-11): What if the user selects 0? or -5?
                {
                    Console.Error.WriteLine("That is not a number 1-3");
                }

                else if (userChoice < 0)
                {
                    Console.Error.WriteLine("That is not a number 1-3");
                }
            }
            while (userChoice >= 4 || userChoice < 0); //TODO(jcollard 2022-02-11): Are you sure you should keep looping if the user selected a number less than 4?

            return userChoice;

        }
        //TODO(jcollard: 2022-01-28): You should add a method stub for each of your methods. Here is an example:

        /// <summary>
        /// Given a prompt to show the user, displays the prompt then reads input from the keyboard until the user enters a valid type. If the user enters an invalid type, this method displays an error message and prompts the user to try again.
        /// </summary>
        /// <param name="prompt">The message to display to the user</param>
        /// <returns>TODO: The valid categories the user chose</returns>
        public static string GenerateRandomLoot(List<string> weapons, List<string> elements, List<string> powers)
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

            /// <summary>
            /// This method takes in a number from the user and generates random loot from the list in the main method. 
            /// </summary>
            /// <returns></returns>
            /// 

            Random generator = new Random();
            int index = generator.Next(0, weapons.Count);

            string randomWeapons = weapons[index];
            // Console.WriteLine($"You got a {randomWeapons}");

            int index2 = generator.Next(0, elements.Count);

            string randomElements = elements[index2];
            // Console.WriteLine($"You got {randomElements}");

            int index3 = generator.Next(0, powers.Count);

            string randomPowers =powers[index3];
            // Console.WriteLine($"You got {randomPowers}");
            
            return $"{randomWeapons} {randomElements} {randomPowers}";
        }
    }
}
