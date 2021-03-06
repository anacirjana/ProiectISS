﻿using MyProject.Domain;
using MyProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Controller
{
	class ControllerReviews
	{
		private RepositoryReviews _repoReviews;

		public ControllerReviews()
		{
			_repoReviews = new RepositoryReviews();
		}

		public IEnumerable<Review> GetAll()
		{
			return _repoReviews.GetAll();
		}

		public void AddReview(Review review)
		{
			_repoReviews.Save(review);
		}

		public Review GetOne(int id)
		{
			return _repoReviews.GetOne(id);
		}

        public List<int> GetPapersforUser(string username)
        {
            return _repoReviews.GetPapersforUser(username);
        }

        public void UpdateReview(Review r1,Review r2)
        {
            _repoReviews.Update(r1, r2);
        }

        public int GetReviewId(string username, int idP)
        {
            return _repoReviews.getReviewId(username, idP);
        }
	}
}
