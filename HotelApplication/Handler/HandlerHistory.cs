using HotelApplication.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace HotelApplication.Handler
{
    public class HandlerHistory : HandlerDataBase
    {
        /// <summary>
        ///     Получает историю заказов.
        /// </summary>
        public List<string[]> GetHistory()
        {
            List<string[]> history = new List<string[]>();

            try
            {
                Connection = new SqlConnection(StringConnction);
                Connection.Open();

                SqlRequest = "select UserInfo.FullName, RoomInfo.RoomNumber, RoomInfo.Quality, OrderInfo.BookDate From OrderInfo " +
                           "inner join UserInfo on OrderInfo.IdCustomer = UserInfo.Id AND UserInfo.FullName = N'" + User.FullName + "' " +
                           "inner join RoomInfo on OrderInfo.IdRoom = RoomInfo.Id";

                Command = new SqlCommand(SqlRequest, Connection);
                DataReader = Command.ExecuteReader();

                while (DataReader.Read())
                {
                    history.Add(new string[4]);

                    history[history.Count - 1][0] = DataReader[0].ToString();
                    history[history.Count - 1][1] = DataReader[1].ToString();
                    history[history.Count - 1][2] = DataReader[2].ToString();
                    history[history.Count - 1][3] = DataReader[3].ToString();
                }
                DataReader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                Connection.Close();
            }

            return history;
        }
    }
}
