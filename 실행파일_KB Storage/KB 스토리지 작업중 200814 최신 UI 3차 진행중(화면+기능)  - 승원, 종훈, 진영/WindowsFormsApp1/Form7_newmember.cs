using System.Windows.Forms;

namespace xmlDataManager
{
    public partial class Form7_newmember : Form
    {
        public Form7_newmember()
        {
            InitializeComponent();
            newmember();
            System.Console.WriteLine("Form7_newmember");
        }
        private void newmember()
        {
            System.Console.WriteLine(userDataManager.UserInfos[0].ID);
            foreach(var item in userDataManager.UserInfos)
            {
                System.Console.WriteLine(item.ID);
                System.Console.WriteLine(item.PW);
            }
            dataGridView1.DataSource = userDataManager.UserInfos;
        }
    }
}
