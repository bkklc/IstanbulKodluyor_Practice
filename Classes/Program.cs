using System.Runtime.InteropServices;

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

            Customer customer = new Customer();
            customer.City = "Kocaeli";
            customer.Id = 1;
            customer.FirstName = "Berk";
            customer.LastName = "Kılıç";

            Customer customer2 = new Customer
            {
                Id = 1, City = "Kocaeli", FirstName = "Ahmet", LastName = "Kılıç"
            };

            Console.Write(customer2.FirstName);


        }
    }
}