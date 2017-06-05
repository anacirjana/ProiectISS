using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyProject.Repository;
using MyProject.Domain;
namespace MyProject.Controller
{
    class ControllerListeners
    {
        private RepositoryListeners repo;

        public ControllerListeners()
        {
            repo = new RepositoryListeners();
        }

        public Listener Login(string username, string password)
        {
            Listener s = repo.GetOne(username);
            if (s.Password == password)
                return s;
            else
                return new Listener("", "", "", "", "");

        }

        public void Register(Listener s)
        {
            repo.Save(s);
        }

        public void deleteListener(string username)
        {

            repo.Delete(username);
        }

        public void updateListener(Listener oldListener, Listener newListener)
        {
            repo.Update(oldListener, newListener);
        }

        public Listener getOneListener(string username)
        {

            return repo.GetOne(username);
        }

        public IEnumerable<Listener> getAllListener()
        {
            return repo.GetAll();
        }

		public void addListener(string username, int idP)
		{
			repo.addListener(username, idP);
		}


    }
}
