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
        public SqlDataReader DataReader { get; set; }

        /// <summary>
        ///     SqlCommand
        /// </summary>
        public SqlCommand Command { get; set; }

        /// <summary>
        ///     SqlDataAdapter
        /// </summary>
        public SqlDataAdapter DataAdapter { get; set; }

        /// <summary>
        ///     DataSet
        /// </summary>
        public DataSet DataSet { get; set; }

        /// <summary>
        ///     SqlBuider
        /// </summary>
        public SqlCommandBuilder SqlBuilder { get; set; }

        /// <summary>
        ///     SqlConnection
        /// </summary>
        public SqlConnection Connection { get; set; }

        /// <summary>
        ///     DataGridView
        /// </summary>
        public DataGridViewRow Row { get; set; }

        /// <summary>
        ///     Строка подключения.
        /// </summary>
        public readonly string StringConnction = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\heart\source\repos\HotelApplication\HotelApplication\Hoteldb.mdf;Integrated Security=True";

        /// <summary>
        ///     Sql запрос к базе данных для всех данных.
        /// </summary>
        public string SqlDataRequest { get; set; }

        /// <summary>
        ///     Sql запрос к базе данных для разных переменных.
        /// </summary>
        public string SqlRequest { get; set; }

        /// <summary>
        ///     Локальная DataGridView для заполнения ее данными.
        /// </summary>
        public DataGridView Data { get; set; }
    }
}
