namespace NumbersInC
{
    internal class Program
    {
        static void Main(string[] args) //svm
        {
            // HELLOW WORLD
            Console.WriteLine("Hello, World!");

            // Variable Declaration
            string aFriend = "Bill";
            Console.WriteLine(aFriend);

            aFriend = "Maira";
            Console.WriteLine(aFriend);

            aFriend = "Scott";
            Console.WriteLine("Hello " + aFriend);

            aFriend = "William";
            Console.WriteLine($"Hello {aFriend}");

            // Working with Strings

            string firstFriend = "Constance";
            string secondFriend = "Sage";
            Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");

            Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters.");
            Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters.");

            // More Strings

            string greeting = "      Hello World!       ";
            Console.WriteLine($"[{greeting}]");

            string trimmedGreeting = greeting.TrimStart();
            Console.WriteLine($"[{trimmedGreeting}]");

            trimmedGreeting = greeting.TrimEnd();
            Console.WriteLine($"[{trimmedGreeting}]");

            trimmedGreeting = greeting.Trim();
            Console.WriteLine($"[{trimmedGreeting}]");

            string sayHello = "Hello World!";
            Console.WriteLine(sayHello);
            sayHello = sayHello.Replace("Hello", "Greetings");
            Console.WriteLine(sayHello);

            Console.WriteLine(sayHello.ToUpper());
            Console.WriteLine(sayHello.ToLower());

            // Search Strings
            string songLyrics = "You say goodbye, and I say hello";
            Console.WriteLine(songLyrics.Contains("goodbye"));
            Console.WriteLine(songLyrics.Contains("greetings"));

            string songLyrics2 = "You say goodbye, and I say hello";
            Console.WriteLine(songLyrics2.StartsWith("You"));
            Console.WriteLine(songLyrics2.StartsWith("goodbye"));
            Console.WriteLine(songLyrics2.EndsWith("hello"));
            Console.WriteLine(songLyrics2.EndsWith("goodbye"));

            // Numbers
            /*
            int a = 18;
            int b = 6;
            int c = a + b;
            Console.WriteLine(c);
            */

            // Order Of Operations

            /*
            int d = 5;
            int e = 4;
            int f = 2;
            int g = d + e * f;
            Console.WriteLine(g);
            */

            // Precisions & Limit

            /*
            int a = 7;
            int b = 4;
            int c = 3;
            int d = (a + b) / c;
            int e = (a + b) % c;
            Console.WriteLine($"quotient: {d}");
            Console.WriteLine($"remainder: {e}");

            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine($"The range of integers is {min} to {max}");
            */

            // Doubles

            /*
            double a = 5;
            double b = 4;
            double c = 2;
            double d = (a + b) / c;
            Console.WriteLine(d);
            */

            double max = double.MaxValue;
            double min = double.MinValue;
            Console.WriteLine($"The range of double is {min} to {max}");

            double third = 1.0 / 3.0;
            Console.WriteLine(third);

            // Decimals

            decimal min2 = decimal.MinValue;
            decimal max2 = decimal.MaxValue;
            Console.WriteLine($"The range of the decimal type is {min2} to {max2}");

            double a2 = 1.0;
            double b2 = 3.0;
            Console.WriteLine(a2 / b2);

            decimal c2 = 1.0M;
            decimal d2 = 3.0M;
            Console.WriteLine(c2 / d2);

            int a = 5;
            int b = 6;
            if (a + b > 10)
                Console.WriteLine("The answer is greater than 10.");

        }

    }

}
