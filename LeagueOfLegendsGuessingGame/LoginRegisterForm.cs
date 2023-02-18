using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeagueOfLegendsGuessingGame
{
    public partial class LoginRegisterForm : Form
    {
        LoginRegisterController loginRegisterController=new LoginRegisterController();
        public LoginRegisterForm()
        {
            InitializeComponent();
            loginRegisterController.SetCurrentForm(this);
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            loginRegisterController.Login(usernameLoginTB.Text,passwordLoginTB.Text);
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            loginRegisterController.Register(usernameRegisterTB.Text,passwordRegisterTB.Text);
        }
    }
}
