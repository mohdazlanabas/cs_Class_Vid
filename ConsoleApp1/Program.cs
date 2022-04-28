namespace BranchesNLoops
{
    internal class Program
    {
        static void Main(string[] args) //svm
        {

            // if Statement
            int a = 5;
            int b = 3;
            int c = 4;
            if ((a + b + c > 10) || (a == b))
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("Or the first number is equal to the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("And the first number is not equal to the second");
            }

            // WHile Loop
            int counter = 0;
            while (counter < 3)
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
                counter++;
            }

            // Do Loop
            int counter2 = 0;
            do
            {
                Console.WriteLine($"Hello World! The counter is {counter2}");
                counter2++;
            } while (counter2 < 3);

            // for Loop
            for (int counter3 = 0; counter3 < 3; counter3++)
            {
                Console.WriteLine($"Hello World! The counter is {counter3}");
            }

            // for Nested Loop
            for (int row = 1; row < 4; row++)
            {
                for (char column = 'a'; column < 'd'; column++)
                {
                    Console.WriteLine($"The cell is ({row}, {column})");
                }
            }

            // for and if combined
            int sum = 0;
            for (int number = 1; number < 8; number++)
            {
                if (number % 3 == 0)
                {
                    sum = sum + number;
                }
            }
            Console.WriteLine($"The sum is {sum}");



        }

    }
}