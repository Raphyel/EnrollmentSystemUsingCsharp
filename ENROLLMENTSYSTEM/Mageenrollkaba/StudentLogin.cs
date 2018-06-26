using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlServerCe;
namespace Mageenrollkaba
{
    public partial class StudentLogin : Form
    {
        public StudentLogin()
        {
            InitializeComponent();
        }


        private void StudentLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(bsHRMLogin.instance))
            {
                panel1.Controls.Add(bsHRMLogin.instance);
                bsHRMLogin.instance.Dock = DockStyle.Fill;
                bsHRMLogin.instance.BringToFront();

            }
            else
                bsHRMLogin.instance.BringToFront();
       
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(bsBALogin.instance))
            {
                panel1.Controls.Add(bsBALogin.instance);
                bsBALogin.instance.Dock = DockStyle.Fill;
                bsBALogin.instance.BringToFront();

            }
            else
                bsBALogin.instance.BringToFront();
       
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(BSITLogin.instance))
            {
                panel1.Controls.Add(BSITLogin.instance);
                BSITLogin.instance.Dock = DockStyle.Fill;
                BSITLogin.instance.BringToFront();

            }
            else
                BSITLogin.instance.BringToFront();
       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to close the program?", "Exit", MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Asterisk);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialog == DialogResult.No)
            {
                login log = new login();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure do want to login as Admin? ", "ADMIN", MessageBoxButtons.YesNo,
                                                           MessageBoxIcon.Asterisk);
            if (dialog == DialogResult.Yes)
            {
                login login = new login();
                login.Show();
                this.Hide();
            }
            else if (dialog == DialogResult.No)
            {
                login log = new login();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Windows win = new Windows();
            win.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
               if (!panel1.Controls.Contains(Senior.instance))
            {
                panel1.Controls.Add(Senior.instance);
                Senior.instance.Dock = DockStyle.Fill;
                Senior.instance.BringToFront();

            }
            else
               Senior.instance.BringToFront();
       
        }
 
        
    }
}
