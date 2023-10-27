﻿namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonManager manager = new PersonManager();
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Berk",
                LastName = "Kılıç",
                Adress = "Kocaeli"
            };
           
            Student student = new Student
            {
                Id = 1,
                FirstName = "Ahmet",
                LastName = "Kılıç",
                Department = "Computer Sciences"
            };

            manager.Add(customer);
            manager.Add(student);
            
            



            // manager.Add(new Customer {Id = 1, FirstName = "Berk", LastName = "Kılıç", Adress = "Kocaeli"}); // yukarıdaki ile aynı sadece yazım şekli farklı  
        }
    }

    //soyut nesne
    // aynı özelliklerin tekrarlamayı önlemek için nesnelerde çağrılarak kullanılır
    interface IPerson 
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }

    //somut nesne
    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Adress { get; set; }
    }

    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Department { get; set; }
    }

    class Worker : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Department { get; set; }
    }


    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}