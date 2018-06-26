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

namespace Mageenrollkaba
{
    public partial class regbsit : UserControl
    {
        public static regbsit _instance;
        public static regbsit instance
        {
            get
            {
                if (_instance == null)
                    _instance = new regbsit();
                return _instance;
            }

        }

        public regbsit()
        {
            InitializeComponent();
        }
        MySqlConnection connection = new MySqlConnection("data source=localhost; port=3306; database='pinakaiingatan'; username=root; password=;");
        MySqlCommand command;
       

        private void groupBox1_Enter(object sender, EventArgs e)
        {

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

        public void FillDGV(string valuetosearch)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM tblaccounting WHERE CONCAT (`ID`, `Name`, `Course`, `Section`, `Year`, `Tuition`, `Code`, `Promo`, `Fees`, `Payment`, `Total`, `Date`, `Image`) Like '%" + valuetosearch + "%'", connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.Fill(table);

           
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
                    section.Items.Add(ssection);

                    string sscode = reader.GetString("Code");
                    code.Items.Add(sscode);

                    string ssyear = reader.GetString("Year");
                    year.Items.Add(ssyear);

                    string sbranch = reader.GetString("Branch");
                    branch.Items.Add(sbranch);

                    string sgender = reader.GetString("Gender");
                    gender.Items.Add(sgender);
                    string ssession = reader.GetString("Session");
                    session.Items.Add(ssession);

                    string sstatus = reader.GetString("Status");
                    status.Items.Add(sstatus);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void students_Load(object sender, EventArgs e)
        {
            searchData("");
            Fillcombo();
            FillDGV("");
        }
        private void search_MouseClick_1(object sender, MouseEventArgs e)
        {
        }


        public void searchData(string valueToSearch)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            string searchQuery = "SELECT * FROM tblbsit WHERE CONCAT(`student_id`, `Name`, `Course`, `Year`, `Section`, `Session`, `Gender`, `Email`, `Contact`, `Status`, `Emercontact`, `Address`, `Branch`, `Code`, `Payment` ) like'%" + valueToSearch + "%'";
            command = new MySqlCommand(searchQuery, connection);
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            dataGridView_stu.DataSource = table;

            dataGridView_stu.BorderStyle = BorderStyle.None;
            dataGridView_stu.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView_stu.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView_stu.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView_stu.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView_stu.BackgroundColor = Color.White;

            dataGridView_stu.EnableHeadersVisualStyles = false;
            dataGridView_stu.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView_stu.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView_stu.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        
        }


        private void search_MouseClick(object sender, MouseEventArgs e)
        {

        }



