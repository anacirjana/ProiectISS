using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISS
{
    class RepositoryCommitteeMembers<ID, CommitteeMember> : ARepository<ID, CommitteeMember>
    {
        private SqlConnection _connectionString = new SqlConnection("Data Source=DESKTOP-QS4B64I\\SQLEXPRESS; " +
            "Initial Catalog = ProiectISS; Integrated Security = True");

        public RepositoryCommitteeMembers()
        {
        }

        public string GetAffiliation(string username)
        {
            var command = (SqlCommand)_connectionString.CreateCommand();
            command.CommandText = "SELECT affiliation FROM CommitteeMembers WHERE username = @usname";
            command.Parameters.AddWithValue("@usname", username);

            _connectionString.Open();
            var reader = command.ExecuteReader();
            var affiliation = "";

            while (reader.Read())
            {
                affiliation = reader.GetString(0);
            }

            reader.Close();
            _connectionString.Close();

            return affiliation;
        }

        public string GetWebpage(string username)
        {
            var command = (SqlCommand)_connectionString.CreateCommand();
            command.CommandText = "SELECT webpage FROM CommitteeMembers WHERE username = @usname";
            command.Parameters.AddWithValue("@usname", username);

            _connectionString.Open();
            var reader = command.ExecuteReader();

            var webpage = "";
            while (reader.Read())
            {
                webpage = reader.GetString(0);
            }

            reader.Close();
            _connectionString.Close();

            return webpage;
        }

        public string GetRang(string username)
        {
            var command = (SqlCommand)_connectionString.CreateCommand();
            command.CommandText = "SELECT rang FROM CommitteeMembers WHERE username = @usname";
            command.Parameters.AddWithValue("@usname", username);

            _connectionString.Open();
            var reader = command.ExecuteReader();

            var rang = "";
            while (reader.Read())
            {
                rang = reader.GetString(0);
            }

            reader.Close();
            _connectionString.Close();

            return rang;
        }
    }
}
