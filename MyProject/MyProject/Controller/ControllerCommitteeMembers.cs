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
        public ControllerCommitteeMembers(RepositoryCommitteeMembers r)
        {
            repo = r;
        }
        public CommitteeMember Login(string username, string password)
        {
           CommitteeMember cm = repo.GetOne(username);
            if (cm.Password == password)
                return cm;
            else
                return new CommitteeMember("", "", "", "", "", "", "", "");

        }
    }
}
