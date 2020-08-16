using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xmlDataManager
{
    public partial class Form4_all_inventory_screen : Form
    {
        public Form4_all_inventory_screen()
        {
            InitializeComponent();
            dataGridView_all_incentory.DataSource = xmlDataManager.Products;
            //전체재고 기능 완료. 
        }

        private void dataGridView_all_incentory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine(sender.ToString());
        }

        private void dataGridView_all_incentory_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
        }

        private void dataGridView_all_incentory_ColumnSortModeChanged(object sender, DataGridViewColumnEventArgs e)
        {
        }
    }
}
