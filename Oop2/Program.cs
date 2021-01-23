using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            RealCustomer customer1 = new RealCustomer();
            customer1.Id = 1;
            customer1.CustomerNumber = "12345";
            customer1.Name = "elçin";
            customer1.LastName = "sevim";
            customer1.TcNumber = "1133422455";
        
            LegalCustomer customer2 = new LegalCustomer();
            customer2.Id = 2;
            customer2.CustomerNumber = "22220";
            customer2.CompanyName = "kodlama.io";
            customer2.TaxNumber = "461654";


            Customer customer3 = new RealCustomer(); 
            Customer customer4 = new LegalCustomer();
          
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);

        }
    }
}
