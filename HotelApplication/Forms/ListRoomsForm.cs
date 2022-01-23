using HotelApplication.Handler;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HotelApplication.Forms
{
    public partial class ListRoomsForm : Form
    {
        public ListRoomsForm()
        {
            InitializeComponent();
            SetBookRooms();
        }

        /// <summary>
        ///     Получает все бронированые номера, которые еще в заказе.
        /// </summary>
        public void SetBookRooms()
        {
            HandlerBookRooms handlerBookRooms = new HandlerBookRooms();
            List<string[]> bookRooms = handlerBookRooms.GetBookRooms();
            foreach (var bookRoomsItem in bookRooms)
                dataGridView1.Rows.Add(bookRoomsItem);
        }
    }
}
