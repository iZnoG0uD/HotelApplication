using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace HotelApplication.Handler
{
    public class HandlerOrder : HandlerDataBase
    {
        /// <summary>
        ///     Бронирует комнату.
        /// </summary>
        /// <param name="fullName">полное имя (ФИО)</param>
        /// <param name="room">номер комнаты</param>
        /// <param name="dateBook">дата бронирования</param>
        /// <returns>успешно или нет</returns>
        public string BookRoom(string fullName, string room, string dateBook)
        {
            try
            {
                Connection = new SqlConnection(StringConnction);
                Connection.Open();

                SqlRequest = "SELECT Id FROM UserInfo WHERE FullName=N'" + fullName + "'";
                string idUser = RequestSql();
                if (idUser == "") return "Не верно указано ФИО";

                SqlRequest = "SELECT Id FROM RoomInfo WHERE RoomNumber=N'" + room + "'";
                string idRoom = RequestSql();
                if (idRoom == "") return "Не верно указано комната";

                SqlRequest = "INSERT INTO OrderInfo (IdCustomer, IdRoom, BookDate) " +
               "VALUES (" + idUser + ", " + idRoom + ", CONVERT(datetime, '" + dateBook + "', 104))";
                Command = new SqlCommand(SqlRequest, Connection);
                Command.ExecuteNonQuery();
                return "Вы успеншо забронировали.";
            }
            catch
            {
                return "Введите все данные!";
            }
            finally
            {
                Connection.Close();
            }
        }

        /// <summary>
        ///     Получаем все комнаты.
        /// </summary>
        /// <returns>все комнаты</returns>
        /// <exception cref="Exception">Ошибки при выполнение запроса</exception>
        public List<string[]> GetAllRooms()
        {
            List<string[]> rooms = new List<string[]>();

            try
            {
                Connection = new SqlConnection(StringConnction);
                Connection.Open();

                SqlRequest = "select RoomInfo.Id, RoomInfo.RoomNumber, RoomInfo.Quality From RoomInfo";
                Command = new SqlCommand(SqlRequest, Connection);
                DataReader = Command.ExecuteReader();

                while (DataReader.Read())
                {
                    rooms.Add(new string[3]);

                    rooms[rooms.Count - 1][0] = DataReader[0].ToString();
                    rooms[rooms.Count - 1][1] = DataReader[1].ToString();
                    rooms[rooms.Count - 1][2] = DataReader[2].ToString();
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

            return rooms;
        }
    }
}
