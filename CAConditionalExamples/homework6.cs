namespace CAConditionalExamples
{
    internal class homework6
    {
        static bool IsPalindrome(int num)
        {
            int originalNumber = num;
            int reverseNumber = 0;

            // Reverse the number
            while (num > 0)
            {
                int digit = num % 10;
                reverseNumber = reverseNumber * 10 + digit;
                num /= 10;
            }

            // Check if the original number is equal to its reverse
            return originalNumber == reverseNumber;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number:");
            int number = int.Parse(Console.ReadLine());

            bool isPalindrome = IsPalindrome(number);

            if (isPalindrome)
                Console.WriteLine("It is palindrome");
            else
                Console.WriteLine("It is not palindrome");
        }
    }
}
