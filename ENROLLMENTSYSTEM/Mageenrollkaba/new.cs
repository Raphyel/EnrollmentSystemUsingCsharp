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
using System.IO;

namespace Mageenrollkaba
{
    public partial class @new : UserControl
    {

        public static @new _instance;
        public static @new instance
        {
            get
            {
                if (_instance == null)
                    _instance = new @new();
                return _instance;
            }

        }

        public @new()
        {
            InitializeComponent();
        }

        private void fetch_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("data source=localhost; port=3306; database=pinakaiingatan; username=root; password=;");
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM `tblbsit` ", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.Rows.Clear();
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.White;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

              foreach(DataRow item in table.Rows)
              {
                  int n = dataGridView1.Rows.Add();
                  dataGridView1.Rows[n].Cells[0].Value = false;
                  dataGridView1.Rows[n].Cells[1].Value = item["Student_id"].ToString();
                  dataGridView1.Rows[n].Cells[2].Value = item["Name"].ToString();
                  dataGridView1.Rows[n].Cells[3].Value = item["Course"].ToString();
                  dataGridView1.Rows[n].Cells[4].Value = item["Year"].ToString();
                  dataGridView1.Rows[n].Cells[5].Value = item["Section"].ToString();
                  dataGridView1.Rows[n].Cells[6].Value = item["Session"].ToString();
                  dataGridView1.Rows[n].Cells[7].Value = item["Gender"].ToString();
                  dataGridView1.Rows[n].Cells[8].Value = item["Email"].ToString();
                  dataGridView1.Rows[n].Cells[9].Value = item["Contact"].ToString(); 
                  dataGridView1.Rows[n].Cells[10].Value = item["Status"].ToString();
                  dataGridView1.Rows[n].Cells[11].Value = item["Emercontact"].ToString();
                  dataGridView1.Rows[n].Cells[12].Value = item["Address"].ToString();
                  dataGridView1.Rows[n].Cells[13].Value = item["Branch"].ToString();
                  dataGridView1.Rows[n].Cells[14].Value = item["Code"].ToString();
                  dataGridView1.Rows[n].Cells[15].Value = item["Payment"].ToString();
              }

        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {



            if ((bool)dataGridView1.SelectedRows[0].Cells[0].Value == false)
            {
                dataGridView1.SelectedRows[0].Cells[0].Value = true;
                dataGridView1.BorderStyle = BorderStyle.None;
                dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
                dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
                dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
                dataGridView1.BackgroundColor = Color.White;

                dataGridView1.EnableHeadersVisualStyles = false;
                dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
                dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        
            }
            else
            {
                dataGridView1.BorderStyle = BorderStyle.None;
                dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
                dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
                dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
                dataGridView1.BackgroundColor = Color.White;

                dataGridView1.EnableHeadersVisualStyles = false;
                dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
                dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

                dataGridView1.SelectedRows[0].Cells[0].Value = false;
                
            }
        }

        private void copy_Click(object sender, EventArgs e)
        {
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView2.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView2.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView2.BackgroundColor = Color.White;

            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dataGridView2.Rows.Clear();

                    foreach (DataGridViewRow item in dataGridView1.Rows)
                    {
                        if ((bool)item.Cells[0].Value == true)
                        {
                            int n = dataGridView2.Rows.Add();
                            dataGridView2.BorderStyle = BorderStyle.None;
                            dataGridView2.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
                            dataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                            dataGridView2.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
                            dataGridView2.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
                            dataGridView2.BackgroundColor = Color.White;

                            dataGridView2.EnableHeadersVisualStyles = false;
                            dataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                            dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
                            dataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

                            dataGridView2.Rows[n].Cells[0].Value = item.Cells[1].Value.ToString();
                            dataGridView2.Rows[n].Cells[1].Value = item.Cells[2].Value.ToString();
                            dataGridView2.Rows[n].Cells[2].Value = item.Cells[3].Value.ToString();
                            dataGridView2.Rows[n].Cells[3].Value = item.Cells[4].Value.ToString();
                            dataGridView2.Rows[n].Cells[4].Value = item.Cells[5].Value.ToString();
                            dataGridView2.Rows[n].Cells[5].Value = item.Cells[6].Value.ToString();
                            dataGridView2.Rows[n].Cells[6].Value = item.Cells[7].Value.ToString();
                            dataGridView2.Rows[n].Cells[7].Value = item.Cells[8].Value.ToString();
                            dataGridView2.Rows[n].Cells[8].Value = item.Cells[9].Value.ToString();
                            dataGridView2.Rows[n].Cells[9].Value = item.Cells[10].Value.ToString();
                            dataGridView2.Rows[n].Cells[10].Value = item.Cells[11].Value.ToString();
                            dataGridView2.Rows[n].Cells[11].Value = item.Cells[12].Value.ToString();
                            dataGridView2.Rows[n].Cells[12].Value = item.Cells[13].Value.ToString();
                            dataGridView2.Rows[n].Cells[13].Value = item.Cells[14].Value.ToString();
                            dataGridView2.Rows[n].Cells[14].Value = item.Cells[15].Value.ToString();


                            dataGridView1.SelectedRows[0].Cells[0].Value = true;
                            
                        }
                    }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (dbsearch.Text == "BSIT")
            {
                MySqlConnection connection = new MySqlConnection("data source=localhost; port=3306; database=pinakaiingatan; username=root; password=;");
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT `student_id`, `Name`, `Course`, `Year`, `Section`, `Session`, `Gender`, `Email`, `Contact`, `Status`, `Emercontact`, `Address`, `Branch`, `Code`, `Payment` FROM `tblbsit` WHERE student_id like '%" + dbsearch.Text + "%'", connection);
                DataTable table = new DataTable();
                adapter.Fill(table);

            }
            else if (dbsearch.Text == "BSBA")
            {
                MySqlConnection connection = new MySqlConnection("data source=localhost; port=3306; database=pinakaiingatan; username=root; password=;");
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT `student_id`, `Name`, `Course`, `Year`, `Section`, `Session`, `Gender`, `Email`, `Contact`, `Status`, `Emercontact`, `Address`, `Branch`, `Code`, `Payment` FROM `tblbsba`  WHERE Name like '%" + dbsearch.Text + "%' ", connection);
                DataTable table = new DataTable();
                adapter.Fill(table);

            }
            else if (dbsearch.Text == "HRM")
            {
                MySqlConnection connection = new MySqlConnection("data source=localhost; port=3306; database=pinakaiingatan; username=root; password=;");
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT `student_id`, `Name`, `Course`, `Year`, `Section`, `Session`, `Gender`, `Email`, `Contact`, `Status`, `Emercontact`, `Address`, `Branch`, `Code`, `Payment` FROM `tblhrm`  WHERE student_id like '%" + dbsearch.Text + "%' ", connection);
                DataTable table = new DataTable();
                adapter.Fill(table);

            }
           
        }

        private void @new_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        
    }
}
