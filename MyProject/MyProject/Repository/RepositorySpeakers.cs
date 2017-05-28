using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repository
{
    class RepositorySpeakers : IRepository<string, Speaker>
    {

        public RepositorySpeakers()
        {

        }

        public void Save(Speaker s)
        {
            var con = DBUtils.getConnection();
            using (var comm = con.CreateCommand())
            {
                comm.CommandText = "insert into Speakers(username,pass,firstName,surName,email) values (@username,@pass,@firstName,@surName,@email); ";
                var paramUser = comm.CreateParameter();
                paramUser.ParameterName = "@username";
                paramUser.Value = s.Username;
                comm.Parameters.Add(paramUser);

                var paramPass = comm.CreateParameter();
                paramPass.ParameterName = "@pass";
                paramPass.Value = s.Password;
                comm.Parameters.Add(paramPass);

                var paramFName = comm.CreateParameter();
                paramFName.ParameterName = "@firstName";
                paramFName.Value = s.FirstName;
                comm.Parameters.Add(paramFName);

                var paramSName = comm.CreateParameter();
                paramSName.ParameterName = "@surName";
                paramSName.Value = s.SurName;
                comm.Parameters.Add(paramSName);

                var paramEmail = comm.CreateParameter();
                paramEmail.ParameterName = "@email";
                paramEmail.Value = s.Password;
                comm.Parameters.Add(paramEmail);

                var result = comm.ExecuteNonQuery();
                if (result == 0)
                    throw new RepositoryException("No speaker added !");
            }
        }

        public void Update(Speaker s1, Speaker s2)
        {
            var con = DBUtils.getConnection();
            using (var comm = con.CreateCommand())
            {
                comm.CommandText = "update Speakers set pass=@pass,firstName=@firstName,surName=@surName,email=@email where username=@username";
                var paramPass = comm.CreateParameter();
                paramPass.ParameterName = "@pass";
                paramPass.Value = s2.Password;
                comm.Parameters.Add(paramPass);

                var paramFName = comm.CreateParameter();
                paramFName.ParameterName = "@firstName";
                paramFName.Value = s2.FirstName;
                comm.Parameters.Add(paramFName);

                var paramSName = comm.CreateParameter();
                paramSName.ParameterName = "@surName";
                paramSName.Value = s2.SurName;
                comm.Parameters.Add(paramSName);

                var paramEmail = comm.CreateParameter();
                paramEmail.ParameterName = "@email";
                paramEmail.Value = s2.Password;
                comm.Parameters.Add(paramEmail);

                var paramUser = comm.CreateParameter();
                paramUser.ParameterName = "@username";
                paramUser.Value = s1.Username;
                comm.Parameters.Add(paramUser);

                var result = comm.ExecuteNonQuery();
                if (result == 0)
                    throw new RepositoryException("No speaker updated !");
            }

        }
        public void Delete(string username)
        {
            var con = DBUtils.getConnection();
            using (var comm = con.CreateCommand())
            {
                comm.CommandText = "delete from Speakers where username=@username";
                var paramUser = comm.CreateParameter();
                paramUser.ParameterName = "@username";
                paramUser.Value = username;
                comm.Parameters.Add(paramUser);
                var result = comm.ExecuteNonQuery();
                if (result == 0)
                    throw new RepositoryException("No speaker deleted !");
            }
        }
        public Speaker GetOne(string username)
        {
            var con = DBUtils.getConnection();
            var command = (SqlCommand)con.CreateCommand();
            command.CommandText = "SELECT * FROM Speakers WHERE username = @usname";
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


            Speaker s = new Speaker(username, password, firstName, surName, email);
            return s;
        }
        public IEnumerable<Speaker> GetAll()
        {
            List<Speaker> speakers = new List<Speaker>();
            var con = DBUtils.getConnection();
            var command = (SqlCommand)con.CreateCommand();
            command.CommandText = "SELECT * FROM Speakers";
            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                string username = reader.GetString(1);
                string password = reader.GetString(2);
                string firstName = reader.GetString(3);
                string surName = reader.GetString(4);
                string email = reader.GetString(5);
                Speaker speaker = new Speaker(username, password, firstName, surName, email);
                speakers.Add(speaker);
            }

            reader.Close();
            return speakers;
        }


    }
}