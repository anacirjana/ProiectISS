using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyProject.Repository;
using MyProject.Domain;

namespace MyProject.Controller
{
    public class ControllerPapers
    {
        private RepositoryPapers repop;
        public ControllerPapers()
        {
            repop = new RepositoryPapers();
        }
        public IEnumerable<Paper> getAllPapers()
        {
            return repop.GetAll();
        }

    }
}
