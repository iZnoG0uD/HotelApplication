using HotelApplication.Model;
using System;
using System.Data.SqlClient;

namespace HotelApplication.Handler
{
    public class HandlerAuth : HandlerDataBase
    {
        /// <summary>
        ///     Проверяет пользователя, если он существует то входит в программу.
        /// </summary>
        public string SetIn(string login, string password)
        {
            try
            {
                Connection = new SqlConnection(StringConnction);
                Connection.Open();
                SqlRequest = "SELECT FullName FROM UserInfo WHERE Login=N'" + login + "' AND Password ='" + password + "'";
                User.FullName = RequestSql();
                if (User.FullName != null) return "Вы успешно вошли!";
                else return "Данные не верны";
            }
            catch (Exception ex)
            {
                return ex.ToString();

            }
            finally
            {
                Connection.Close();
            }
        }

        /// <summary>
        ///     Регистрирует пользователя.
        /// </summary>
        public string Register(string login, string password, string fullName, string date)
        {
            try
            {
                Connection = new SqlConnection(StringConnction);
                Connection.Open();

                SqlRequest = "SELECT Id FROM UserInfo WHERE Login=N'" + login + "'";
                string idClient = RequestSql();
                if (idClient != "") return "Такой логин уже существует";

                SqlRequest = "INSERT INTO UserInfo (FullName, Login, Password, Birthday) " +
               "VALUES (N'" + fullName + "', '" + login + "', '" + password + "', CONVERT(datetime, '" + date + "', 104))";
                Command = new SqlCommand(SqlRequest, Connection);
                Command.ExecuteNonQuery();
                return "Вы успеншо зарегались.";
            }
            catch (Exception ex)
            {
                return "Введите все данные!";
            }
            finally
            {
                Connection.Close();
            }
        }
    }
}
