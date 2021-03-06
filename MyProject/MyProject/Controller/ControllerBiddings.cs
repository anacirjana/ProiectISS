﻿using MyProject.Domain;
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

        public void addBidding(Bidding bidding)
        {
            _repositoryBidding.Save(bidding);
        }

        public void deleteBidding(string userCM, int idPaper)
        {
            string idBidding = userCM + " " + idPaper.ToString();
            _repositoryBidding.Delete(idBidding);
        }

        public void updateBidding(Bidding oldBidding, Bidding newBidding)
        {
            _repositoryBidding.Update(oldBidding, newBidding);
        }

        public Bidding getOneBidding(string userCM, int idPaper)
        {
            string idBidding = userCM + " " + idPaper.ToString();
            return _repositoryBidding.GetOne(idBidding);
        }

        public IEnumerable<Bidding> getAllBiddings()
        {
            return _repositoryBidding.GetAll();
        }
    }
}
