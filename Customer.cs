using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Customer : Person
    {
        public int Id { get; set; }

        private string _firstName;
        private string _lastName;
        public string firsName
        {
            get { return "Sayın. " + _firstName; }
            set { _firstName = value; }
        }

        private string _firlastName;
        public string firlastName
        {
            get { return _firstName + " " + lastName; }
            set { _firlastName = value; }

        }
        public string lastName { get; set; }

        public string City { get; set; }



    }
}

