using System.Windows.Forms;

namespace FTP_Project
{
    internal class DragData
    {
        public string ListViewName { get; set; }
        public ListView.SelectedListViewItemCollection SelectedItems { get; set; }
    }
}