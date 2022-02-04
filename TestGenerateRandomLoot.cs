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
            elements.Add("Haki"); // TODO(jcollard 2022-02-04): This should be powers.Add
            // elements.Add("Chakra");
            // elements.Add("Magic");
            string result = Program.GenerateRandomLoot("sword", elements, powers); 
            // int result = Program.GenerateRandomLoot("what type of weapon do you want?");

            if (!result.StartsWith("sword fire Haki"))
            {
                Console.Error.WriteLine($"The result was expected to be {elements[0]}, {powers[0]}, sword");
                return false;
            }

            // TODO(jcollard 2022-02-04): This first test looks good. Next add three more tests:

            // 1. A test where your elements list has 1 item and powers has multiple items.
            // Then test that:
            result.StartsWith("bow fire");

            // 2. A test where your powers list has 1 item and your elements list has multiple items.
            // Then test that:
            result.EndsWith("Haki");

            // 3. A test where you pass in a list that has 0 elements. What should happen in this case?

            return true;
        }
    }
}