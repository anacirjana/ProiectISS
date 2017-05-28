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
        private RepositorySpeakers repo;

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

        }

        public void Register(Speaker s)
        {
            repo.Save(s);
        }

        public void deleteSpeaker(string username)
        {
           
            repo.Delete(username);
        }

        public void updateSpeaker(Speaker oldSpeaker, Speaker newSpeaker)
        {
            repo.Update(oldSpeaker, newSpeaker);
        }

        public Speaker getOneSpeaker(string username)
        {
          
            return repo.GetOne(username);
        }

        public IEnumerable<Speaker> getAllSpeakers()
        {
            return repo.GetAll();
        }


    }
}
