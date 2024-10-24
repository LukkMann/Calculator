namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num1;
            int num2;
            int result = 0;

            string answer;
          
            Console.WriteLine("Hello, World!");

            Console.WriteLine("enter first number");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter second number");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("choose operation +,-,x,/");
            answer = Console.ReadLine();

            if (answer == "+")
            {
                result = num1 + num2;
            }
            else if (answer == "-")
            {
                result = num1 - num2;
            }
            else if (answer == "x")
            {
                result = num1 * num2;
            }
            else if (answer == "/")
            {
                result = num1 / num2;
            }
            else 
            {
                Console.WriteLine("unidentified operation");
            }

            Console.WriteLine("Result " + result);



            Console.ReadLine();


        }
    }
}
