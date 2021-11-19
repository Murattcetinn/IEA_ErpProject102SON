using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //Interface ler new keyword u ile instantname olusturamazlar
            //IPerson person = new IPerson();

            NewMethod();

            CustomerManager cm = new CustomerManager();
            cm.Add(new UseMsSqlServer());
            cm.Add(new UseOracleServer());

            //Polymorphism ornegi
            ICustomerDal[] customerDals = new ICustomerDal[2]
            {
                new UseMsSqlServer(),
                new UseOracleServer()
            };
            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }

            Console.ReadLine();
        }

        private static void NewMethod()
        {
            //Customer customer = new Customer {Name = "Onur"};
            //Student student = new Student {Name = "Selin"};

            IPerson person = new Customer {Name = "Onur"};
            IPerson person1 = new Student {Name = "Selin"};


            PersonManager pm = new PersonManager();
            //pm.Add(customer);
            //pm.Add(student);
            pm.Add(person);
            pm.Add(person1);
        }
    }

    interface IPerson //Soyut nesne
    {
        int Id { get; set; }
        string Name { get; set; }
        string SurName { get; set; }
    }

    class Customer : IPerson //Somut Nesne
    {
        public int Id { get ; set ; }
        public string Name { get ; set ; }
        public string SurName { get ; set ; }

        public string Adress { get; set; }
    }

    class Student:IPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }

        public string StudentNo { get; set; }
    }

    class PersonManager
    {
        //public void Add(Customer customer)
        //{
        //    Console.WriteLine(customer.Name);
        //}
        //public void Add(Student student)
        //{
        //    Console.WriteLine(student.Name);
        //}

        public void Add(IPerson person)
        {
            Console.WriteLine(person.Name);
        }
    }
}
