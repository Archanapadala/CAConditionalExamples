using System.Numerics;

namespace CAConditionalExamples
{
    class example5
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Enter two numbers");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            Operator:
            Console.WriteLine("Enter operator");
            char op = Convert.ToChar(Console.ReadLine());
            int res = 0;
            switch (op) 
            {
                case '+':
                    res = num1 + num2;
                    break;
                case '-':
            res = num1 - num2;
            break;
            case '*':
            res = num1 * num2;
            break;
            case '/':
            res = num1 / num2;
            break;
                    default:
                    Console.WriteLine("Operator Invalid");
                    goto Operator;
            }
            Console.WriteLine("Result is:" + res);
        }
    }
}
