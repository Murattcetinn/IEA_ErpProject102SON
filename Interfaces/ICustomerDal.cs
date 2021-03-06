using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();

    }

    class UseMsSqlServer:ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("MsSql Added");
        }

        public void Update()
        {
            Console.WriteLine("MsSql Updated");
        }

        public void Delete()
        {
            Console.WriteLine("MsSql Deleted");
        }
    }

    class UseOracleServer:ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle Added");
        }

        public void Update()
        {
            Console.WriteLine("Oracle Updated");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle Deleted");
        }
    }

    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)// Parametre olarak verdik. Constructure olarakta yapacagiz.
        {
            customerDal.Add();
        }
    }
}
