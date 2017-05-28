using MyProject.Domain;
using MyProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Controller
{
    class ControllerBiddings
    {
        private RepositoryBiddings _repositoryBidding;

        public ControllerBiddings()
        {
            _repositoryBidding = new RepositoryBiddings();
        }

        public void AddBidding(Bidding bidding)
        {
            _repositoryBidding.Save(bidding);
        }

        public void DeleteBidding(string userCM, int idPaper)
        {
            string idBidding = userCM + " " + idPaper.ToString();
            _repositoryBidding.Delete(idBidding);
        }

        public void UpdateBidding(Bidding oldBidding, Bidding newBidding)
        {
            _repositoryBidding.Update(oldBidding, newBidding);
        }

        public Bidding GetOneBidding(string userCM, int idPaper)
        {
            string idBidding = userCM + " " + idPaper.ToString();
            return _repositoryBidding.GetOne(idBidding);
        }

        public IEnumerable<Bidding> GetAllBiddings()
        {
            return _repositoryBidding.GetAll();
        }
    }
}
