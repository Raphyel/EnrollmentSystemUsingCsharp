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
using DGVPrinterHelper;

namespace Mageenrollkaba
{
    public partial class accounting : UserControl
    {
        public static accounting _instance;
        public static accounting instance
        {
            get
            {
                if (_instance == null)
                    _instance = new accounting();
                return _instance;
            }

        }

        public accounting()
        {
            InitializeComponent();
            Fillcombo();
        }
        MySqlConnection connection = new MySqlConnection("data source=localhost; port=3306; database=pinakaiingatan; username=root; password=;");
        MySqlCommand cmd = new MySqlCommand();

        private void button2_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "ACCESS COMPUTER AND TECHNICAL COLLEGE";
            printer.SubTitle = "Date: "+ string.Format(DateTime.Now.ToString("dd-yyyy-MM"));
            printer.TitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "ENROLLMENT SYSTEM";
            printer.FooterSpacing = 10;
            printer.PrintDataGridView(DGVPrint);
        }


        public void loaddb()
        {
            connection.Open();
            try
            {

                cmd = connection.CreateCommand();
                cmd.CommandText = "select * from tblaccounting";
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataSet table = new DataSet();
                adapter.Fill(table);
                DGVPrint.DataSource = table.Tables[0].DefaultView;


                foreach (DataGridViewColumn column in DGVPrint.Columns)
                    this.Width = DGVPrint.Width + 20;
                int totalRowHeight = DGVPrint.ColumnHeadersHeight;
                foreach (DataGridViewRow row in DGVPrint.Rows)
                    totalRowHeight += row.Height;
                DGVPrint.Height = totalRowHeight;
                this.Height = DGVPrint.Height + 20;

                DGVPrint.Columns[0].HeaderText = "ID";
                DGVPrint.Columns[1].HeaderText = "Name";
                DGVPrint.Columns[2].HeaderText = "Course";
                DGVPrint.Columns[3].HeaderText = "Section";
                DGVPrint.Columns[4].HeaderText = "Year";
                DGVPrint.Columns[5].HeaderText = "Tuition";
                DGVPrint.Columns[6].HeaderText = "Code";
                DGVPrint.Columns[7].HeaderText = "Promo";
                DGVPrint.Columns[8].HeaderText = "Fees";
                DGVPrint.Columns[9].HeaderText = "Payment";
                DGVPrint.Columns[10].HeaderText = "Total";
                DGVPrint.Columns[11].HeaderText = "Date";
                DGVPrint.Columns[12].HeaderText = "Image";

                }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
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

                    string ssection = reader.GetString("Section");
                    sec.Items.Add(ssection);

                    string sscode = reader.GetString("Code");
                    code.Items.Add(sscode);

                    string spromo = reader.GetString("Promo");
                    promo.Items.Add(spromo);
                    
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

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

        private void accounting_Load(object sender, EventArgs e)
        {
            FillDGV("");
            loaddb();
        }

        public void FillDGV(string valuetosearch)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM tblaccounting WHERE CONCAT (`ID`, `Name`, `Course`, `Section`, `Year`, `Tuition`, `Code`, `Promo`, `Fees`, `Payment`, `Total`, `Date`, `Image`) Like '%" + valuetosearch + "%'", connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.Fill(table);

            DGVPrint.RowTemplate.Height = 60;
            DGVPrint.AllowUserToAddRows = false;


            DGVPrint.DataSource = table;

            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol = (DataGridViewImageColumn)DGVPrint.Columns[12];
            imgCol.ImageLayout = DataGridViewImageCellLayout.Stretch;

            DGVPrint.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            DGVPrint.BorderStyle = BorderStyle.None;
            DGVPrint.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            DGVPrint.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DGVPrint.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            DGVPrint.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            DGVPrint.BackgroundColor = Color.White;

            DGVPrint.EnableHeadersVisualStyles = false;
            DGVPrint.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DGVPrint.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            DGVPrint.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            Byte[] img = (Byte[])DGVPrint.CurrentRow.Cells[12].Value;
            MemoryStream ms = new MemoryStream(img);
            pictureBox1.Image = Image.FromStream(ms);
            id.Text = DGVPrint.CurrentRow.Cells[0].Value.ToString();
            name.Text = DGVPrint.CurrentRow.Cells[1].Value.ToString();
            course.Text = DGVPrint.CurrentRow.Cells[2].Value.ToString();
            sec.Text = DGVPrint.CurrentRow.Cells[3].Value.ToString();
            year.Text = DGVPrint.CurrentRow.Cells[4].Value.ToString();
            tuition.Text = DGVPrint.CurrentRow.Cells[5].Value.ToString();
            code.Text = DGVPrint.CurrentRow.Cells[6].Value.ToString();
            promo.Text = DGVPrint.CurrentRow.Cells[7].Value.ToString();
            fees.Text = DGVPrint.CurrentRow.Cells[8].Value.ToString();
            payment.Text = DGVPrint.CurrentRow.Cells[9].Value.ToString();
            total.Text = DGVPrint.CurrentRow.Cells[10].Value.ToString();
            date.Text = DGVPrint.CurrentRow.Cells[11].Value.ToString();




       
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
            FillDGV("");
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void INSERT_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            Byte[] img = ms.ToArray();
            MySqlCommand command = new MySqlCommand("INSERT INTO tblaccounting (`ID`, `Name`, `Course`, `Section`, `Year`, `Tuition`, `Code`, `Promo`, `Fees`, `Payment`, `Total`, `Date`, `Image`) VALUES (@id, @name, @course, @section, @year, @tuition, @code, @promo, @fees, @payment, @total, @date,  @img)", connection);
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name.Text;
            command.Parameters.Add("@course", MySqlDbType.VarChar).Value = course.Text;
            command.Parameters.Add("@section", MySqlDbType.VarChar).Value = sec.Text;
            command.Parameters.Add("@year", MySqlDbType.VarChar).Value = year.Text;
            command.Parameters.Add("@tuition", MySqlDbType.VarChar).Value = tuition.Text;
            command.Parameters.Add("@code", MySqlDbType.VarChar).Value = code.Text;
            command.Parameters.Add("@promo", MySqlDbType.VarChar).Value = promo.Text;
            command.Parameters.Add("@fees", MySqlDbType.VarChar).Value = fees.Text;
            command.Parameters.Add("@payment", MySqlDbType.VarChar).Value = payment.Text;
            command.Parameters.Add("@total", MySqlDbType.VarChar).Value = total.Text;
            command.Parameters.Add("@date", MySqlDbType.VarChar).Value = date.Text;
            command.Parameters.Add("@img", MySqlDbType.LongBlob).Value = img;

            ExecMyQuery(command, "Data inserted");
            clearfield();
       
        }

