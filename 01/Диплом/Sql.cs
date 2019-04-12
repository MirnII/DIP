using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Диплом
{
    class Sql
    {
        string Sql_ = ConfigurationManager.ConnectionStrings["SQL"].ConnectionString;
        public string Login { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Roly { get; set; }
        
        int status_cod = 0;
        string answer;
        
        public int Authorization ()
        {
            SqlConnection connect = new SqlConnection(Sql_);
            connect.Open();
            SqlCommand command = new SqlCommand("Select * from Users", connect);
            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                if(Login == reader["Логин"].ToString() && Password == reader["Пароль"].ToString())
                {
                    Name = reader["Имя"].ToString();
                    Roly = reader["Роль"].ToString();
                    status_cod = 1;
                    reader.Close();
                    break;
                }
                else
                {
                    status_cod = 1111;
                }
            }
            return status_cod;
        }
        
        public string Register(Registration r)
        {
            Login = r.Login.Text;
            Password = r.Password.Password;
            Name = r.Name.Text;
            Roly = "Сотрудник";
            SqlConnection connect = new SqlConnection(Sql_);
            connect.Open();
            SqlCommand command = new SqlCommand("Insert into Users(Логин, Пароль, Имя, Роль) values('" + Login + "', '" + Password + "', '" + Name + "', '" + Roly + "')", connect);
            int number = command.ExecuteNonQuery();
            if(number == 1)
            {
                answer =  "succesfull";
                
            }
            else
            {
                answer = "error";
            }
            return answer;
            
        }

        public void Register(string login, string password)
        {
            Login = login;
            Password = password;   
            
        }
    }
}