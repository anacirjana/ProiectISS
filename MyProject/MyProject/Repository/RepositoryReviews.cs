using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repository
{
	class RepositoryReviews<Integer, Review> 
	{
		private SqlConnection _connectionString = new SqlConnection("Data Source=DESKTOP-DMVLDS4\\SQLEXPRESS; " +
			"Initial Catalog = ProiectISS; Integrated Security = True");

		public RepositoryReviews()
		{

		}

		public string GetUsernameCommitteeMember(int idReview)
		{
			var command = (SqlCommand)_connectionString.CreateCommand();
			command.CommandText = "SELECT username FROM Reviews WHERE idR = @id";
			command.Parameters.AddWithValue("@id", idReview);

			_connectionString.Open();
			var reader = command.ExecuteReader();
			string username = "";
			if (reader.Read())
			{
				username = reader[0].ToString();
			}
			reader.Close();
			_connectionString.Close();

			return username;
		}

		public string GetQualifier(int idReview)
		{
			var command = (SqlCommand)_connectionString.CreateCommand();
			command.CommandText = "SELECT qualifier FROM Reviews WHERE idR = @id";
			command.Parameters.AddWithValue("@id", idReview);

			_connectionString.Open();
			var reader = command.ExecuteReader();
			string qualifier = "";
			if (reader.Read())
			{
				qualifier = reader[0].ToString();
			}
			reader.Close();
			_connectionString.Close();

			return qualifier;
		}

		public string GetComment(int idReview)
		{
			var command = (SqlCommand)_connectionString.CreateCommand();
			command.CommandText = "SELECT comment FROM Reviews WHERE idR = @id";
			command.Parameters.AddWithValue("@id", idReview);

			_connectionString.Open();
			var reader = command.ExecuteReader();
			string comment = "";
			if (reader.Read())
			{
				comment = reader[0].ToString();
			}
			reader.Close();
			_connectionString.Close();

			return comment;
		}

		public int GetIdPaper(int idReview)
		{
			var command = (SqlCommand)_connectionString.CreateCommand();
			command.CommandText = "SELECT idP FROM Reviews WHERE idR = @id";
			command.Parameters.AddWithValue("@id", idReview);

			_connectionString.Open();
			var reader = command.ExecuteReader();
			int idP = 0;
			if (reader.Read())
			{
				idP = Int32.Parse(reader[0].ToString());
			}
			reader.Close();
			_connectionString.Close();

			return idP;
		}
	}
}