        private void update_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            Byte[] img = ms.ToArray();
            MySqlCommand command = new MySqlCommand("UPDATE tblaccounting SET ID=@id, Name=@name, Course=@course, Section=@section, Year=@year, Tuition=@tuition, Code=@code, Promo=@promo, Fees=@fees, Payment=@payment, Total=@total, Date=@date, Image=@img WHERE id=@id ", connection);
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name.Text;
            command.Parameters.Add("@course", MySqlDbType.VarChar).Value = course.Text;
            command.Parameters.Add("@section", MySqlDbType.VarChar).Value = sec.Text;
            command.Parameters.Add("@year", MySqlDbType.VarChar).Value = year.Text;
            command.Parameters.Add("@tuition", MySqlDbType.VarChar).Value = tuition.Text;
            command.Parameters.Add("@code", MySqlDbType.VarChar).Value = code.Text;
            command.Parameters.Add("@promo", MySqlDbType.VarChar).Value = promo.Text;
            command.Parameters.Add("@fees", MySqlDbType.VarChar).Value = fees.Text;
            command.Parameters.Add("@payment", MySqlDbType.VarChar).Value = payment.Text;
            command.Parameters.Add("@total", MySqlDbType.VarChar).Value = total.Text;
            command.Parameters.Add("@date", MySqlDbType.VarChar).Value = date.Text;
            command.Parameters.Add("@img", MySqlDbType.LongBlob).Value = img;

