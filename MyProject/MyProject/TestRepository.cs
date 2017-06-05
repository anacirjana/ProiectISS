using MyProject.Domain;
using MyProject.Repository;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Tests
{
    public class TestRepository
    {
        public TestRepository() { }

        public void test()
        {
            RepositorySpeakers repo123 = new RepositorySpeakers();
            //repo123.Save(new Speaker("username", "password", "ion", "iancu", "ion.iancu@email.com"));
            Speaker r = new Speaker("username", "password", "ion", "iancu", "ion.iancu@email.com");
            Debug.Assert(repo123.GetOne("username").Username=="username");

            RepositoryReviews repo = new RepositoryReviews();
            Debug.Assert(repo.GetOne(5).IdP == 4);

            RepositoryListeners repl = new RepositoryListeners();
            Debug.Assert(repl.GetOne("BertW").Password=="wysco");


            RepositoryCommitteeMembers repcm = new RepositoryCommitteeMembers();
            Debug.Assert(repcm.GetOne("BenG").FirstName == "Gonzalez");

            RepositoryBiddings repb = new RepositoryBiddings();
            Debug.Assert(repb.GetOne("AndiP 5").Accepted == true);
        }
        
        

    }
}
