namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Methods");

            Add();
            Add();
            var result = Add2(12,58);
            Console.WriteLine(result);
            
        }

        static void Add()
        {
            Console.WriteLine("Added !!");
        }

        // parametreli metotlar

        static int Add2(int number1, int number2)
        {
            var result = number1 + number2;
            return result;
        }

    }
}