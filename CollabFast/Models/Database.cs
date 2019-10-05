using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CollabFast.Models
{
    public class Database
    {

        SqlConnectionStringBuilder builder;
        SqlConnection connection;

        public void StarConnection()
        {
            try
            {
                builder = new SqlConnectionStringBuilder();
                builder.DataSource = "goldfinger.database.windows.net";
                builder.UserID = "james";
                builder.Password = "bond007&))";
                builder.InitialCatalog = "goldfinger";

                using (connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public void CloseConnection()
        {
            try
            {
                connection.Close();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public void RegisterUser(String userName, String password)
        {
            try
            {
                bool flag = false;
                int id;

                do
                {
                    Random rand = new Random();
                    id = rand.Next();
                    String sqlSearch = "Select * From goldfinger.users where userid = " + id + ";";

                    using (SqlCommand command = new SqlCommand(sqlSearch, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                flag = true;
                            }
                        }
                    }
                } while (flag);

                String sql = "Insert into goldfinger.users values (" + id + ", " + userName + ", " + password + ");";
                
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.ExecuteNonQuery();
                }
            } catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public void CreateProject(String projectName, int userId, String userName)
        {
            try
            {
                bool flag = false;
                int id;

                do
                {
                    Random rand = new Random();
                    id = rand.Next();
                    String sqlSearch = "Select * From goldfinger.projects where projectid = " + id + ";";

                    using (SqlCommand command = new SqlCommand(sqlSearch, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                flag = true;
                            }
                        }
                    }
                } while (flag);

                String sql = "Insert into goldfinger.projects values (" + id + ", " + projectName + ", " + userId + ");";
                ExecuteSQL(sql);

                sql = "Create Table goldfinger." + projectName + id + "users (userid integer, username char(50));";
                ExecuteSQL(sql);

                sql = "insert into goldfinger." + projectName + id + " values(" + userId + ", " + userName + ");";
                ExecuteSQL(sql);

                sql = "create table goldfinger." + projectName + id + "posts (postid integer, title char(50), description(5000), completed boolean, priority integer);";
                ExecuteSQL(sql);
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public void AddPost(String title, String description, int projectId, String projectName, int priority)
        {
            try
            {
                bool flag = false;
                int id;

                do
                {
                    Random rand = new Random();
                    id = rand.Next();
                    String sqlSearch = "Select * From goldfinger." + projectName + projectId + "posts where projectid = " + id + ";";

                    using (SqlCommand command = new SqlCommand(sqlSearch, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                flag = true;
                            }
                        }
                    }
                } while (flag);

                String sql = "Insert into goldfinger." + projectName + projectId + "posts values(" + id + ", " + title + ", " + description + ", false " + priority + ";";
                ExecuteSQL(sql);
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public void AddUsers(String username, int userID, String projectName, String projectID)
        {
            try
            {
                String sql = "Insert into goldfinger." + projectName + projectID + "users" + " values (" + userID + ", " + username + ");";
                ExecuteSQL(sql);
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public void ExecuteSQL(String sql)
        {
            try
            {
                SqlCommand command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}