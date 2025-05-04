using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }
        public IEnumerable<ICustomerDal> GetAll()
        {
            List<ICustomerDal> customers = new List<ICustomerDal>();
            return customers;


        }
    }
}
