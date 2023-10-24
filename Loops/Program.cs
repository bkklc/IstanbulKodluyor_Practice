namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ForLoop();
            // WhileLoop();


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