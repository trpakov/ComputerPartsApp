using System;
using System.Windows.Forms;
using UsernameAndPasswordLibrary;


namespace ComputerPartsApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(AdminLogin.Check(txtBoxUser.Text, AdminLogin.Field.Username) && AdminLogin.Check(txtBoxPass.Text, AdminLogin.Field.Password))
            {
                DialogResult = DialogResult.Yes;
                Close();
            }
            else
            {
                MessageBox.Show("Грешно потребителско име и/или парола. Моля, опитайте отново.", "Достъп отказан", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
