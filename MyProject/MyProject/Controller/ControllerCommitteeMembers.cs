using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyProject.Repository;
using MyProject.Domain;

namespace MyProject.Controller
{
    class ControllerCommitteeMembers
    {
        RepositoryCommitteeMembers repo;
        public ControllerCommitteeMembers()
        {
            repo = new RepositoryCommitteeMembers();
        }
        public CommitteeMember Login(string username, string password)
        {
           CommitteeMember cm = repo.GetOne(username);
            if (cm.Password == password)
                return cm;
            else
                return new CommitteeMember("", "", "", "", "", "", "", "");

        }
        
        public List<string> GetNames()
        {
            return repo.GetNames();
        }

        public void ChangeDeadline(string name, DateTime date)
        {
            repo.ChangeDeadline(name, date);
        }
    }
}