            ExecMyQuery(command, "Data Updated!");
            clearfield();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM tblaccounting  where ID = @id ", connection);
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id.Text;
            ExecMyQuery(command, "Data Deleted!");
            clearfield();
        
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
                MessageBox.Show("No data found!");
                clearfield();

            }
            else
            {
                id.Text = table.Rows[0][0].ToString();
                name.Text = table.Rows[0][1].ToString();
                course.Text = table.Rows[0][2].ToString();
                sec.Text = table.Rows[0][3].ToString();
                year.Text = table.Rows[0][4].ToString();
                tuition.Text = table.Rows[0][5].ToString();
                code.Text = table.Rows[0][6].ToString();
                promo.Text = table.Rows[0][7].ToString();
                fees.Text = table.Rows[0][8].ToString();
                payment.Text = table.Rows[0][9].ToString();
                total.Text = table.Rows[0][10].ToString();
                date.Text = table.Rows[0][11].ToString();

                byte[] img = (byte[])table.Rows[0][12];
                MemoryStream ms = new MemoryStream(img);
                pictureBox1.Image = Image.FromStream(ms);
            }

        }

        private void NEW_Click(object sender, EventArgs e)
        {
            clearfield();
        }
        public void clearfield()
        {
            id.Text = "";
            name.Text = "";
            course.Text = "";
            sec.Text = "";
            year.Text = "";
            tuition.Text = "";
            code.Text = "";
            promo.Text = "";
            fees.Text = "";
            payment.Text = "";
            total.Text = "";
            date.Text = "";
            pictureBox1.Image = null;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            FillDGV(textBox1.Text);
            if(dbsearch.Text == "BSIT")
            {
            MySqlConnection connection = new MySqlConnection("data source=localhost; port=3306; database=pinakaiingatan; username=root; password=;");
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT `student_id`, `Name`, `Course`, `Year`, `Section`, `Code`, `Payment` FROM `tblbsit` WHERE student_id like '%" + textBox1.Text +"%'", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DGVPrint.DataSource = table;

            }
            else if (dbsearch.Text == "BSBA")
            {
                MySqlConnection connection = new MySqlConnection("data source=localhost; port=3306; database=pinakaiingatan; username=root; password=;");
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT `student_id`, `Name`, `Course`, `Year`, `Section`, `Code`, `Payment` FROM `tblbsba`  WHERE Name like '%" + textBox1.Text + "%' ", connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                DGVPrint.DataSource = table;
 
            }
            else if (dbsearch.Text == "HRM")
            {
                MySqlConnection connection = new MySqlConnection("data source=localhost; port=3306; database=pinakaiingatan; username=root; password=;");
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT `student_id`, `Name`, `Course`, `Year`, `Section`, `Code`, `Payment` FROM `tblhrm`  WHERE student_id like '%" + textBox1.Text + "%' ", connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                DGVPrint.DataSource = table;
 
            }
            else if (dbsearch.Text == "")
            {
                MySqlConnection connection = new MySqlConnection("data source=localhost; port=3306; database=pinakaiingatan; username=root; password=;");
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT `ID`, `Name`, `Course`, `Section`, `Year`, `Tuition`, `Code`, `Promo`, `Fees`, `Payment`, `Total`, `Date`, `Image` FROM `tblaccounting`  WHERE Course like '%" + textBox1.Text + "%' ", connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                DGVPrint.DataSource = table;
  
            }
        }

        
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dbsearch_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        
        private void calculate_Click(object sender, EventArgs e)
        {
            total.Text = (Double.Parse(fees.Text) + Double.Parse(payment.Text)).ToString();
        }

        private void BROWSE_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.JPG;*.PNG)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void asort_Click(object sender, EventArgs e)
        {
            DGVPrint.Sort(DGVPrint.Columns[2], ListSortDirection.Ascending);
        }

        private void dsort_Click(object sender, EventArgs e)
        {
            DGVPrint.Sort(DGVPrint.Columns[2], ListSortDirection.Descending);

        }

        
       

    }
}
