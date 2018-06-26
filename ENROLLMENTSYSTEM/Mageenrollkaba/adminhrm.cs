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
    public partial class adminhrm : UserControl
    {
    

        public static adminhrm _instance;
        public static adminhrm instance
        {
            get
            {
                if (_instance == null)
                    _instance = new adminhrm();
                return _instance;
            }

        }

        MySqlConnection connection = new MySqlConnection("data source=localhost; port=3306; database='pinakaiingatan'; username=root; password=;");
        MySqlCommand command;


        public adminhrm()
        {
            InitializeComponent();
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
        private void adminhrm_Load(object sender, EventArgs e)
        {
            searchData("");
            Fillcombo();
            clearfield();
        }

        private void search_Click(object sender, EventArgs e)
        {

            string valueToSearch = textvalueToSearch.Text.ToString();
            searchData(valueToSearch);
  
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

        

        private void clear_Click(object sender, EventArgs e)
        {
            clearfield();
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

        private void button1_Click(object sender, EventArgs e)
        {
            string updateQuery = "UPDATE tblhrm set student_id='" + student_id.Text + "', Name='" + name.Text + "', Course='" + course.Text + "', Year='" + year.Text + "', Section='" + section.Text + "', Session='" + session.Text + "', Gender='" + gender.Text + "', Email='" + email.Text + "', Status='" + status.Text + "', Emercontact='" + emercontact.Text + "', Address='" + address.Text + "', Branch='" + branch.Text + "', Code='" + code.Text + "', Payment='" + payment.Text + "' WHERE student_id = " + int.Parse(student_id.Text);
            executeQuery(updateQuery);  
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string deleteQuery = "DELETE FROM tblhrm WHERE student_id =" + int.Parse(student_id.Text);
            executeQuery(deleteQuery);
        
        }

        private void save_Click(object sender, EventArgs e)
        {

            string insertQuery = "INSERT INTO tblhrm(`student_id`, `Name`, `Course`, `Year`, `Section`, `Session`,  `Gender`,  `email`, `contact`, `status`, `emercontact`, `address`, `branch`, `code`, `payment`) VALUES ('" + student_id.Text + "', '" + name.Text + "', '" + course.Text + "', '" + year.Text + "', '" + section.Text + "', '" + session.Text + "', '" + gender.Text + "', '" + email.Text + "', '" + contact.Text + "', '" + status.Text + "', '" + emercontact.Text + "', '" + address.Text + "', '" + branch.Text + "', '" + code.Text + "', '" + payment.Text + "')";
            executeQuery(insertQuery);

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

        private void dataGridView_stu_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        

       
    }
}
