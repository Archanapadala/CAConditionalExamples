namespace CAConditionalExamples
{
    internal class example4
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter two numbers");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Operator");
            char op = Convert.ToChar(Console.ReadLine());
            int res = 0;
            if (op == '+')
                res = num1 + num2;
            else if (op == '-')
                res = num2 + num1;
            else if (op == '*')
                res = num1 * num2;
            else if (op == '/')
                res = num1 / num2;
            else
                Console.WriteLine("Operator Invalid");
            Console.WriteLine("Result is :" + res);
        }
    }
}