        public void openConnnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public void closeConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }

        }
        public void executeQuery(string query)
        {
            try
            {
                openConnnection();
                command = new MySqlCommand(query, connection);
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Successfully Query executed!");
                }
                else
                {
                    MessageBox.Show("try again query not executed!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                closeConnection();
            }

        }

        private void save_MouseClick(object sender, MouseEventArgs e)
        {

            string insertQuery = "INSERT INTO tblbsit(`student_id`, `Name`, `Course`, `Year`, `Section`, `Session`,  `Gender`,  `email`, `contact`, `status`, `emercontact`, `address`, `branch`, `code`, `payment`) VALUES ('" + student_id.Text + "', '" + name.Text + "', '" + course.Text + "', '" + year.Text + "', '" + section.Text + "', '" + session.Text + "', '"+gender.Text+"', '" + email.Text + "', '" + contact.Text + "', '" + status.Text + "', '" + emercontact.Text + "', '" + address.Text + "', '" + branch.Text + "', '" + code.Text + "', '" + payment.Text + "')";
            executeQuery(insertQuery);
            clearfield();
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

        

        private void dataGridView_stu_MouseClick(object sender, MouseEventArgs e)
        {
            student_id.Text = dataGridView_stu.CurrentRow.Cells[0].Value.ToString();
                  name.Text = dataGridView_stu.CurrentRow.Cells[1].Value.ToString();
                course.Text = dataGridView_stu.CurrentRow.Cells[2].Value.ToString();
                  year.Text = dataGridView_stu.CurrentRow.Cells[3].Value.ToString();
               section.Text = dataGridView_stu.CurrentRow.Cells[4].Value.ToString();
               session.Text = dataGridView_stu.CurrentRow.Cells[5].Value.ToString();
                gender.Text = dataGridView_stu.CurrentRow.Cells[6].Value.ToString();
                 email.Text = dataGridView_stu.CurrentRow.Cells[7].Value.ToString();
               contact.Text = dataGridView_stu.CurrentRow.Cells[8].Value.ToString();
                status.Text = dataGridView_stu.CurrentRow.Cells[9].Value.ToString();
          emercontact.Text = dataGridView_stu.CurrentRow.Cells[10].Value.ToString();
              address.Text = dataGridView_stu.CurrentRow.Cells[11].Value.ToString();
               branch.Text = dataGridView_stu.CurrentRow.Cells[12].Value.ToString();
                 code.Text = dataGridView_stu.CurrentRow.Cells[13].Value.ToString();
              payment.Text = dataGridView_stu.CurrentRow.Cells[14].Value.ToString();
           
        }

        private void bshrm_MouseClick(object sender, MouseEventArgs e)
        {
            reghrm rh = new reghrm();
            rh.Show();
            this.Hide();
            this.closeConnection();
        }

        private void save_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_stu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void clear_Click(object sender, EventArgs e)
        {
            clearfield();   
        }

        public void clearfield()
        {
            student_id.Text = "";
            name.Text = "";
            course.Text = "";
            year.Text = "";
            section.Text = "";
            session.Text = "";
            gender.Text = "";
            email.Text = "";
            contact.Text = "";
            status.Text = "";
            emercontact.Text = "";
            address.Text = "";
            branch.Text = "";
            code.Text = "";
            payment.Text = "";

        }

        private void search_Click(object sender, EventArgs e)
        {

            string valueToSearch = textvalueToSearch.Text.ToString();
            searchData(valueToSearch);
      
        }

        private void textvalueToSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void save_Click_1(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `tblbsit`(`student_id`, `Name`, `Course`, `Year`, `Section`, `Session`, `Gender`, `Email`, `Contact`, `Status`, `Emercontact`, `Address`, `Branch`, `Code`, `Payment`) VALUES (@id, @name, @course, @year, @section, @session, @gender, @email, @contact, @status, @emer, @address, @branch ,@code,  @payment)", connection);
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = student_id.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name.Text;
            command.Parameters.Add("@course", MySqlDbType.VarChar).Value = course.Text;
            command.Parameters.Add("@year", MySqlDbType.VarChar).Value = year.Text;
            command.Parameters.Add("@section", MySqlDbType.VarChar).Value = section.Text;
            command.Parameters.Add("@session", MySqlDbType.VarChar).Value = session.Text;
            command.Parameters.Add("@gender", MySqlDbType.VarChar).Value = gender.Text;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = email.Text;
            command.Parameters.Add("@contact", MySqlDbType.VarChar).Value = contact.Text;
            command.Parameters.Add("@status", MySqlDbType.VarChar).Value = status.Text;
            command.Parameters.Add("@emer", MySqlDbType.VarChar).Value = emercontact.Text;
            command.Parameters.Add("@address", MySqlDbType.VarChar).Value = address.Text;
            command.Parameters.Add("@branch", MySqlDbType.LongBlob).Value = branch.Text;
            command.Parameters.Add("@code", MySqlDbType.LongBlob).Value = code.Text;
            command.Parameters.Add("@payment", MySqlDbType.LongBlob).Value = payment.Text;

            ExecMyQuery(command, "Data inserted");
            clearfield();
       
        }

        private void search_Click_1(object sender, EventArgs e)
        {

        }
        
        
        
  


    }

}
