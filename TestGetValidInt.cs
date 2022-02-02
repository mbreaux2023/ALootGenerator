using System;

namespace ALootGenerator
{
    class TestGetValidInt
    {
        public static bool RunTest()
        {
            // TODO(jcollard 2022-02-02): To get rid of these errors
            // you need to add the line `using System.Collections.Generic;`
            // to the top of your program. This imports the library that allows lists to be used.

            // That said, I don't think you need to put this in your test. This is an implementaiton
            // detail. What are you trying to test?
            List<string> options = new List<string>();
            options.Add("melee");
            options.Add("weapon");
            options.Add("projectile");

            // TODO(jcollard 2022-02-02): Make a call to the method ValidateInput:
            // Program.GetValidInt("Some String Here");
            // What should the user see when this method is called?
            // What inputs should the user test? Give the tester instructions on how they
            // should test the method. e.g. "Enter 'a'. This should result in an invalid message."
            // "Then, enter -2. This should result in an invalid message."
            // "Finally, enter a valid option 4. This should result in the method returning the int value 4."

            Console.WriteLine("Testing GetValidInt with the string 'How many items to generate?'");
            Console.WriteLine("You should expect to see ?????");
            Console.WriteLine("Type a. This should result in ????.");
            Console.WriteLine("Type -5. This should result in ????.");
            Console.WriteLine("Type 3. This should result in ????.");
            int result = Program.GetValidInt("How many items to generate?");

            if (result != ???) // Check that the result is the expected value. If it is NOT the expected value
            {
                Console.Error.WriteLine($"Failed: Expected the result to be ???? but was {result}.");
                return false;
            }

            return true;
        }

    }
    
}