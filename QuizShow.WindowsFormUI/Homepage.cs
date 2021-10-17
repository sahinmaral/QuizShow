using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using QuizShow.Business.Abstract;
using QuizShow.Business.Concrete;
using QuizShow.DataAccess.Concrete.EntityFramework;
using QuizShow.Entities.Concrete;

namespace QuizShow.WindowsFormUI
{
    public partial class Homepage : Form
    {
        private readonly IUserService _userService;
        public Homepage()
        {
            _userService = new UserManager(new EfUserDal());
            InitializeComponent();
        }


        private void btnTop10_Click(object sender, EventArgs e)
        {
            List<User> users = _userService.GetAll().OrderByDescending(x=>x.Point).Take(10).ToList();

            Top10 top10Form = new Top10();
            top10Form.MdiParent = this;
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(top10Form);

            for (int j = 0; j < users.Count; j++)
            {
                Label label = new Label();
                label.AutoSize = true;
                label.Location = new Point(0, 40*(j+1));
                label.Size = new Size(127, 30);
                label.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
                label.ForeColor = Color.White;
                label.Text = users[j].Username;

                Label label2 = new Label();
                label2.AutoSize = true;
                label2.Location = new Point(350, 40 * (j + 1));
                label.Size = new Size(127, 30);
                label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
                label2.ForeColor = Color.White;
                label2.Text = users[j].Point.ToString();

                Panel panel = new Panel();
                panel.BackColor = Color.Black;
                panel.Location = new Point(0, 32 + (40 * (j+1)));
                panel.Name = "panel";
                panel.Size = new Size(544, 1);

                top10Form.Controls.Add(label);
                top10Form.Controls.Add(label2);
                top10Form.Controls.Add(panel);
            }

            top10Form.Show();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.MdiParent = this;
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(settings);
            settings.Show();
        }

        private void Homepage_Load(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                MdiClient client = control as MdiClient;
                if (client != null)
                {
                    client.BackColor = Color.FromArgb(54, 61, 92);
                    break;
                }
            }
        }

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Oyundan çıkmak istediğine emin misin ? ", "Uyarı", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
