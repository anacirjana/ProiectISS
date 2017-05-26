using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using MyProject.Domain;

namespace MyProject.Repository
{
    class RepositoryListeners
    {
        private SqlConnection _connectionString = new SqlConnection("Data Source=DESKTOP-DMVLDS4\\SQLEXPRESS; " +
            "Initial Catalog = ProiectISS; Integrated Security = True");
        public RepositoryListeners()
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
        public Listener GetOne(string username)
        {
            var command = (SqlCommand)_connectionString.CreateCommand();
            command.CommandText = "SELECT * FROM Listeners WHERE username = @usname";
            command.Parameters.AddWithValue("@usname", username);

            _connectionString.Open();
            var reader = command.ExecuteReader();
            var password = "";

            var firstName = "";
            var surName = "";
            var email = "";

            while (reader.Read())
            {
                password = reader.GetString(1);
                firstName = reader.GetString(2);
                surName = reader.GetString(3);
                //email = reader.GetString(4);
            }

            reader.Close();
            _connectionString.Close();

            Listener l = new Listener(username, password, firstName, surName, email);
            return l;
        }
        public IEnumerable<Listener> GetAll()
        {
            List<Listener> l = new List<Listener>();
            Listener li = new Listener("lala", "lala", "", "", "");
            l.Add(li);
            return l;
        }
       

    }
}
