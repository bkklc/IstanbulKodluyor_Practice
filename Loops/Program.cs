namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ForLoop();
            // WhileLoop();
            // DoWhileLoop();
            // ForEachLoop();

            if (IsPrimeNumber(6))
            {
                Console.WriteLine("This is prime number ");
            }

            else
            {
                Console.WriteLine("This is not prime number ");
            }
        }

        private static bool IsPrimeNumber(int number)
        {
            bool result = true;
            for (int i = 2; i < number - 1; i++)
            {
                if (number % i == 0)
                {
                    result = false;
                    i = number;
                }
            }
            return result;
        }


        private static void ForEachLoop()
        {
            string[] students = new string[3] { "Derin", "Engin ", "Berk" };

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }

        private static void DoWhileLoop()
        {
            // Do While
            int number = 10;
            do
            {
                Console.WriteLine(number);
                number--;
            } while (number >= 11);
        }

        private static void WhileLoop()
        {
            // While Döngüsü
            int number = 100;
            while (number >= 0)
            {
                Console.WriteLine(number);
                number--;
            }

            Console.WriteLine("Number is " + number);
        }

        private static void ForLoop()
        {
            // For Döngüsü
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("!!! Finished !!!");
        }
    }
}