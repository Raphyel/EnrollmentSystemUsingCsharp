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
    public partial class Send : UserControl
    {
        public static Send _instance;
        public static Send instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Send();
                return _instance;
            }

        }


        public Send()
        {
            InitializeComponent();
            Fillcombo();
        }

        MySqlConnection connection = new MySqlConnection("data source=localhost; port=3306; database='pinakaiingatan'; username=root; password=;");
       
        private void search_Click(object sender, EventArgs e)
        {

        }

        private void BROWSE_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.JPG;*.PNG)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        
        }

        void Fillcombo()
        {
            string constring = "datasource=localhost; port=3306; database=pinakaiingatan; username=root; password=;";
            string query = "Select * from  course ";
            MySqlConnection connection = new MySqlConnection(constring);
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader;

            try
            {
                connection.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string scourse = reader.GetString("Course");
                    course.Items.Add(scourse);

                    
                    string sscode = reader.GetString("Code");
                    promo.Items.Add(sscode);

                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        
        public void clearfield()
        {
            student_id.Text = "";
            course.Text = "";
            name.Text = "";
            payment.Text = "";
            promo.Text = "";
            section.Text = "";
            date.Text = "";
            pictureBox1.Text = "";
        }

        private void Send_Load(object sender, EventArgs e)
        {
            
        }

        private void save_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            Byte[] img = ms.ToArray();
            MySqlCommand command = new MySqlCommand("INSERT INTO `sender`(`student_id`, `Name`, `Course`, `Section`, `Code`, `Payment`, `Date`, `Image`) VALUES  (@id, @name, @course, @section, @code, @payment, @date,  @img)", connection);
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = student_id.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name.Text;
            command.Parameters.Add("@course", MySqlDbType.VarChar).Value = course.Text;
            command.Parameters.Add("@section", MySqlDbType.VarChar).Value = section.Text;
            command.Parameters.Add("@code", MySqlDbType.VarChar).Value = promo.Text;
            command.Parameters.Add("@payment", MySqlDbType.VarChar).Value = payment.Text;
            command.Parameters.Add("@date", MySqlDbType.VarChar).Value = date.Text;
            command.Parameters.Add("@img", MySqlDbType.LongBlob).Value = img;

            ExecMyQuery(command, "Thank you!");
            clearfield();
       
        }

        public void ExecMyQuery(MySqlCommand mcomd, string myMsg)
        {
            connection.Open();
            if (mcomd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show(myMsg);
            }
            else
            {
                MessageBox.Show("Query Not Executed!");
            }
            connection.Close();
        }


    }
}
