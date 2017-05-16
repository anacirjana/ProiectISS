using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISS
{
        public class Listener : User
        {
            //base constructor
            public Listener() { }

            //parameterized constructor
            public Listener(string username, string password, string firstName, string surName, string email) :
                base(username, password, firstName, surName, email)
            { }
            public string ToString()
            {
                return base.ToString();
            }
        }
    }
}
