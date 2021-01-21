using System;

namespace constructer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instance-örnek 
            Customer customer1 = new Customer(2,"Elif","Yüksel","Bursa");
            Customer customer2 = new Customer { Id = 1, FirstName = "AYNUR", LastName = "Yüksel", City = "Bursa" };
            Console.WriteLine(customer1.FirstName);
        
        }
    }

    class Customer

    {
        //default Constructor
        public Customer()
        {

        }

        public Customer(int id, string firstName, string lastName, string city)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
            City = city;
        }
        //Müşteri class -Müşteir bilgilerini tutan 
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
