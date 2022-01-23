using System.Data.SqlClient;

namespace HotelApplication.Handler
{
    public abstract class HandlerDataBase
    {
        /// <summary>
        ///     SqlDataReader
        /// </summary>
        private protected SqlDataReader DataReader { get; set; }

        /// <summary>
        ///     SqlCommand
        /// </summary>
        private protected SqlCommand Command { get; set; }


        /// <summary>
        ///     SqlConnection
        /// </summary>
        private protected SqlConnection Connection { get; set; }

        /// <summary>
        ///     Строка подключения.
        /// </summary>
        private protected readonly string StringConnction = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\admin\source\repos\HotelApplication\HotelApplication\Hoteldb.mdf;Integrated Security=True";

        /// <summary>
        ///     Sql запрос к базе данных для разных переменных.
        /// </summary>
        private protected string SqlRequest { get; set; }

        /// <summary>
        ///     Выполняет запрос.
        /// </summary>
        /// <returns>Переменную по запросу</returns>
        private protected string RequestSql()
        {
            string value = string.Empty;
            Command = new SqlCommand(SqlRequest, Connection);
            DataReader = Command.ExecuteReader();
            if (DataReader.Read())
                value = DataReader[0].ToString();
            DataReader.Close();
            return value;
        }
    }
}
