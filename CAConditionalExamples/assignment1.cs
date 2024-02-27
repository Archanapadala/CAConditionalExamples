namespace CAConditionalExamples
{
    internal class assignment1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ënter any number");
            int number = int.Parse(Console.ReadLine());
            int originalNumber = number;
            int numDigits = 0;
            while (originalNumber != 0)
            {
                numDigits++;
                originalNumber /= 10;
            }

            int sum = 0;
            originalNumber = number;
            // Calculate sum of each digit raised to the power of the number of digits
            while (originalNumber != 0)
            {
                int digit = originalNumber % 10;
                sum += (int)Math.Pow(digit, numDigits);
                originalNumber /= 10;
            }

            // Check if the number is Armstrong
            if (sum == number)
            {
                Console.WriteLine($"{number} is an Armstrong number.");
            }
        }
    }
}
