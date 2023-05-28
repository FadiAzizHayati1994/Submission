using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Assignment_4
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void txtNN_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            coCity.Items.Clear();
            if (coCountry.Text == "Jordan")
            {
                coCity.Items.Add("Amman");
                coCity.Items.Add("Irbid");

            }
            if (coCountry.Text == "United Arab Emirates")
            {
                coCity.Items.Add("Abu Dhabi");
                coCity.Items.Add("Dubai");

            }
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string name;
            string nationalnumber;
            string gender;
            string skills = "";
            string shortDate = dateTimePicker1.Value.ToShortDateString();
            string Country = "";
            string City = "";


            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtNN.Text))
            {
                MessageBox.Show("Please enter valid data in all fields");
            }
            else
            {
                name = txtName.Text;
                nationalnumber = txtNN.Text;

                if (rbtnMale.Checked == true)
                {
                    gender = "Male";
                }
                else
                {
                    gender = "Female";
                }

                //Reading the values of check boxes
                if (chkbxProgramming.Checked == true)
                    skills += chkbxProgramming.Text + ", ";
                if (chkbxWebDesign.Checked == true)
                    skills += chkbxWebDesign.Text + ", ";
                if (chkbxUiUx.Checked == true)
                    skills += chkbxUiUx.Text + ", ";

                //Reading combobox Value

                if (coCountry.SelectedItem != null)
                    Country = coCountry.SelectedItem.ToString();
                else
                    Country = coCountry.Text;

                if (coCity.SelectedItem != null)
                    City = coCity.SelectedItem.ToString();
                else
                    City = coCity.Text;

                if ((DateTime.Now.Subtract(dateTimePicker1.Value).Days) / (365) < 22)
                    MessageBox.Show("Less than 22 Years are not qualified");
                else
                    MessageBox.Show("National number: " + nationalnumber + "\n" + "Name: " + name + "\n" + "Date: " + shortDate + "\n" + "Country: " + Country + "\n" + "City: " + City + "\n" + "Gender: " + gender + "\n" + "Skills: " + skills);

            }

        }
    }
}

