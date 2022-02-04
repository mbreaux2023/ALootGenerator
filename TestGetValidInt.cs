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
            int result = Program.GetValidInt("how many options would you like");
            //options.Add("melee");
            //options.Add("weapon");
            //options.Add("projectile");

            if (result != 3)
            {
                Console.Error.WriteLine($"The result was expected to be 3 but was {result}.");
                return false;
            }

            Console.WriteLine("the method should display what weapon would you like");
            Console.WriteLine("the method should display what element would you like");
            Console.WriteLine("the method should display what power would you like");

            return true;
        }

    }
    
}