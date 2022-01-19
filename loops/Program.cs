using System;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {
            TryAnIf();
            TrySomeLoops();
            TryAnIfElse();
        }

        private static void TryAnIf()
        {
            // int and string does not match your if statement.
            // someValue is set to 4 and name is Bobbo Jr.
            // in your if statement someValue equals 3 and
            // name is equal to Joe. The Console will print
            // "this line runs no matter what"
            int someValue = 4;
            string name = "Bobbo Jr.";

            if((someValue == 3) && (name == "Joe"))
            {
                Console.WriteLine("x is 3 and the name is Joe");
            }
            Console.WriteLine("this line runs no matter what");
        }

        private static void TrySomeLoops()
        {
            // Your int is set to 5, in the if statement it says
            // x is equal to 10 and x is not equal to 10. This
            // is going to print your else statement wich says
            // "x isn`t 10.
            int x = 5;

            if(x == 10)
            {
                Console.WriteLine("x must be 10");
            }
            else
            {
                Console.WriteLine("x isn`t 10");
            }

        }

        private static void TryAnIfElse()
        {
            // Your int count is set to 0, in this loop your while 
            // statement says that while 0 is less than 10 perform
            // what is in the curly braces. Once the action is performed
            // your answer is now 0 + 1 = 1 then in the if statement
            // it says that i is 0, i is less than 5 and i plus 1
            // after that statement is actioned your answer is now
            // going to be 5 + 1 = 6 then it runs the curly braces
            // so count = 6 - 1 = 5 to then print " the answer is 5"
            int count = 0;

            while (count < 10)
            {
                count = count + 1;
            }
            for(int i = 0; i < 5; i++)
            {
                count = count - 1;
            }
            Console.WriteLine("The answer is " + count);
        }
    }
}
