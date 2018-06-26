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
using System.Data.SqlServerCe;
using MySql.Data.MySqlClient;

namespace Mageenrollkaba
{
    public partial class login : Form
    {

        SqlCeConnection con = new SqlCeConnection(Properties.Settings.Default.loginDBConnectionString);
        SqlCeDataAdapter adapter;
        SqlCeCommand command;
        public login()
        {
            InitializeComponent();
        }
        string msg;
        private void LOGIN(object sender, MouseEventArgs e)
        {
            command = new SqlCeCommand("Select * FROM TblAdmin WHERE UserName='" + textBox1.Text + "' and Password='" + textBox2.Text + "' ", con);
            adapter = new SqlCeDataAdapter(command);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            int i = ds.Tables[0].Rows.Count;
            if (i == 1)
            {
                msg = "Welcome  " + textBox1.Text;
                ApplicationHome ah = new ApplicationHome(msg);
                ah.Show();
                this.Hide();
                MessageBox.Show("Welcome Admin!");

            }
            else
            {
                MessageBox.Show("Error : ' You have entered an Invalid Username or Password! '", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            StudentLogin SL = new StudentLogin();
            SL.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
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
    }
}
