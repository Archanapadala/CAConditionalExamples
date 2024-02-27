namespace CAConditionalExamples
{
    internal class homework1
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];

            Console.WriteLine("Enter 5 numbers:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Number {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            int highest = numbers[0];
            int lowest = numbers[0];

            for (int i = 1; i < 5; i++)
            {
                if (numbers[i] > highest)
                    highest = numbers[i];

                if (numbers[i] < lowest)
                    lowest = numbers[i];
            }


            Console.WriteLine($"Highest Number is: {highest}");
            Console.WriteLine($"Lowest Number is: {lowest}");
        }
    }
}
        