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
        public void Save(Paper p)
        {
            //nu trebuie
        }
        public void Update(Paper p1, Paper p2)
        {

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
            List<Paper> l = new List<Paper>();
            Paper cm = new Paper();
            l.Add(cm);
            return l;
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