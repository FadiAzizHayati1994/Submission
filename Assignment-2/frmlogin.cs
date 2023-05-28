using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assigment_2_Laila_Nofal
{
    public partial class frmlogin : Form
    {
        private List<User> users;
        private User user1 = new User();
        private User user2 = new User();
        private User user3 = new User();
        private User user4 = new User();
      
        public frmlogin()
        {
            InitializeComponent();

            users = new List<User>();
            users.Add(user1);
            users.Add(user2);
            users.Add(user3);
            users.Add(user4);
           
        }

        private void frmlogin_Load(object sender, EventArgs e)
        {
            user1.UserId = 1;
            user1.FullName = "Laila Osama";
            user1.UserName = "LO";
            user1.Password = "0001";

            user2.UserId = 2;
            user2.FullName = "Mariam Mohammad";
            user2.UserName = "MM";
            user2.Password = "0002";

            user3.UserId = 3;
            user3.FullName = "Leen Ali";
            user3.UserName = "LA";
            user3.Password = "0003";

            user4.UserId = 4;
            user4.FullName = "Razan Jamil";
            user4.UserName = "RJ";
            user4.Password = "0004";

          
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (user1.UserName == txtUsername.Text)
            {
                if (user1.UserName == txtUsername.Text && user1.Password == txtPassword.Text)
                {
                    MessageBox.Show("Welcome " + user1.FullName);
                }
                else if (user1.Password != txtPassword.Text)
                {
                    MessageBox.Show("Worng password");
                }
            }
            else if (user2.UserName == txtUsername.Text)
            {
                if (user2.UserName == txtUsername.Text && user2.Password == txtPassword.Text)
                {
                    MessageBox.Show("Welcome " + user2.FullName);
                }
                else if (user2.Password != txtPassword.Text)
                {
                    MessageBox.Show("Worng password");
                }
            }
            else if (user3.UserName == txtUsername.Text)
            {
                if (user3.UserName == txtUsername.Text && user3.Password == txtPassword.Text)
                {
                    MessageBox.Show("Welcome " + user3.FullName);
                }
                else if (user3.Password != txtPassword.Text)
                {
                    MessageBox.Show("Worng password");
                }
            }
            else if (user4.UserName == txtUsername.Text)
            {
                if (user4.UserName == txtUsername.Text && user4.Password == txtPassword.Text)
                {
                    MessageBox.Show("Welcome " + user4.FullName);
                }
                else if (user4.Password != txtPassword.Text)
                {
                    MessageBox.Show("Worng password");
                }
                    
                }
            else
                    {
                        MessageBox.Show("User does not exit");
                    }

            }

        }
    }
