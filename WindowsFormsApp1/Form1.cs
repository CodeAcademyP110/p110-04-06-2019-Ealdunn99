using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public class Admin
        {
            public string Username { get; set; }
            public string Password { get; set; }
        }

        Admin admin = new Admin { Username = "admin", Password = "admin" };


        private void Button1_Click(object sender, EventArgs e)
        {
           
            string password = txtPassword.Text.Trim();
            string username = txtUsername.Text.Trim();
            if (LogChecker(admin, password, username))
            {
               
                Form2 dashboard = new Form2();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                txtPassword.Text = "";
                txtUsername.Text = "";
                MessageBox.Show("Xahis edirik bir daha cehd edesiniz", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

             bool LogChecker(Admin admin, string upass, string uname)
            {
                if (admin.Username == uname && admin.Password == upass)
                {
                    return true;
                }
                return false;
            }



        }
    }
}
