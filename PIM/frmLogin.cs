using System.Drawing.Text;

namespace PIMVI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            frmMenu Menu = new frmMenu();
            this.Hide();
            Menu.ShowDialog();
        }
    }
}
