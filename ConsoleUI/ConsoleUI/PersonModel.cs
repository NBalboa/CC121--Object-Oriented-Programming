using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class PersonModel
    {
        public string FirstName { private get; set; } 
        public string LastName { get; private set; }
        private int _age;

        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }

        public int Age
        {
            get { return _age; }
            set
            {
                if (value >= 0 || value < 126)
                {
                    _age = value;
                }
                else
                {
                    throw new ArgumentException("value", "Age need to be in a valid range");
                }
            }
        }
        private string _ssn;

        public string SSN
        {
            get
            {
                string output = "***-**-*" + _ssn.Substring(_ssn.Length - 4);
                return output;
            }
            set { _ssn = value; }
        }

        public PersonModel(string lastName)
        {
            LastName = lastName;
        }

    }
}
