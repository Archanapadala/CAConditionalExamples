namespace CAConditionalExamples
{
    internal class homework4
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number of elements to print: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Fibonacci Numbers are:");

            
            int a = 0, b = 1, c;
            int count = 0;
            Console.Write($"{a} {b} ");
            while (count < n - 2)
            {
                c = a + b;
                Console.Write($"{c} ");
                a = b;
                b = c;
                count++;
            }

           
            int previous = 0, current = 1;
            Console.Write($"{previous} {current} ");
            for (int i = 2; i < n; i++)
            {
                int next = previous + current;
                Console.Write($"{next} ");
                previous = current;
                current = next;
            }

            Console.WriteLine();
        }
    }
}
