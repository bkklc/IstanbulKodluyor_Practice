namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Methods");
            /*
            Add();
            Add();
            var result = Add2(12,58);
            */
            /*
            int number1 ;
            int number2 = 100;
            var result2 = Add4(out number1, number2);

            Console.WriteLine("Result 2: " + result2);
            Console.WriteLine(number1);
            */
            //Console.WriteLine("Default Parametreli Metot: " + Add3());

            Console.WriteLine(Multiply(2,5));
            Console.WriteLine(Multiply(2,5,8));

        }

        // Method Giriş
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

        // Default Parametreli Metotlarla Çalışmak
        static int Add3(int number1 = 15, int number2 = 32)
        {
            var result = number1 + number2;
            return result;
        }

        /*
        // Ref Keyword İle Çalışmak
        static int Add4(ref int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }
        */

        // ref keywordun aynı adlı değişkene bir deger atamak gerekiyor
        // out keywordunde  deger atamak gerekmiyor

        // Out Keyword İle Çalışmak
        static int Add4(out int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

        // Method Overloading
        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        // method overload
        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }
    }
}