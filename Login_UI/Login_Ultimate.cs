using System;
using System.Drawing;
using System.Windows.Forms;

namespace Dayli_Project.Login_UI
{
    public partial class Login_Ultimate : Form
    {
        public Login_Ultimate()
        {
            InitializeComponent();
            this.Padding = new Padding(borderSize);
            this.BackColor = Color.FromArgb(36, 37, 49);
        }

        private readonly int borderSize = 3;

        private void Btnlogin_Click(object sender, EventArgs e)
        {
            //string usu = txtuser.Text;
            //string pas = txtpass.Text;

            //Control ctrl = new Control();
            //string respuesta = ctrl.ctrlLogin(usu, pas);
            //if (respuesta.Length > 0)
            //{
            //    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else
            //{
            Login.Dayli_Menu lod = new Login.Dayli_Menu();
            this.Hide();
            lod.Show();

            //}
        }

        private void Pic_close_Click(object sender, EventArgs e)
        {
            int s = Convert.ToInt32(MessageBox.Show("¿Do you want to go out?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Hand));
            if (s == 6)
            {
                Application.Exit();
            }
            else if (s == 7)
            {
                this.Show();
            }
        }

        private void Pic_git_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/DanGosw");
        }

        private void Pic_fac_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/dangosw");
        }

        private void Pic_ins_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/dan_gosw/");
        }

        private void ViewPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (txtpass.UseSystemPasswordChar)
            {
                txtpass.UseSystemPasswordChar = false;
            }
            else
            {
                txtpass.UseSystemPasswordChar = true;
            }
        }
    }
}