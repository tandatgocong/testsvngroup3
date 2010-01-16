using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listQualification_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Enter name!", "Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
            }
        }

        private void maskDate_Leave(object sender, EventArgs e)
        {
            if (maskDate.Text == " / /   ")
            {
                MessageBox.Show("Enter date of birth!", "Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                maskDate.Focus();
            }
        }

        private void txtAddress_Leave(object sender, EventArgs e)
        {
            if (txtAddress.Text == "")
            {
                MessageBox.Show("Enter address!", "Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAddress.Focus();
            }
        }

        private void cbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCountry.SelectedIndex == 0)
            {
                listCity.Items.Clear();
                listCity.Items.Add("Ha Noi");
                listCity.Items.Add("Ho Chi Minh");
                listCity.Items.Add("Buon Ma Thuot");
            }
            if (cbCountry.SelectedIndex == 1)
            {
                listCity.Items.Clear(); ;
                listCity.Items.Add("Venice  ");
                listCity.Items.Add("Florence ");
                listCity.Items.Add("Verona  ");
            }
        }

        private void cbCountry_Leave(object sender, EventArgs e)
        {
            if (cbCountry.SelectedIndex == -1)
            {
                MessageBox.Show("Enter Country","Employee",MessageBoxButtons.OK,MessageBoxIcon.Error);
                cbCountry.Focus();
            }
        }

        private void maskPhone_Leave(object sender, EventArgs e)
        {
            if (maskPhone.Text == " / ")
            {
                MessageBox.Show("Enter Phone", "Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                maskPhone.Focus();
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                MessageBox.Show("Enter Email!", "Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
            }
        }

        private void maskJoining_Leave(object sender, EventArgs e)
        {
            if (maskJoining.Text == " /  /   ")
            {
                MessageBox.Show("Enter date joining!", "Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                maskJoining.Focus();
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Are you sure :", "Employee Details", MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            Application.Exit();
        }

        private void listCity_Leave(object sender, EventArgs e)
        {
            if (listCity.SelectedIndex == -1)
            {
                MessageBox.Show("Choose city", "Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                listCity.Focus();
            }
        }

        private void listQualification_Leave(object sender, EventArgs e)
        {
            if (listQualification.SelectedIndex == -1)
            {
                MessageBox.Show("Choose qualification", "Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                listQualification.Focus();
            }
        }

        private void linkVN_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://mp3.zing.vn");
        }

        private void btSubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Employee Name :" + txtName.Text + "\nDate of Birth :" + maskDate.Text + "\nAddress :" + txtAddress.Text + "\nCity :" + listCity.SelectedItem.ToString() + "\nCountry :" + cbCountry.SelectedItem.ToString() + "\nQualification :" + listQualification.SelectedItem.ToString() + "\nPhone :" + maskPhone.Text + "\nEmail :" + txtName.Text + "\nDate of Joining :" + maskJoining.Text,"Employee Details :",MessageBoxButtons.OK,MessageBoxIcon.Information );
        }

        

        
       
    }
}
