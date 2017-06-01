using MyProject.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MyProject.Utils;

namespace MyProject.Repository
{
    class RepositoryBiddings : IRepository<string, Bidding>
    {
        public RepositoryBiddings()
        {

        }

        public void Save(Bidding elem)
        {
            var _connectionString = DBUtils.getConnection();
            var command = (SqlCommand)_connectionString.CreateCommand();

            command.CommandText = @"INSERT INTO Bidding(usernameCommitteeMember, idP, accepted)
					VALUES (@username, @idP, @accepted)";
         
            command.Parameters.AddWithValue("@username", elem.UsernameCommitteeMember);
            command.Parameters.AddWithValue("@idP", elem.IdPaper);
            if (elem.Accepted==true)    
                command.Parameters.AddWithValue("@accepted", 1);
            else
                command.Parameters.AddWithValue("@accepted", 0);

            command.ExecuteNonQuery();
        }

        public void Delete(string idBidding)
        {
            string[] keys = idBidding.Split(' ');
            string username = keys[0];
            int idP = Int32.Parse(keys[1]);

            var _connectionString = DBUtils.getConnection();
            var command = (SqlCommand)_connectionString.CreateCommand();
            command.CommandText = @"DELETE FROM Bidding WHERE usernameCommitteeMember = @username AND idP = @idP";
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@idP", idP);
            command.ExecuteNonQuery();
        }

        public Bidding GetOne(string idBidding)
        {
            string[] keys = idBidding.Split(' ');
            string username = keys[0];
            int idP = Int32.Parse(keys[1]);

            var _connectionString = DBUtils.getConnection();
            var command = (SqlCommand)_connectionString.CreateCommand();
            command.CommandText = "SELECT * FROM Bidding  WHERE usernameCommitteeMember = @username AND idP = @idP";
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@idP", idP);

            var reader = command.ExecuteReader();
            Bidding bidding = new Bidding();
            if (reader.Read())
            {
                bidding.UsernameCommitteeMember = reader["usernameCommitteeMember"].ToString();
                bidding.IdPaper = Int32.Parse(reader["idP"].ToString());
                bidding.Accepted = Boolean.Parse(reader["accepted"].ToString());
            }
            reader.Close();

            return bidding;
        }

        public IEnumerable<Bidding> GetAll()
        {
            var _connectionString = DBUtils.getConnection();
            var command = (SqlCommand)_connectionString.CreateCommand();
            command.CommandText = "SELECT * FROM Bidding";

            var reader = command.ExecuteReader();
            List<Bidding> biddings = new List<Bidding>();
            while (reader.Read())
            {
                Bidding bidding = new Bidding();
                bidding.UsernameCommitteeMember = reader["usernameCommitteeMember"].ToString();
                bidding.IdPaper = Int32.Parse(reader["idP"].ToString());
                bidding.Accepted = Boolean.Parse(reader["accepted"].ToString());
                biddings.Add(bidding);
            }
            reader.Close();

            return biddings;
        }

        public void Update(Bidding e1, Bidding e2)
        {
            var _connectionString = DBUtils.getConnection();
            var command = (SqlCommand)_connectionString.CreateCommand();
            command.CommandText = @"UPDATE Bidding SET accepted = @accepted WHERE usernameCommitteeMember = @username AND idP = @idP";
            command.Parameters.AddWithValue("@username", e1.UsernameCommitteeMember);
            command.Parameters.AddWithValue("@idP", e1.IdPaper);
            command.Parameters.AddWithValue("@accepted", e1.Accepted);
            command.ExecuteNonQuery();
        }
    }
}
