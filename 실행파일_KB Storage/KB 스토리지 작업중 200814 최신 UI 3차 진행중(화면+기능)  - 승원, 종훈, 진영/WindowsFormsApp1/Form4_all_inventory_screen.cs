using System;
using System.Windows.Forms;

namespace Storagy
{
    public partial class Form4_all_inventory_screen : Form
    {
        public Form4_all_inventory_screen()
        {
            InitializeComponent();
            mssqlDataManager ms = new mssqlDataManager();
            dataGridView1.DataSource = ms.ConnectDB().Tables[0];
        }

        private void dataGridView_all_incentory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine(sender.ToString());
        }
    }
}
