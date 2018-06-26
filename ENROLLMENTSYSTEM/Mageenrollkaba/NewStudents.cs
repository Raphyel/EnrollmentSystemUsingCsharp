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
    public partial class NewStudents : UserControl
    {

        public static NewStudents _instance;
        public static NewStudents instance
        {
            get
            {
                if (_instance == null)
                    _instance = new NewStudents();
                return _instance;
            }

        }


        public NewStudents()
        {
            InitializeComponent();
        }
        MySqlConnection connection = new MySqlConnection("data source=localhost; port=3306; database='pinakaiingatan'; username=root; password=;");
        MySqlCommand command;

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
                    string scourse = reader.GetString("senior");
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


        public void FillDGV(string valuetosearch)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `tblnewstudent`", connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.Fill(table);

            data_sh.RowTemplate.Height = 60;
            data_sh.AllowUserToAddRows = false;


            data_sh.DataSource = table;


            data_sh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            data_sh.BorderStyle = BorderStyle.None;
            data_sh.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            data_sh.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            data_sh.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            data_sh.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            data_sh.BackgroundColor = Color.White;

            data_sh.EnableHeadersVisualStyles = false;
            data_sh.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            data_sh.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            data_sh.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

        }

        private void NewStudents_Load(object sender, EventArgs e)
        {
            Fillcombo();
            FillDGV("");
        }

        private void save_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO tblnewstudent(`student_id`, `Name`, `Course`, `Year`, `Section`, `Session`,  `Gender`,  `email`, `contact`, `status`, `emercontact`, `address`, `branch`, `code`, `payment`) VALUES ('" + student_id.Text + "', '" + name.Text + "', '" + course.Text + "', '" + year.Text + "', '" + section.Text + "', '" + session.Text + "', '" + gender.Text + "', '" + email.Text + "', '" + contact.Text + "', '" + status.Text + "', '" + emercontact.Text + "', '" + address.Text + "', '" + branch.Text + "', '" + code.Text + "', '" + payment.Text + "')";
            executeQuery(insertQuery);

        }

        private void save_Click_1(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO tblnewstudent(`student_id`, `Name`, `Course`, `GradeYear`, `Section`, `Session`, `Gender`, `Email`, `Contact`, `Status`, `Emercontact`, `Address`, `Branch`, `Payment`) VALUES ('" + student_id.Text + "', '" + name.Text + "', '" + course.Text + "', '" + year.Text + "', '" + section.Text + "', '" + session.Text + "', '" + gender.Text + "', '" + email.Text + "', '" + contact.Text + "', '" + status.Text + "', '" + emercontact.Text + "', '" + address.Text + "', '" + branch.Text + "', '" + payment.Text + "')";
            executeQuery(insertQuery);

        }

        private void clear_Click(object sender, EventArgs e)
        {
            clearfield();
        }

        private void data_sh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void searchData(string valueToSearch)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            string searchQuery = "SELECT * FROM tblnewstudent WHERE CONCAT( `student_id`, `Name`, `Course`, `GradeYear`, `Section`, `Session`, `Gender`, `Email`, `Contact`, `Status`, `Emercontact`, `Address`, `Branch`, `Payment`) like'%" + valueToSearch + "%'";
            command = new MySqlCommand(searchQuery, connection);
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            data_sh.DataSource = table;



            data_sh.BorderStyle = BorderStyle.None;
           data_sh.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            data_sh.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            data_sh.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            data_sh.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
           data_sh.BackgroundColor = Color.White;

            data_sh.EnableHeadersVisualStyles = false;
            data_sh.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            data_sh.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
           data_sh.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void search_Click(object sender, EventArgs e)
        {

            string valueToSearch = textvalueToSearch.Text.ToString();
            searchData(valueToSearch);
       
        }


    }
}
