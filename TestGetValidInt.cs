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

            Console.WriteLine("the Method should display 'How many options would you like?'");
            Console.WriteLine("type 'banana'. You should see 'invalid!'");
            Console.WriteLine("then type '-12'. You should see invalid.");

            result = Program.GetValidInt("How old are you?");

            if (result != 4)
            {
                Console.Error.WriteLine($"The result was expeected to be 4 but was {result}.");
                return false;
            }

            Console.WriteLine("The method should display 'how many options would like?'");
            Console.WriteLine("type 'apple'. You should see 'invalid'");
            Console.WriteLine("then type '-9'. You should see invalid.");

            int result2 = Program.GetValidInt("what is your favorite color");

            if (result2 !=2)
            {
                Console.Error.WriteLine($"The result expected to be 2 but was {result2}.");
                return false;
            }

            Console.WriteLine("the method should display 'how many optiona would you like?'");
            Console.WriteLine("type 'orange'. You should see 'invalid.'");
            Console.WriteLine("then type '5'. You should see 'valid'");

            int result3 = Program.GetValidInt("How many weapons do you want.");

            if (result3 != 5)
            {
                Console.Error.WriteLine($"THe result was expected to be 5 but was {result3}.");
                return false;
            }

            if (result3 == 5)
            {
                Console.WriteLine($"The result was {result3}.");
            }

            return true;
        }

    }
    
}