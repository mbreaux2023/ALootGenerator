using System;

namespace ALootGenerator
{
    class TestGetValidInt
    {
        public static bool RunTest()
        {
            Console.WriteLine("the method should display 'How many options would you like?'");
            Console.WriteLine("type '-'. You should see 'invalid!'");
            Console.WriteLine("Then type '-4'. You should see 'invalid!'");
            
            // TODO(jcollard 2022-02-04): Instruct the user to enter '3'. 
            int result = Program.GetValidInt("how many options would you like");
            
            if (result != 3)
            {
                Console.Error.WriteLine($"The result was expected to be 3 but was {result}.");
                return false;
            }

            // TODO(jcollard 2022-02-04): A great first test. Now test another input.
            // What should happen in this situation:
            // * Test 2 more invalid inputs
            // * Test 1 more valid input.

            result = Program.GetValidInt("How old are you?");

            Console.WriteLine("the Method should display 'How many options would you like?'");
            Console.WriteLine("type 'banana'. You should see 'invalid!'");
            Console.WriteLine("then type '-12'. You should see invalid.");

            return true;
        }

    }
    
}