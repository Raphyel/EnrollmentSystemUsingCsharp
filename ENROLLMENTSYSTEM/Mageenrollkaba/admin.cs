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
using System.Data.SqlServerCe;
using MySql.Data.MySqlClient;

namespace Mageenrollkaba
{
    public partial class admin : UserControl
    {
        
        public static admin _instance;
        public static admin instance
        {
            get
            {
                if (_instance == null)
                    _instance = new admin();
                return _instance;
            }

        }

        public admin()
        {
            InitializeComponent();
        }
        
        
        private void bsba_Click(object sender, EventArgs e)
        {
              if (!panel1.Controls.Contains(adminbsba.instance))
            {
                panel1.Controls.Add(adminbsba.instance);
                adminbsba.instance.Dock = DockStyle.Fill;
                adminbsba.instance.BringToFront();

            }
            else
                adminbsba.instance.BringToFront();
        }

        private void bshrm_Click(object sender, EventArgs e)
        {

            if (!panel1.Controls.Contains(adminhrm.instance))
            {
                panel1.Controls.Add(adminhrm.instance);
                adminhrm.instance.Dock = DockStyle.Fill;
                adminhrm.instance.BringToFront();

            }
            else
                adminhrm.instance.BringToFront();
        }

        private void bsit_Click(object sender, EventArgs e)
        {

            if (!panel1.Controls.Contains(adminbsit.instance))
            {
                panel1.Controls.Add(adminbsit.instance);
                adminbsit.instance.Dock = DockStyle.Fill;
                adminbsit.instance.BringToFront();

            }
            else
                adminbsit.instance.BringToFront();
        }

        
        
    

        
    }
}

