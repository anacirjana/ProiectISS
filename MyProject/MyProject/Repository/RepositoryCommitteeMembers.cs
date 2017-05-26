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
            var password = "";
           
            var firstName = "";
            var surName = "";
            var email = "";
            string affiliation="";
            string webpage="";
            string role="";

            while (reader.Read())
            {
                password = reader.GetString(1);
                firstName = reader.GetString(2) ;
                surName = reader.GetString(3);
                email = reader.GetString(4);
                webpage = reader.GetString(5);
                affiliation = reader.GetString(6);
                role = reader.GetString(7);
            }

            reader.Close();
            _connectionString.Close();

            CommitteeMember cm = new CommitteeMember(username,password, firstName, surName, email, webpage, affiliation, role);
            return cm;  
        }                                             
        public IEnumerable<CommitteeMember> GetAll()  
        {                                            
            List<CommitteeMember> l=new List<CommitteeMember>();
            CommitteeMember cm = new CommitteeMember("lala", "lala", "", "", "", "", "", "");
            l.Add(cm);
            return l;
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
