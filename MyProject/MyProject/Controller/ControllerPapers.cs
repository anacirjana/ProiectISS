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
        public ControllerPapers(RepositoryPapers repop)
        {
            this.repop = repop;
        }
        public void Update(Paper paperOld, Paper paperNew)
        {
            repop.Update(paperOld, paperNew);
        }
        public void Delete(int id)
        {
            repop.Delete(id);
        }

        public Paper GetPaper(int id)
        {
            return repop.GetOne(id);
        }

        public IEnumerable<Paper> GetAllPapers()
        {
            return repop.GetAll();
        }

        public IEnumerable<Paper> GetAllAcceptedPapers()
        {
            return repop.GetAllAccepted();
        }

        public string GetTitle(int id)
        {
            return repop.GetTitle(id);
        }

        public string GetKeywords(int id)
        {
            return repop.GetKeywords(id);
        }

        public string GetTopic(int id)
        {
            return repop.GetTopic(id);
        }

        public string GetAuthors(int id)
        {
            return repop.GetAuthors(id);
        }

        public string GetPublisher(int id)
        {
            return repop.GetPublisher(id);
        }

        public int GetDate(int id)
        {
            return repop.GetDate(id);
        }

        public string GetPathPaper(int id)
        {
            return repop.GetPathPaper(id);
        }

        public int GetidLucrare(int id)
        {
            return repop.GetidLucrare(id);
        }

        public DateTime GetAbstractDeadline()
        {
            return repop.GetAbstractDeadline();
        }

        public DateTime GetPaperDeadline()
        {
            return repop.GetPaperDeadline();
        }

        public int GetSectionId(string nameS)
        {
            return repop.GetIdSection(nameS);
        }

        public void SavePaper(Paper p)
        {
            repop.Save(p);
        }

        public int GetIdPaper()
        {
            return repop.GetIdPaper();
        }

        public void UpdatePaperSpeaker(string user,int idP)
        {
            repop.UpdatePaperSpeaker(user,idP);
        }
    }
}
