using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Assigment_3_Laila_Nofal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void my_event_handler(object sender,EventArgs e)
        {
            txtScreen.Text = ((System.Windows.Forms.Button)sender).Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn1.Click += new EventHandler(my_event_handler);
            btn2.Click += new EventHandler(my_event_handler);
            btn3.Click += new EventHandler(my_event_handler);
            btn4.Click += new EventHandler(my_event_handler);   
            btn5.Click += new EventHandler(my_event_handler);
            btn6.Click += new EventHandler(my_event_handler);
            btn7.Click += new EventHandler(my_event_handler);
            btn8.Click += new EventHandler(my_event_handler);
            btn9.Click += new EventHandler(my_event_handler);
            btn0.Click += new EventHandler(my_event_handler);
            btn11.Click += new EventHandler(my_event_handler);
            btn12.Click += new EventHandler(my_event_handler);
            btn13.Click += new EventHandler(my_event_handler);
            btn14.Click += new EventHandler(my_event_handler);
            btn15.Click += new EventHandler(my_event_handler);
        }

        private void bc_Click(object sender, EventArgs e)
        {
            txtScreen.Text = "0";
        }
    }
}
