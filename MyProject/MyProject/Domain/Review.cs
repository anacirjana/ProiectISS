using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Domain
{
	class Review
	{
		private int idR;
		private int idP;
		private string usernameCommiteeMember;
		private string qualifier;
		private string comment;

		//Base Constructor
		public Review()
		{
			IdR = 0;
			IdP = 0;
			UsernameCommiteeMember = "";
			Qualifier = "";
			Comment = "";
		}

		//Parametrised Constructor
		public Review( string user, int idp, string qualif, string comm)
		{
			UsernameCommiteeMember = user;
			IdP = idp;
			Qualifier = qualif;
			Comment = comm;
		}

		//Copy Constructor
		public Review(Review r)
		{
			IdR = r.IdR;
			UsernameCommiteeMember = r.UsernameCommiteeMember;
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

		public string UsernameCommiteeMember
		{
			get
			{
				return usernameCommiteeMember;
			}

			set
			{
				usernameCommiteeMember = value;
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
