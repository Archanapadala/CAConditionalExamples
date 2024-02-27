namespace CAConditionalExamples
{
    internal class homework3
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 20;
            Console.WriteLine($"Before swapping: x={x} , y = {y}");
            y = x + y; 
            x = y - x; 
            y = y - x;
            Console.WriteLine($"After swapping:x={x} , y = {y} ");
        }
    }
}
