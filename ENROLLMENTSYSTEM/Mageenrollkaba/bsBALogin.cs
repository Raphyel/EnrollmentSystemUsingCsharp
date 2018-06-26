using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Mageenrollkaba
{
    public partial class bsBALogin : UserControl
    {
        public static bsBALogin _instance;
        public static bsBALogin instance
        {
            get
            {
                if (_instance == null)
                    _instance = new bsBALogin();
                return _instance;
            }

        }
  

        public bsBALogin()
        {
            InitializeComponent();
        }

        MySqlConnection con = new MySqlConnection("data source=localhost; port=3306; database=pinakaiingatan; username=root; password=;");
        MySqlDataAdapter adapter;
        MySqlCommand command;


        string msg;
        private void button2_Click(object sender, EventArgs e)
        {

            command = new MySqlCommand("Select * FROM tblbsba WHERE student_id='" + textBox1.Text + "'  ", con);
            adapter = new MySqlDataAdapter(command);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            int i = ds.Tables[0].Rows.Count;
            if (i == 1)
            {
                msg = "welcome  " + textBox1.Text;
                BSBAStudent BBS = new BSBAStudent (msg);
                 BBS.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error : ' You have entered an Invalid Username or Password! '", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
