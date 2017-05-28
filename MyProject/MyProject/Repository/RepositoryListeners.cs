using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using MyProject.Domain;
using MyProject.Utils;
using MyProject.Exception.MyProject.Exception;
using MyProject.Repository;
namespace MyProject.Repository
{
    class RepositoryListeners:IRepository<string,Listener>
    {

        public RepositoryListeners()
        {
        }
        public void Save(Listener l)
        {
            var con = DBUtils.getConnection();
            using (var comm = con.CreateCommand())
            {
                comm.CommandText = "insert into Listeners(username,pass,firstName,surName,email) values (@username,@pass,@firstName,@surName,@email); ";
                var paramUser = comm.CreateParameter();
                paramUser.ParameterName = "@username";
                paramUser.Value = l.Username;
                comm.Parameters.Add(paramUser);

                var paramPass = comm.CreateParameter();
                paramPass.ParameterName = "@pass";
                paramPass.Value = l.Password;
                comm.Parameters.Add(paramPass);

                var paramFName = comm.CreateParameter();
                paramFName.ParameterName = "@firstName";
                paramFName.Value = l.FirstName;
                comm.Parameters.Add(paramFName);

                var paramSName = comm.CreateParameter();
                paramSName.ParameterName = "@surName";
                paramSName.Value = l.SurName;
                comm.Parameters.Add(paramSName);

                var paramEmail = comm.CreateParameter();
                paramEmail.ParameterName = "@email";
                paramEmail.Value = l.Email;
                comm.Parameters.Add(paramEmail);

                var result = comm.ExecuteNonQuery();
                if (result == 0)
                    throw new RepositoryException("No listener added !");
            }
        }
        public void Update(Listener l1, Listener l2)
        {
            var con = DBUtils.getConnection();
            using (var comm = con.CreateCommand())
            {
                comm.CommandText = "update Listeners set pass=@pass,firstName=@firstName,surName=@surName,email=@email where username=@username";
                var paramPass = comm.CreateParameter();
                paramPass.ParameterName = "@pass";
                paramPass.Value = l2.Password;
                comm.Parameters.Add(paramPass);

                var paramFName = comm.CreateParameter();
                paramFName.ParameterName = "@firstName";
                paramFName.Value = l2.FirstName;
                comm.Parameters.Add(paramFName);

                var paramSName = comm.CreateParameter();
                paramSName.ParameterName = "@surName";
                paramSName.Value = l2.SurName;
                comm.Parameters.Add(paramSName);

                var paramEmail = comm.CreateParameter();
                paramEmail.ParameterName = "@email";
                paramEmail.Value = l2.Password;
                comm.Parameters.Add(paramEmail);

                var paramUser = comm.CreateParameter();
                paramUser.ParameterName = "@username";
                paramUser.Value = l1.Username;
                comm.Parameters.Add(paramUser);

                var result = comm.ExecuteNonQuery();
                if (result == 0)
                    throw new RepositoryException("No listener updated !");
            }

        }
        public void Delete(string username)
        {
            var con = DBUtils.getConnection();
            using (var comm = con.CreateCommand())
            {
                comm.CommandText = "delete from Listeners where username=@username";
                var paramUser = comm.CreateParameter();
                paramUser.ParameterName = "@username";
                paramUser.Value = username;
                comm.Parameters.Add(paramUser);
                var result = comm.ExecuteNonQuery();
                if (result == 0)
                    throw new RepositoryException("No listener deleted !");
            }
        }
        public Listener GetOne(string username)
        {
            var con = DBUtils.getConnection();
            var command = (SqlCommand)con.CreateCommand();
            command.CommandText = "SELECT * FROM Listeners WHERE username = @usname";
            command.Parameters.AddWithValue("@usname", username);


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
                email = reader.GetString(4);
            }

            reader.Close();


            Listener l = new Listener(username, password, firstName, surName, email);
            return l;
        }
        public IEnumerable<Listener> GetAll()
        {
            List<Listener> listeners = new List<Listener>();
            var con = DBUtils.getConnection();
            var command = (SqlCommand)con.CreateCommand();
            command.CommandText = "SELECT * FROM Listeners";
            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                string username = reader.GetString(1);
                string password = reader.GetString(2);
                string firstName = reader.GetString(3);
                string surName = reader.GetString(4);
                string email = reader.GetString(5);
                Listener listener = new Listener(username, password, firstName, surName, email);
                listeners.Add(listener);
            }

            reader.Close();
            return listeners;
        }


    }
}
