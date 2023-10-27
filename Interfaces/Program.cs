namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    //soyut nesne
    // aynı özelliklerin tekrarlamayı önlemek için nesnelerde çağrılarak kullanılır
    interface IPerson 
    {
        int Id { get; set; }
        int FirstName { get; set; }
        int LastName { get; set; }
    }

    //somut nesne
    class Customer : IPerson
    {
        public int Id { get; set; }
        public int FirstName { get; set; }
        public int LastName { get; set; }

        public string Adress { get; set; }
    }

    class Student : IPerson
    {
        public int Id { get; set; }
        public int FirstName { get; set; }
        public int LastName { get; set; }

        public string Department { get; set; }
    }
}