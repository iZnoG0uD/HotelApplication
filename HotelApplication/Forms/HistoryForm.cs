using HotelApplication.Handler;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HotelApplication.Forms
{
    public partial class HistoryForm : Form
    {
        public HistoryForm()
        {
            InitializeComponent();
            SetHistory();
        }

        /// <summary>
        ///     Вставляет всю историю.
        /// </summary>
        public void SetHistory()
        {
            HandlerHistory handlerHistory = new HandlerHistory();
            List<string[]> history = handlerHistory.GetHistory();
            foreach (var historyItem in history)
                dataGridView1.Rows.Add(historyItem);
        }
    }
}
