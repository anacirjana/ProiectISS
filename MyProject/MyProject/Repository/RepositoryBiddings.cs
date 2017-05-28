using MyProject.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repository
{
    class RepositoryBiddings : IRepository<string, Bidding>
    {
        public RepositoryBiddings()
        {

        }

        public void Save(Bidding cm)
        {
        }

        public void Delete(string idBidding)
        {
        }

        public Bidding GetOne(string idBidding)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Bidding> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Bidding e1, Bidding e2)
        {
            throw new NotImplementedException();
        }
    }
}
