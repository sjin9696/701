using System;
using System.Windows.Forms;

namespace xmlDataManager
{
    public partial class Form4_all_inventory_screen : Form
    {
        public Form4_all_inventory_screen()
        {
            InitializeComponent();
            dataGridView_all_incentory.DataSource = xmlDataManager.ProductsList;
        }

        private void dataGridView_all_incentory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine(sender.ToString());
        }
    }
}
