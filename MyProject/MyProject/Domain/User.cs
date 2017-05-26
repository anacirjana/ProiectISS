using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Domain

{
    public class User
    {

        String username, password, firstName, surName, email;

        //base constructor

       public User()
        {
            username = "";
            password = "";
            firstName = "";
            surName = "";
            email = "";
        }
        //parametrised constructor

        public User(String u,String p,String fn,String sn,String e)
        {
            username = u;
            password = p;
            firstName = fn;
            surName = sn;
            email = e;
        }
        //copy constructor
       public User(User a)
        {
            username = a.Username;
            password = a.Password;
            firstName = a.FirstName;
            surName = a.Username;
            email = a.Email;

        }

        //access points

        public string Username
        {
            set
            {
                username = value;
            }
            get
            {
                return username;
            }
        }

        public string Password
        {
            set
            {
                password = value;
            }
            get
            {
                return password;
            }
        }

        public string FirstName
        {
            set
            {
                firstName = value;
            }
            get
            {
                return firstName;
            }
        }

        public string SurName
        {
            set
            {
                surName = value;
            }
            get
            {
                return surName;
            }
        }

        public string Email
        {
            set
            {
                email = value;
            }
            get
            {
                return email;
            }
        }

    }
}
