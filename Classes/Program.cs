namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Classes");

            CustomerManager customerManager = new CustomerManager(); // classın  örneğini oluşturduk
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager(); // classın  örneğini oluşturduk
            productManager.Add();
            productManager.Update();

        }
    }
}