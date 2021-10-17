using QuizShow.Business.Abstract;
using QuizShow.Business.Concrete;
using QuizShow.DataAccess.Concrete.EntityFramework;
using QuizShow.Entities.Concrete;

using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuizShow.WindowsFormUI
{
    public partial class Login : Form
    {
        private IUserService _userService;

        public Login()
        {
            _userService = new UserManager(new EfUserDal());

            InitializeComponent();
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Kullanıcı adınızı giriniz")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.Black;
            }
            
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "Kullanıcı adınızı giriniz";
                txtUsername.ForeColor = Color.White;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Şifrenizi giriniz")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.Black;
            }

        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "Şifrenizi giriniz";
                txtUsername.ForeColor = Color.White;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            User loggedUser = new User()
            {
                Username = txtUsername.Text,
                Password = txtPassword.Text
            };

            string loginStatus = _userService.Login(loggedUser);

            if (loginStatus != null)
            {
                lblError.Text = loginStatus;
            }

            else
            {
                Homepage form = new Homepage();
                form.lblUsername.Text = loggedUser.Username;
                this.Hide();
                form.ShowDialog();

            }
        }

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
