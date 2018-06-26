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
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mageenrollkaba
{
    public partial class studentRegFrm : UserControl
    {
        public static studentRegFrm _instance;
        public static studentRegFrm instance
        {
            get
            {
                if (_instance == null)
                    _instance = new studentRegFrm();
                return _instance;
            }

        }

        public studentRegFrm()
        {
            InitializeComponent();
        }

        private void bsba_MouseClick(object sender, MouseEventArgs e)
        {

            if (!panel1.Controls.Contains(regbsba.instance))
            {
                panel1.Controls.Add(regbsba.instance);
                regbsba.instance.Dock = DockStyle.Fill;
                regbsba.instance.BringToFront();

            }
            else
                regbsba.instance.BringToFront();
        }

        private void bshrm_MouseClick(object sender, MouseEventArgs e)
        {

            if (!panel1.Controls.Contains(reghrm.instance))
            {
                panel1.Controls.Add(reghrm.instance);
                reghrm.instance.Dock = DockStyle.Fill;
                reghrm.instance.BringToFront();

            }
            else
                reghrm.instance.BringToFront();
        }

        private void bsit_MouseClick(object sender, MouseEventArgs e)
        {

            if (!panel1.Controls.Contains(regbsit.instance))
            {
                panel1.Controls.Add(regbsit.instance);
                regbsit.instance.Dock = DockStyle.Fill;
                regbsit.instance.BringToFront();

            }
            else
                regbsit.instance.BringToFront();
        }

        private void admin_MouseClick(object sender, MouseEventArgs e)
        {
            
            if (!panel1.Controls.Contains(regbsit.instance))
            {
                panel1.Controls.Add(regbsit.instance);
                regbsit.instance.Dock = DockStyle.Fill;
                regbsit.instance.BringToFront();

            }
            else
                regbsit.instance.BringToFront();
        }

        private void New_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Coming soon");
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void studentRegFrm_Load(object sender, EventArgs e)
        {
         }

        private void timer1_Tick(object sender, EventArgs e)
        {
         }

        private void New_Click(object sender, EventArgs e)
        {

            if (!panel1.Controls.Contains(@new.instance))
            {
                panel1.Controls.Add(@new.instance);
                @new.instance.Dock = DockStyle.Fill;
                @new.instance.BringToFront();

            }
            else
                @new.instance.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!panel1.Controls.Contains(NewStudents.instance))
            {
                panel1.Controls.Add(NewStudents.instance);
                NewStudents.instance.Dock = DockStyle.Fill;
                NewStudents.instance.BringToFront();

            }
            else
                NewStudents.instance.BringToFront();
        }
    }
}
