namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter yes or no to proceed");
            string x = Console.ReadLine();
            if (x.ToLower() == "yes")
            {


                int n
                string input

                Console.WriteLine("enter number");
                input = Console.ReadLine(); 
                bool success = int.TryParse( input, out n);
                if(success ) 
                {
                    Console.WriteLine("result = " + Factorial(n));
                }
                
            }
            else if(x.ToLower() == "no") 
            {
                Console.WriteLine("Bye");
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }

        static int Factorial(int x)
        {
            int fact = 1;
            for (int i = 1; i <= x; i++)
            {
                fact *= i;
            }
            return fact;

        }


    }
}
