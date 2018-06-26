/*
	Authour: Ronnel Salazar Borjal
	Authour email: nielborjal@gmail.com
*/

//ENROLLMENT SYSTEM
//## How to Run/Install ??
//1. install xampp on your desktop
//2. create database sample and import database sample from folder niel
// done...

//#get more projects - www.github.com/niel111/
//#follow me on Facebook - https://www.facebook.com/NIELENOUGH
//#follow me on instagram - https://www.instagram.com/ronnelborjal/
//#For more questions please inbox me on my Email: - nielborjal@gmail.com


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mageenrollkaba
{
    public partial class ApplicationHome : Form
    {
        public ApplicationHome(string msg)
        {
            InitializeComponent();
            label1.Text = msg;
        }




        private void STUDENTS_MouseClick(object sender, MouseEventArgs e)
        {
            if (!panel1.Controls.Contains(studentRegFrm.instance))
            {
                panel1.Controls.Add(studentRegFrm.instance);
                studentRegFrm.instance.Dock = DockStyle.Fill;
                studentRegFrm.instance.BringToFront();

            }
            else
                studentRegFrm.instance.BringToFront();
        }




        private void contact_MouseClick(object sender, MouseEventArgs e)
        {

            if (!panel1.Controls.Contains(accounting.instance))
            {
                panel1.Controls.Add(accounting.instance);
                accounting.instance.Dock = DockStyle.Fill;
                accounting.instance.BringToFront();

            }
            else
                accounting.instance.BringToFront();
        }



        
        private void ADMIN_MouseClick(object sender, MouseEventArgs e)
        {

            if (!panel1.Controls.Contains(admin.instance))
            {
                panel1.Controls.Add(admin.instance);
                admin.instance.Dock = DockStyle.Fill;
                admin.instance.BringToFront();

            }
            else
                admin.instance.BringToFront();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to logout the program?", "Exit", MessageBoxButtons.YesNo,
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

        private void contact_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            label3.Text = DateTime.Now.ToLongTimeString();

        }

        private void ApplicationHome_Load(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongDateString();
            label3.Text = DateTime.Now.ToLongTimeString();

            timer1.Start();

        }

        private void ADMIN_Click(object sender, EventArgs e)
        {

        }

        private void STUDENTS_Click(object sender, EventArgs e)
        {

        }


     
    }
}
