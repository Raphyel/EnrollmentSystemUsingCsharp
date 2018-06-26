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
    public partial class Windows : Form
    {
        public Windows()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void home_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(Home.instance))
            {
                home_panel.Controls.Add(Home.instance);
                Home.instance.Dock = DockStyle.Fill;
                Home.instance.BringToFront();

            }
            else
                Home.instance.BringToFront();
       
        }

        private void about_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(About.instance))
            {
                home_panel.Controls.Add(About.instance);
               About.instance.Dock = DockStyle.Fill;
               About.instance.BringToFront();

            }
            else
                About.instance.BringToFront();
       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(About.instance))
            {
                home_panel.Controls.Add(About.instance);
                About.instance.Dock = DockStyle.Fill;
                About.instance.BringToFront();

            }
            else
                About.instance.BringToFront();
       
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            login log = new login();
            log.Show();
            this.Hide();
        }

        private void event_btn_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(Event.instance))
            {
                home_panel.Controls.Add(Event.instance);
                Event.instance.Dock = DockStyle.Fill;
                Event.instance.BringToFront();

            }
            else
                Event.instance.BringToFront();
       
        }

        private void enroll_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(studentRegFrm.instance))
            {
                home_panel.Controls.Add(studentRegFrm.instance);
                studentRegFrm.instance.Dock = DockStyle.Fill;
                studentRegFrm.instance.BringToFront();

            }
            else
                studentRegFrm.instance.BringToFront();
       
        }

        private void send_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(Send.instance))
            {
                home_panel.Controls.Add(Send.instance);
                Send.instance.Dock = DockStyle.Fill;
                Send.instance.BringToFront();

            }
            else
                Send.instance.BringToFront();
       
        }

        private void Windows_Load(object sender, EventArgs e)
        {
            label7.Text = DateTime.Now.ToLongTimeString();
            label8.Text = DateTime.Now.ToLongDateString();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label7.Text = DateTime.Now.ToLongTimeString();

        }
    }
}
