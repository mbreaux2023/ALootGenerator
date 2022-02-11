using System;
using System.Collections.Generic;

namespace ALootGenerator
{
    
    class TestGenerateRandomLoot
    {

        public static bool RunTest()
        {
            List<string> weapons = new List<string>();
            weapons.Add("sword");

            List<string> elements = new List<string>();
            elements.Add("fire");
            // elements.Add("water");
            // elements.Add("lightning");
            List<string> powers = new List<string>();
            powers.Add("Haki"); // TODO(jcollard 2022-02-04): This should be powers.Add
            // elements.Add("Chakra");
            // elements.Add("Magic");
            string result = Program.GenerateRandomLoot(weapons, elements, powers); 
            // int result = Program.GenerateRandomLoot("what type of weapon do you want?");

            if (!result.StartsWith("fire Haki sword "))
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

            // TODO (jcollard 2022-02-05): Are you sure this is the correct output?
            // Look at all 3 cases you wrote, what pattern do you see? Do the patterns make sense with the
            // output?

            string result2 = Program.GenerateRandomLoot("fire", weapons, powers);

            if (!result2.StartsWith("fire haki sword"))
            {
                Console.Error.WriteLine($"the result was expected to be fire {powers[0]}, {weapons}");
                return false;
            }

            // TODO (jcollard 2022-02-05): Are you sure this is the correct output?
            // Look at all 3 cases you wrote, what pattern do you see? Do the patterns make sense with the
            // output?

            string result3 = Program.GenerateRandomLoot("haki", elements, weapons);
            if (!result3.StartsWith("fire haki sword"))
            {
                Console.Error.WriteLine($"the result was expected to be haki {powers[0]}, {weapons}");
                return false; 
            }
            
            return true;
        }
    }
}