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

namespace Mageenrollkaba
{
    public partial class BSITStudent : Form
    {
        public BSITStudent(string msg)
        {
            InitializeComponent();
            label1.Text = msg;
        }

        MySqlConnection connection = new MySqlConnection("data source=localhost; port=3306; database='pinakaiingatan'; username=root; password=;");
        private void BSITStudent_Load(object sender, EventArgs e)
        {
           
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void find_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM tblaccounting WHERE ID=@id ", connection);
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id.Text;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            if (table.Rows.Count <= 0)
            {
                MessageBox.Show("No data found... Please Update your fees");
                clearfield();

            }
            else
            {
                id.Text = table.Rows[0][0].ToString();
                name.Text = table.Rows[0][1].ToString();
                course.Text = table.Rows[0][2].ToString();
                section.Text = table.Rows[0][3].ToString();
                year.Text = table.Rows[0][4].ToString();
                tuition.Text = table.Rows[0][5].ToString();
                code.Text = table.Rows[0][6].ToString();
                promo.Text = table.Rows[0][7].ToString();
                fees.Text = table.Rows[0][8].ToString();
                payment.Text = table.Rows[0][9].ToString();
                total.Text = table.Rows[0][10].ToString();
             }

        }
        public void clearfield()
        {
            id.Text = "";
            name.Text = "";
            course.Text = "";
            section.Text = "";
            year.Text = "";
            tuition.Text = "";
            code.Text = "";
            promo.Text = "";
            fees.Text = "";
            payment.Text = "";
            total.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            id.Text = "";
            name.Text = "";
            course.Text = "";
            section.Text = "";
            year.Text = "";
            tuition.Text = "";
            code.Text = "";
            promo.Text = "";
            fees.Text = "";
            payment.Text = "";
            total.Text = "";

        }

        private void id_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
