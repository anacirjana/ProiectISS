using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using MyProject.Utils;
using System.Threading.Tasks;
using MyProject.Domain;

namespace MyProject.Repository
{
	class RepositoryReviews : IRepository<int, Review> 
	{
		public RepositoryReviews()
		{

		}

		public string GetUsernameCommitteeMember(int idReview)
		{
			var _connectionString = DBUtils.getConnection();
			var command = (SqlCommand)_connectionString.CreateCommand();
			command.CommandText = "SELECT username FROM Reviews WHERE idR = @id";
			command.Parameters.AddWithValue("@id", idReview);

			var reader = command.ExecuteReader();
			string username = "";
			if (reader.Read())
			{
				username = reader[0].ToString();
			}
			reader.Close();

			return username;
		}

		public string GetQualifier(int idReview)
		{
			var _connectionString = DBUtils.getConnection();
			var command = (SqlCommand)_connectionString.CreateCommand();
			command.CommandText = "SELECT qualifier FROM Reviews WHERE idR = @id";
			command.Parameters.AddWithValue("@id", idReview);

			var reader = command.ExecuteReader();
			string qualifier = "";
			if (reader.Read())
			{
				qualifier = reader[0].ToString();
			}
			reader.Close();

			return qualifier;
		}

		public string GetComment(int idReview)
		{
			var _connectionString = DBUtils.getConnection();
			var command = (SqlCommand)_connectionString.CreateCommand();
			command.CommandText = "SELECT comment FROM Reviews WHERE idR = @id";
			command.Parameters.AddWithValue("@id", idReview);

			var reader = command.ExecuteReader();
			string comment = "";
			if (reader.Read())
			{
				comment = reader[0].ToString();
			}
			reader.Close();

			return comment;
		}

		public int GetIdPaper(int idReview)
		{
			var _connectionString = DBUtils.getConnection();
			var command = (SqlCommand)_connectionString.CreateCommand();
			command.CommandText = "SELECT idP FROM Reviews WHERE idR = @id";
			command.Parameters.AddWithValue("@id", idReview);

			var reader = command.ExecuteReader();
			int idP = 0;
			if (reader.Read())
			{
				idP = Int32.Parse(reader[0].ToString());
			}
			reader.Close();

			return idP;
		}

		public void Save(Review elem)
		{
			var _connectionString = DBUtils.getConnection();
			var command = (SqlCommand)_connectionString.CreateCommand();
			command.CommandText = @"INSERT INTO Reviews(username, idP, qualifier, comment)
					VALUES (@idR, @username, @idP, @qualifier, @comment)";
			command.Parameters.AddWithValue("@username", elem.UsernameCommiteeMember);
			command.Parameters.AddWithValue("@idP", elem.IdP);
			command.Parameters.AddWithValue("@qualifier", elem.Qualifier);
			command.Parameters.AddWithValue("@comment", elem.Comment);
			command.ExecuteNonQuery();
		}

		public void Delete(int id)
		{
			var _connectionString = DBUtils.getConnection();
			var command = (SqlCommand)_connectionString.CreateCommand();
			command.CommandText = @"DELETE FROM Reviews WHERE idR = @idR";
			command.Parameters.AddWithValue("@idR", id);
			command.ExecuteNonQuery();
		}

		public Review GetOne(int id)
		{
			var _connectionString = DBUtils.getConnection();
			var command = (SqlCommand)_connectionString.CreateCommand();
			command.CommandText = "SELECT * FROM Reviews WHERE idR = @id";
			command.Parameters.AddWithValue("@id", id);

			var reader = command.ExecuteReader();
			Review review = new Review();
			if (reader.Read())
			{
				review.IdP = Int32.Parse(reader["idP"].ToString());
				review.IdR = Int32.Parse(reader["idR"].ToString());
				review.Comment = reader["comment"].ToString();
				review.Qualifier = reader["qualifier"].ToString();
				review.UsernameCommiteeMember = reader["username"].ToString();
			}
			reader.Close();

			return review;
		}

		public IEnumerable<Review> GetAll()
		{
			var _connectionString = DBUtils.getConnection();
			var command = (SqlCommand)_connectionString.CreateCommand();
			command.CommandText = "SELECT * FROM Reviews";

			var reader = command.ExecuteReader();
			List<Review> reviews = new List<Review>();
			while (reader.Read())
			{
				Review review = new Review();
				review.IdP = Int32.Parse(reader["idP"].ToString());
				review.IdR = Int32.Parse(reader["idR"].ToString());
				review.Comment = reader["comment"].ToString();
				review.Qualifier = reader["qualifier"].ToString();
				review.UsernameCommiteeMember = reader["username"].ToString();
				reviews.Add(review);
			}
			reader.Close();

			return reviews;
		}

		public void Update(Review e1, Review e2)
		{
			var _connectionString = DBUtils.getConnection();
			var command = (SqlCommand)_connectionString.CreateCommand();
			command.CommandText = @"UPDATE Reviews SET username = @username, idP = @idP, qualifier = @qualifier, comment = @comment WHERE idR = @idR";
			command.Parameters.AddWithValue("@idR", e1.IdR);
			command.Parameters.AddWithValue("@username", e2.UsernameCommiteeMember);
			command.Parameters.AddWithValue("@idP", e2.IdP);
			command.Parameters.AddWithValue("@qualifier", e2.Qualifier);
			command.Parameters.AddWithValue("@comment", e2.Comment);
			command.ExecuteNonQuery();
		}
	}
}
