using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Domain
{
    public class Speaker:User
    {
        //base constructor
        public Speaker() { }

        //parameterized constructor
        public Speaker(string username,string password,string firstName,string surName,string email):
            base(username, password, firstName, surName, email)
        { }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
