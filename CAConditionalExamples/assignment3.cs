namespace CAConditionalExamples
{
    internal class assignment3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number");
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            int tempnum=number;
            while(tempnum!=0)
            {
                int digit = tempnum % 10;
                sum += digit;
                tempnum = tempnum / 10;
            }
            Console.WriteLine("The sum of the digits is "+sum);

        }
    }
}
