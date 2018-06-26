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
    public partial class reghrm : UserControl
    {
        public static reghrm _instance;
        public static reghrm instance
        {
            get
            {
                if (_instance == null)
                    _instance = new reghrm();
                return _instance;
            }

        }

        public reghrm()
        {
            InitializeComponent();
        }
        MySqlConnection connection = new MySqlConnection("data source=localhost; port=3306; database='pinakaiingatan'; username=root; password=;");
        MySqlCommand command;
        private void search_MouseClick(object sender, MouseEventArgs e)
        {
            string valueToSearch = textvalueToSearch.Text.ToString();
            searchData(valueToSearch);
       
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


        public void searchData(string valueToSearch)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            string searchQuery = "SELECT * FROM tblhrm WHERE CONCAT(`student_id`, `Name`, `Course`, `Year`, `Section`, `Session`, `Gender`, `Email`, `Contact`, `Status`, `Emercontact`, `Address`, `Branch`, `Code`, `Payment` ) like'%" + valueToSearch + "%'";
            command = new MySqlCommand(searchQuery, connection);
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            dataGridView_hrm.DataSource = table;

            dataGridView_hrm.BorderStyle = BorderStyle.None;
            dataGridView_hrm.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView_hrm.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView_hrm.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView_hrm.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView_hrm.BackgroundColor = Color.White;

            dataGridView_hrm.EnableHeadersVisualStyles = false;
            dataGridView_hrm.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView_hrm.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView_hrm.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        
        }

        private void reghrm_Load(object sender, EventArgs e)
        {
            searchData("");
            Fillcombo();
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

            string insertQuery = "INSERT INTO tblhrm(`student_id`, `Name`, `Course`, `Year`, `Section`, `Session`,  `Gender`,  `email`, `contact`, `status`, `emercontact`, `address`, `branch`, `code`, `payment`) VALUES ('" + student_id.Text + "', '" + name.Text + "', '" + course.Text + "', '" + year.Text + "', '" + section.Text + "', '" + session.Text + "', '" + gender.Text + "', '" + email.Text + "', '" + contact.Text + "', '" + status.Text + "', '" + emercontact.Text + "', '" + address.Text + "', '" + branch.Text + "', '" + code.Text + "', '" + payment.Text + "')";
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

        private void dataGridView_hrm_MouseClick(object sender, MouseEventArgs e)
        {
              student_id.Text = dataGridView_hrm.CurrentRow.Cells[0].Value.ToString();
                    name.Text = dataGridView_hrm.CurrentRow.Cells[1].Value.ToString();
                  course.Text = dataGridView_hrm.CurrentRow.Cells[2].Value.ToString();
                    year.Text = dataGridView_hrm.CurrentRow.Cells[3].Value.ToString();
                 section.Text = dataGridView_hrm.CurrentRow.Cells[4].Value.ToString();
                 session.Text = dataGridView_hrm.CurrentRow.Cells[5].Value.ToString();
                  gender.Text = dataGridView_hrm.CurrentRow.Cells[6].Value.ToString();
                   email.Text = dataGridView_hrm.CurrentRow.Cells[7].Value.ToString();
                 contact.Text = dataGridView_hrm.CurrentRow.Cells[8].Value.ToString();
                  status.Text = dataGridView_hrm.CurrentRow.Cells[9].Value.ToString();
            emercontact.Text = dataGridView_hrm.CurrentRow.Cells[10].Value.ToString();
                address.Text = dataGridView_hrm.CurrentRow.Cells[11].Value.ToString();
                 branch.Text = dataGridView_hrm.CurrentRow.Cells[12].Value.ToString();
                   code.Text = dataGridView_hrm.CurrentRow.Cells[13].Value.ToString();
                payment.Text = dataGridView_hrm.CurrentRow.Cells[14].Value.ToString();
           
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
    }
}
