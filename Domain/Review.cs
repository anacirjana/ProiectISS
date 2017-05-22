using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISS
{
	class Review
	{
		private int idR;
		private int idP;
		private string usernameCommitteeMember;
		private string qualifier;
		private string comment;

		//Base Constructor
		public Review()
		{
			IdR = 0;
			IdP = 0;
			UsernameCommitteeMember = "";
			Qualifier = "";
			Comment = "";
		}

		//Parametrised Constructor
		public Review(int idr, string user, int idp, string qualif, string comm)
		{
			IdR = idr;
			UsernameCommitteeMember = user;
			IdP = idp;
			Qualifier = qualif;
			Comment = comm;
		}

		//Copy Constructor
		public Review(Review r)
		{
			IdR = r.IdR;
			UsernameCommitteeMember = r.UsernameCommitteeMember;
			IdP = r.IdP;
			Qualifier = r.Qualifier;
			Comment = r.Comment;
		}

		public int IdR
		{
			get
			{
				return idR;
			}

			set
			{
				idR = value;
			}
		}

		public int IdP
		{
			get
			{
				return idP;
			}

			set
			{
				idP = value;
			}
		}

		public string UsernameCommitteeMember
		{
			get
			{
				return usernameCommitteeMember;
			}

			set
			{
				usernameCommitteeMember = value;
			}
		}

		public string Qualifier
		{
			get
			{
				return qualifier;
			}

			set
			{
				qualifier = value;
			}
		}

		public string Comment
		{
			get
			{
				return comment;
			}

			set
			{
				comment = value;
			}
		}
	}
}
