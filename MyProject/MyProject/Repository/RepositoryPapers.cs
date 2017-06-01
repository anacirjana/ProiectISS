using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyProject.Domain;
using MyProject.Repository;
using MyProject.Utils;
namespace MyProject.Repository
{
    public  class RepositoryPapers : IRepository<int, Paper>
    {
        public void Update(Paper p1, Paper p2)
        {
            var _connectionString = DBUtils.getConnection();
            var command = (SqlCommand)_connectionString.CreateCommand();
            command.CommandText = @"UPDATE Papers SET title = @title, idSection = @idSection, keywords = @keywords, topics = @topics, authors = @authors, publisher = @publisher, datePaper = @datePaper, pathPaper = @pathPaper WHERE idP = @idP";
            command.Parameters.AddWithValue("@idP", p1.IdP);
            command.Parameters.AddWithValue("@title", p2.Title);
            command.Parameters.AddWithValue("@keywors", p2.Keywords);
            command.Parameters.AddWithValue("@topics", p2.Topics);
            command.Parameters.AddWithValue("@authors", p2.Authors);
            command.Parameters.AddWithValue("@publisher", p2.Publisher);
            command.Parameters.AddWithValue("@datePaper", p2.DatePaper);
            command.Parameters.AddWithValue("@pathPaper", p2.PathPaper);
            command.Parameters.AddWithValue("@idSection", p2.IdSection);
            command.ExecuteNonQuery();
        }
        public void Save(Paper elem)
        {
            var _connectionString = DBUtils.getConnection();
            var command = (SqlCommand)_connectionString.CreateCommand();
            command.CommandText = @"INSERT INTO Papers(idP, title, keywords, topics, authors, publisher, datePaper, pathPaper, idSection)                     VALUES (@idP, @title, @keywords, @topics, @authors, @publisher, @datePaper, @pathPaper, @idSection)";
            command.Parameters.AddWithValue("@idP", elem.IdP);
            command.Parameters.AddWithValue("@title", elem.Title);
            command.Parameters.AddWithValue("@keywors", elem.Keywords);
            command.Parameters.AddWithValue("@topics", elem.Topics);
            command.Parameters.AddWithValue("@authors", elem.Authors);             command.Parameters.AddWithValue("@publisher", elem.Publisher);             command.Parameters.AddWithValue("@datePaper", elem.DatePaper);             command.Parameters.AddWithValue("@pathPaper", elem.PathPaper);             command.Parameters.AddWithValue("@idSection", elem.IdSection);
            command.ExecuteNonQuery();
        }
        public void Delete(int id)
        {

        }

        public RepositoryPapers()
        {
            
        }
        public Paper GetOne(int id)
        {
            Paper p = new Paper();
            return p;
        }
        public IEnumerable<Paper> GetAll()
        {
            var command = (SqlCommand)DBUtils.getConnection().CreateCommand();

            List<Paper> papers = new List<Paper>();
            command.CommandText = "SELECT * FROM Papers";
            
            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                papers.Add(new Paper(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), 
                                     reader.GetString(3), reader.GetString(4), reader.GetString(5),
                                     reader[6].ToString(), reader[7].ToString(), reader.GetInt32(8)));
            }

            reader.Close();

            return papers;
        }

        public IEnumerable<Paper> GetAllAccepted()
        {
            var command = (SqlCommand)DBUtils.getConnection().CreateCommand();

            List<Paper> papers = new List<Paper>();
            command.CommandText = "SELECT * FROM Papers WHERE idP NOT IN (SELECT idP FROM Reviews WHERE qualifier IN ('reject','strong reject','weak reject'))";

            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                papers.Add(new Paper(reader.GetInt32(0), reader.GetString(1), reader.GetString(2),
                                     reader.GetString(3), reader.GetString(4), reader.GetString(5),
                                     reader[6].ToString(), reader[7].ToString(), reader.GetInt32(8)));
            }

            reader.Close();

            return papers;
        }


        //======================================================================

        public string GetTitle(int id)
		{
			var command = (SqlCommand)DBUtils.getConnection().CreateCommand();
			command.CommandText = "SELECT title FROM Papers WHERE idP = @id";
            command.Parameters.AddWithValue("@id", id);

			var reader = command.ExecuteReader();
			string title = "";
			if (reader.Read())
			{
				title = reader[0].ToString();
			}
			reader.Close();
            return title;
		}

		//======================================================================

		public string GetKeywords(int id)
		{
			var command = (SqlCommand)DBUtils.getConnection().CreateCommand();
			command.CommandText = "SELECT keywords FROM Papers WHERE idP = @id";
			command.Parameters.AddWithValue("@id", id);
			var reader = command.ExecuteReader();
			string keywords = "";
			if (reader.Read())
			{
                keywords = reader[0].ToString();
			}
			reader.Close();
            return keywords;
		}

		//======================================================================

		public string GetTopic(int id)
		{
			var command = (SqlCommand)DBUtils.getConnection().CreateCommand();
			command.CommandText = "SELECT topics FROM Papers WHERE idP = @id";
			command.Parameters.AddWithValue("@id", id);

			var reader = command.ExecuteReader();
			string topics = "";
			if (reader.Read())
			{
				topics = reader[0].ToString();
			}
			reader.Close();
			return topics;
		}

		//======================================================================

		public string GetAuthors(int id)
		{
			var command = (SqlCommand)DBUtils.getConnection().CreateCommand();
			command.CommandText = "SELECT authors FROM Papers WHERE idP = @id";
			command.Parameters.AddWithValue("@id", id);
			var reader = command.ExecuteReader();
			string authors = "";
			if (reader.Read())
			{
                authors = reader[0].ToString();
			}
			reader.Close();
            return authors;
		}

        //======================================================================

		public string GetPublisher(int id)
		{
			var command = (SqlCommand)DBUtils.getConnection().CreateCommand();
			command.CommandText = "SELECT publisher FROM Papers WHERE idP = @id";
			command.Parameters.AddWithValue("@id", id);
			var reader = command.ExecuteReader();
			string publisher = "";
			if (reader.Read())
			{
                publisher = reader[0].ToString();
			}
			reader.Close();
            return publisher;
		}

		//======================================================================

		public int GetDate(int id)
		{
			var command = (SqlCommand)DBUtils.getConnection().CreateCommand();
			command.CommandText = "SELECT datePaper FROM Papers WHERE idP = @id";
			command.Parameters.AddWithValue("@id", id);
			var reader = command.ExecuteReader();
			int datePaper = 0;
			if (reader.Read())
			{
                datePaper = Int32.Parse(reader[0].ToString());
			}
			reader.Close();
            return datePaper;
		}

		//======================================================================

		public string GetPathPaper(int id)
		{
			var command = (SqlCommand)DBUtils.getConnection().CreateCommand();
			command.CommandText = "SELECT pathPaper FROM Papers WHERE idP = @id";
			command.Parameters.AddWithValue("@id", id);
			var reader = command.ExecuteReader();
			string pathPaper = "";
			if (reader.Read())
			{
                pathPaper = reader[0].ToString();
			}
			reader.Close();
            return pathPaper;
		}

		//======================================================================

		public int GetidLucrare(int id)
		{
			var command = (SqlCommand)DBUtils.getConnection().CreateCommand();
			command.CommandText = "SELECT idLucrare FROM Papers WHERE idP = @id";
			command.Parameters.AddWithValue("@id", id);
			var reader = command.ExecuteReader();
			int idLucrare = 0;
			if (reader.Read())
			{
                idLucrare = Int32.Parse(reader[0].ToString());
			}
			reader.Close();
            return idLucrare;
		}

		//======================================================================

	}
}
