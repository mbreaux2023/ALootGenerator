using System;
using System.Collections.Generic;

namespace ALootGenerator
{
    
    class TestGenerateRandomLoot
    {

        public static bool RunTest()
        {

            List<string> elements = new List<string>();
            elements.Add("fire");
            // elements.Add("water");
            // elements.Add("lightning");
            List<string> powers = new List<string>();
            elements.Add("Haki");
            // elements.Add("Chakra");
            // elements.Add("Magic");
            string result = Program.GenerateRandomLoot("sword", elements, powers); 
            // int result = Program.GenerateRandomLoot("what type of weapon do you want?");

            if (!result.StartsWith("fire Haki sword "))
            {
                Console.Error.WriteLine($"The result was expected to be {elements}, {powers}, sword");
                return false;
            }

            return true;
        }
    }
}