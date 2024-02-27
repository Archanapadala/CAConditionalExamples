namespace CAConditionalExamples
{
    internal class assignment2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number");
            int number = Convert.ToInt32(Console.ReadLine());
            int reminder, reverse = 0;
            while (number > 0) 
            {
                 reminder = number % 10;
                reverse = (reverse*10)+reminder;
                number = number/10;
            }
            Console.WriteLine("the reverse number is "+reverse);
        }
    }
}
