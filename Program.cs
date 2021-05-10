using System;

namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Print numbers 1 to n");
            Console.WriteLine("Enter a whole number from 1 to 300");


            int n = int.Parse (Console.ReadLine());
            int counter = 1;

            while (counter <= n)
            {
                Console.WriteLine(counter);
                counter++;
            }
            Console.WriteLine("Print numbers n2 to 1");
            Console.WriteLine("Enter a whole number from 2 to 300");

            int n2 = int.Parse(Console.ReadLine());
            int counter2 = n2;

            while (counter2 >= 1)
            {
                Console.WriteLine(counter2);
                counter2--;
            }

            Console.WriteLine("alphabet");
            char c = 'a';
            while (c <= 'z')
            {
                Console.Write(c + " ");
                c++;
            }

            Console.WriteLine("even numbers");
            int counter3 = 2;

            while (counter3 <= 100)
            {
                Console.WriteLine(counter3);
                counter3 = counter3 + 2;
            }

            Console.WriteLine("odd numbers");
            int counter4 = 1;

            while (counter4 <= 100)
            {
                Console.WriteLine(counter4);
                counter4 = counter4 + 2;
            }
            Console.WriteLine("Print the sum of numbers 1 to n");
            Console.WriteLine("Enter a whole number from 1 to 300");


            int input = int.Parse(Console.ReadLine());
            int sum = 0;
            int counter5 = 1;

            while (counter5 <= input)
            {
                sum = sum + counter5;
                counter5++;
            }
            Console.WriteLine(sum);

            Console.WriteLine("Print the multiplication table");
            Console.WriteLine("Enter a whole number from 1 to 12");

            int input2 = int.Parse(Console.ReadLine());
            int counter6 = 1;
            while (counter6 <= input2)
            {
                int total = input2 * counter6;
                Console.WriteLine(input2 + "*" + counter6 + "=" + total);
                counter6++;
            }

            Console.WriteLine("Press enter to exit");
            Console.ReadLine();

        
    }

    }
}
