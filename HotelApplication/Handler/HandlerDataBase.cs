using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

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
        ///     SqlDataAdapter
        /// </summary>
        private protected SqlDataAdapter DataAdapter { get; set; }

        /// <summary>
        ///     DataSet
        /// </summary>
        private protected DataSet DataSet { get; set; }

        /// <summary>
        ///     SqlBuider
        /// </summary>
        private protected SqlCommandBuilder SqlBuilder { get; set; }

        /// <summary>
        ///     SqlConnection
        /// </summary>
        private protected SqlConnection Connection { get; set; }

        /// <summary>
        ///     DataGridView
        /// </summary>
        private protected DataGridViewRow Row { get; set; }

        /// <summary>
        ///     Строка подключения.
        /// </summary>
        private protected readonly string StringConnction = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\heart\source\repos\HotelApplication\HotelApplication\Hoteldb.mdf;Integrated Security=True";

        /// <summary>
        ///     Sql запрос к базе данных для разных переменных.
        /// </summary>
        private protected string SqlRequest { get; set; }

        /// <summary>
        ///     Локальная DataGridView для заполнения ее данными.
        /// </summary>
        private protected DataGridView Data { get; set; }


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
