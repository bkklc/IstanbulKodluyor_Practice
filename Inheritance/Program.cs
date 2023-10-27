namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inheritance -- Kalıtım - Miras

            //Customer customer = new Customer();

            Person[] persons = new Person[3]
            {
                new Person
                {
                    FirstName = "Berk"
                },
                new Customer
                {
                    FirstName = "Ahmet"
                },
                new Student
                {
                    FirstName = "Engin"
                }
            };

            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }


        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }


    interface Iperson
    {

    }

    class Person2
    {
        // 1 nesneyi sadece 1 tane inheritance alınabilir ama 1 den fazla interface eklenebilir
        // classların tek başına anlamı vardır ama interfacelerin yoktur
    }


    class Customer : Person // customer personda dünyaya gelmiş bir nesne gibi düşünülebilir
    {
        public string City { get; set; }
    }

    class Student: Person
    {
        public string Department { get; set; }
    }

}