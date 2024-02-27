using System.Collections;

namespace CAConditionalExamples
{
    internal class homework2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Product 1.Oneplus mobile - 45000");
            Console.WriteLine("Product 2.iphone 15 pro max - 130000");
            Console.WriteLine("Product 3.XBox 360 = 35000");
            Console.WriteLine("Product 4.PS4 = 28000");
            Console.WriteLine("Product 5.Smart Watch = 16000");
            Console.WriteLine("Enter product number");
            int product = int.Parse(Console.ReadLine());
            bool continueShopping = true;
            int totalcartvalue = 0;
            while (continueShopping)
            {
                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        totalcartvalue += 45000;
                        break;
                    case 2:
                        totalcartvalue += 130000;
                        break;
                    case 3:
                        totalcartvalue += 35000;
                        break;
                    case 4:
                        totalcartvalue += 28000;
                        break;
                    case 5:
                        totalcartvalue += 16000;
                        break;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }

                Console.Write("Do you want to continue shopping? (Yes/No): ");
                string continueChoice = Console.ReadLine();

                if (continueChoice.ToLower() != "yes")
                    continueShopping = false;
            }

            Console.WriteLine($"Thanks for shopping with us…! Total cart value is: {totalcartvalue}/-");

        }

    }
}
