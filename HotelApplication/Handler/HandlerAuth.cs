using System;
using System.Data.SqlClient;

namespace HotelApplication.Handler
{
    public class HandlerAuth : HandlerDataBase
    {
        public HandlerAuth()
        {
            Connection = new SqlConnection(StringConnction);
            Connection.Open();
        }
        
        /// <summary>
        ///     Проверяет пользователя, если он существует то входит в программу.
        /// </summary>
        public string SetIn(string login, string password)
        {
            try
            {
                SqlRequest = "SELECT Id FROM UserInfo WHERE Login=N'" + login + "'";
                string idClient = RequestSql();
                if (idClient != null) return "Вы успешно вошли!";
                else return "Данные не верны";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }


        /// <summary>
        ///     Выполняет запрос.
        /// </summary>
        /// <returns>Переменную по запросу</returns>
        private string RequestSql()
        {
            string value = string.Empty;
            Command = new SqlCommand(SqlRequest, Connection);
            DataReader = Command.ExecuteReader();
            if (DataReader.Read())
                value = DataReader[0].ToString();
            DataReader.Close();
            return value;
        }

        /// <summary>
        ///     Регистрирует пользователя.
        /// </summary>
        public string Register(string login, string password, string fullName, string date)
        {
            try
            {
                SqlRequest = "SELECT Id FROM UserInfo WHERE Login=N'" + login + "'";
                string idClient = RequestSql();
                if (idClient != "") return "Такой логин уже существует";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }

            try
            {
                SqlRequest = "INSERT INTO UserInfo (FullName, Login, Password, Birthday) " +
               "VALUES (N'" + fullName + "', '" + login + "', '" + password + "', '" + date + "')";
                Command = new SqlCommand(SqlRequest, Connection);
                Command.ExecuteNonQuery();
                return "Вы успеншо зарегались.";
            }
            catch
            {
                return "Введите все данные!";
            }

        }
    }
}
