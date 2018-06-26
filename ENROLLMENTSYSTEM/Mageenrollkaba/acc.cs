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
using MySql.Data.MySqlClient;
using System.Data.SqlServerCe;
using System.IO;



namespace Mageenrollkaba
{
    
   
    public partial class acc : UserControl
    {


        public static acc _instance;
        public static acc instance
        {
            get
            {
                if (_instance == null)
                    _instance = new acc();
                return _instance;
            }

        }
        
        public acc()
        {
            InitializeComponent();
        }


        MySqlConnection connection = new MySqlConnection("data source = localhost; database = pinakaiingatan; username = root; password=;");
        MySqlCommand command;
        MySqlDataAdapter adapter;

        private void browse_MouseClick(object sender, MouseEventArgs e)
        {
        
        
        }

        private void show_MouseClick(object sender, MouseEventArgs e)
        {
       
        }

        
        private void clear_MouseClick(object sender, MouseEventArgs e)
        {
            this.TraverseControlsAndSetTextEmpty(this);

        }

        public void TraverseControlsAndSetTextEmpty(Control control)
        {
            foreach (Control c in control.Controls)
            {
                var box = c as TextBox;
                if (box != null)
                {
                    box.Text = string.Empty;
                }
                this.TraverseControlsAndSetTextEmpty(c);
            }
        }

        private void browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            if (opf.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Image image = Bitmap.FromFile(opf.FileName);
                    pictureBox1.Image = image;
                }
                catch(Exception)
                { 
                    
                }
                connection.Close();
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
 
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            command = new MySqlCommand("INSERT INTO tblaccounting (`student_id`, `Name`, `Course`, `Section`, `Year`, `Code`, `Tuition`, `Fees`, `Payment`, `Total`, `Date`, `Image`) VALUES (@id, @name, @course, @section, @year, @code, @tuition, @fees, @payment, @total, @date, @pic)", connection);
            MemoryStream stream = new MemoryStream();
            pictureBox1.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] pic = stream.ToArray();
            command.Parameters.AddWithValue("@id", MySqlDbType.VarChar);
            command.Parameters.AddWithValue("@name", MySqlDbType.VarChar);
            command.Parameters.AddWithValue("@course", MySqlDbType.VarChar);
            command.Parameters.AddWithValue("@section", MySqlDbType.VarChar);
            command.Parameters.AddWithValue("@year", MySqlDbType.VarChar);
            command.Parameters.AddWithValue("@code", MySqlDbType.VarChar);
            command.Parameters.AddWithValue("@tuition", MySqlDbType.VarChar);
            command.Parameters.AddWithValue("@fees", MySqlDbType.VarChar);
            command.Parameters.AddWithValue("@payment", MySqlDbType.VarChar);
            command.Parameters.AddWithValue("@total", MySqlDbType.VarChar);
            command.Parameters.AddWithValue("@date", MySqlDbType.VarChar);
            command.Parameters.AddWithValue("@pic", pic);
            MessageBox.Show("image saved");
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // When you save the datagrid will reload
            connection.Open();
            adapter = new MySqlDataAdapter("SELECT * FROM tblaccounting", connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;


            for (int i = 0; i < dataGridView1.Columns.Count; i++)
                if (dataGridView1.Columns[i] is DataGridViewImageColumn)
                {
                    ((DataGridViewImageColumn)dataGridView1.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                    break;
                }
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Height = 80;
            }
            connection.Close();
 




        }

        private void acc_Load(object sender, EventArgs e)
        {
            connection.Open();
            adapter = new MySqlDataAdapter("SELECT * FROM tblaccounting", connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;


            for(int i=0; i < dataGridView1.Columns.Count; i++)
                if (dataGridView1.Columns[i] is DataGridViewImageColumn)
                {
                    ((DataGridViewImageColumn)dataGridView1.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                    break;
                }
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                row.Height = 80;
            }
            connection.Close();
        }

        


    }
}
