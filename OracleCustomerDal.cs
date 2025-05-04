using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class OracleCustomerDal : ICustomerDal
    {
        public void Add()
        {
            string durum = "Kaydedildi";
        }

        public int Count()
        {
            return 10;
        }

        public void Delete()
        {
            string durum = "Silindi";
        }

        public IEnumerable<Customer> GetAll()
        {
           List<Customer> customers = new List<Customer>();
            return customers;
        }

        public void Update()
        {
            string durum = "Güncellendi";
        }
    }
}
