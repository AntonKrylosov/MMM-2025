using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;

namespace PRAEKT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, EventArgs e)
        {
            LoginForm loginform = new LoginForm();
            loginform.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }

    public class User
    {
        public int Id { get; set; } // PK
        public string Username { get; set; }
        public string Password { get; set; }

        public DbSet<User> Users { get; set; }
    }
    public partial class LoginForm : Form
    {
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button AuthenticateUser;
        private Button VerifyPassword;
        }
    }