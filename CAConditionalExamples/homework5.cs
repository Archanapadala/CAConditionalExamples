namespace CAConditionalExamples
{
    internal class homework5
    {
        static bool IsPrime(int num)
        {
            if (num <= 1)
                return false;
            if (num == 2)
                return true;
            if (num % 2 == 0)
                return false;

            // Check for divisibility by odd numbers from 3 to the square root of the number
            for (int i = 3; i <= Math.Sqrt(num); i += 2)
            {
                if (num % i == 0)
                    return false;
            }

            return true;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter Start Number:");
            int start = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter End Number:");
            int end = int.Parse(Console.ReadLine());

            Console.WriteLine("Prime numbers between {0} and {1} are:", start, end);

            // Using while loop
            int current = start;
            while (current <= end)
            {
                if (IsPrime(current))
                    Console.Write($"{current} ");

                current++;
            }

            Console.WriteLine();

            // Using for loop
            for (int i = start; i <= end; i++)
            {
                if (IsPrime(i))
                    Console.Write($"{i} ");
            }

            Console.WriteLine();
        }
    }
}
