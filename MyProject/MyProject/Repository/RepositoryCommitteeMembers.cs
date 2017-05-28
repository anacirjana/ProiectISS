using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyProject.Domain;

namespace MyProject.Repository
{
    class RepositoryCommitteeMembers : IRepository<string, CommitteeMember>
    {
        private SqlConnection _connectionString = new SqlConnection("Data Source=DESKTOP-DMVLDS4\\SQLEXPRESS; " +
            "Initial Catalog = ProiectISS; Integrated Security = True");
        
        public RepositoryCommitteeMembers()
        {
        }
        
        public void Save(CommitteeMember cm)
        {

        }
        
        public void Update(CommitteeMember cm1, CommitteeMember cm2)
        {

        }
        
        public void Delete(string username)
        {

        }
        
        public CommitteeMember GetOne(string username)
        {
            var command = (SqlCommand)_connectionString.CreateCommand();
            command.CommandText = "SELECT * FROM CommitteeMembers WHERE username = @usname";
            command.Parameters.AddWithValue("@usname", username);

            _connectionString.Open();
            var reader = command.ExecuteReader();

            CommitteeMember committeeMember = null;
            while (reader.Read())
            {
                committeeMember = new CommitteeMember(username, reader.GetString(1), reader.GetString(2), reader.GetString(3), 
                                        reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7));
            }

            reader.Close();
            _connectionString.Close();
            
            return committeeMember;  
        }               
        
        public IEnumerable<CommitteeMember> GetAll()  
        {                                            
            List<CommitteeMember> committeeMembers=new List<CommitteeMember>();
            var command = (SqlCommand)_connectionString.CreateCommand();
            command.CommandText = "SELECT * FROM CommitteeMembers";

            _connectionString.Open();
            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                committeeMembers.Add(new CommitteeMember(reader.GetString(0),reader.GetString(1),reader.GetString(2),reader.GetString(3),
                                                        reader.GetString(4),reader.GetString(5),reader.GetString(6),reader.GetString(7)));
            }

            reader.Close();
            _connectionString.Close();

            return committeeMembers;
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
