using MyProject.Domain;
using MyProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Controller
{
    class ControllerSpeakers
    {
        RepositorySpeakers repo;

        public ControllerSpeakers(RepositorySpeakers r)
        {
            repo = r;
        }

        public Speaker Login(string username, string password)
        {
            Speaker s = repo.GetOne(username);
            if (s.Password == password)
                return s;
            else
                return new Speaker("", "", "", "", "");

            Speaker sS=new Speaker();
            return sS;

        }
    }
}
