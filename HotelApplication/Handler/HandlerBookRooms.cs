using HotelApplication.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace HotelApplication.Handler
{
    public class HandlerBookRooms : HandlerDataBase
    {
        /// <summary>
        ///     Получает все заказы, которые имеют силу.
        /// </summary>
        public List<string[]> GetBookRooms()
        {
            List<string[]> listRoomsBook = new List<string[]>();

            try
            {
                Connection = new SqlConnection(StringConnction);
                Connection.Open();

                SqlRequest = "select UserInfo.FullName, RoomInfo.RoomNumber, RoomInfo.Quality, OrderInfo.BookDate From OrderInfo " +
                           "inner join UserInfo on OrderInfo.IdCustomer = UserInfo.Id AND UserInfo.FullName = N'" + User.FullName + "' " +
                           "inner join RoomInfo on OrderInfo.IdRoom = RoomInfo.Id " +
                           "WHere OrderInfo.BookDate > GETDATE()";

                Command = new SqlCommand(SqlRequest, Connection);
                DataReader = Command.ExecuteReader();

                while (DataReader.Read())
                {
                    listRoomsBook.Add(new string[4]);

                    listRoomsBook[listRoomsBook.Count - 1][0] = DataReader[0].ToString();
                    listRoomsBook[listRoomsBook.Count - 1][1] = DataReader[1].ToString();
                    listRoomsBook[listRoomsBook.Count - 1][2] = DataReader[2].ToString();
                    listRoomsBook[listRoomsBook.Count - 1][3] = DataReader[3].ToString();
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

            return listRoomsBook;
        }
    }
}
