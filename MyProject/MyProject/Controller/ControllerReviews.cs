using MyProject.Domain;
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

		public ControllerReviews(RepositoryReviews repoReviews)
		{
			_repoReviews = repoReviews;
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
	}
}
