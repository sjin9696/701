using System.Windows.Forms;

namespace Storagy
{
    public partial class Form8_Reform : Form
    {
        public Form8_Reform()
        {
            InitializeComponent();
            dataGridView1.DataSource = new mssqlDataManager().ConnectDB().Tables[0];
        }
    }
}
