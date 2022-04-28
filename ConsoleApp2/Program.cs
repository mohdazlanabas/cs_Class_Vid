﻿namespace ListCollections
{
    class Program
    {
        static void Main(string[] args) //svm
        {
            //
            var names = new List<string> { "<name>", "Ana", "Felipe" };
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            //
            Console.WriteLine();
            names.Add("Maria");
            names.Add("Bill");
            names.Remove("Ana");
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            //
            var index = names.IndexOf("Felipe");
            if (index != -1)
                Console.WriteLine($"The name {names[index]} is at index {index}");

            var notFound = names.IndexOf("Not Found");
            Console.WriteLine($"When an item is not found, IndexOf returns {notFound}");

            //

            var fibonacciNumbers = new List<int> { 1, 1 };

            var previous1 = fibonacciNumbers[fibonacciNumbers.Count - 1];
            var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

            fibonacciNumbers.Add(previous1 + previous2);

            foreach (var item in fibonacciNumbers)
                Console.WriteLine(item);

            //
            // var fibonacciNumbers = new List<int> { 1, 1 };

            while (fibonacciNumbers.Count < 20)
            {
                var previous3 = fibonacciNumbers[fibonacciNumbers.Count - 1];
                var previous4 = fibonacciNumbers[fibonacciNumbers.Count - 2];

                fibonacciNumbers.Add(previous3 + previous4);
            }
            foreach (var item in fibonacciNumbers)
                Console.WriteLine(item);



        }
    }
}