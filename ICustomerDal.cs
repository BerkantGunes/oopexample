﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();
        IEnumerable<Customer> GetAll();
        int Count();



    }
}
