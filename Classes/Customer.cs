using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Customer
    {
        // Classlar İçinde Property Tanımlamak

        //field - değişken, alan tanımlama
        //public string FirstName;

        //private string _firstName;
        //public string FirstName
        //{
        //    get { return "Mr " +  _firstName;} 
        //    set { _firstName = value; }//}

        //property - özellik tanımlama - classı anlatan özelliklerini anlatmak için kullanılır.
        public int Id { get; set; }
        public  string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

        


    }
}
