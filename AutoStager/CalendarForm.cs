using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace AutoStager
{
    public partial class CalendarForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\USERS\STUDENT\SOURCE\REPOS\AUTOSTAGER\AUTOSTAGER\CALENDAR.MDF;Integrated Security=True;Connect Timeout = 30");
        public CalendarForm()
        {
            InitializeComponent();

            UpdateCalendarDataTable();
        }
        protected void UpdateCalendarDataTable()
        {
            DeleteOldDates();
            string constr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=C:\USERS\STUDENT\SOURCE\REPOS\AUTOSTAGER\AUTOSTAGER\CALENDAR.MDF;Integrated Security=SSPI;";
            SqlConnection con = new SqlConnection(constr);
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Staging WHERE Date = Date order by Date", con);
                {
                    DataTable dt = new DataTable(constr);
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            textBox1.Clear();
            textBox2.Clear();

            var mainForm = Application.OpenForms.OfType<Form1>().Single();
            mainForm.CalendarTableData();
        }
        public void UpdatedataGridView1()
        {

            string constr = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\USERS\STUDENT\SOURCE\REPOS\AUTOSTAGER\AUTOSTAGER\CALENDAR.MDF;Integrated Security=True;Connect Timeout = 30";
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Staging", conn);
                {
                    DataTable dt = new DataTable(constr);
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            conn.Close();
        }
        protected void SaveInfo()
        {
            con.Open();
            string QUERY = "INSERT INTO Staging" +
                "(Date, Time, Address, Notes)" +
                "VALUES (@Date, @Time, @Address, @Notes)";

            SqlCommand cmd = new SqlCommand(QUERY, con);
            cmd.Parameters.AddWithValue("@Date", DateHeader.Text);
            cmd.Parameters.AddWithValue("@Time", dateTimePicker1.Text);
            cmd.Parameters.AddWithValue("@Address", textBox2.Text);
            if (StagingcheckBox.Checked) cmd.Parameters.AddWithValue("@Notes", "Staging  " + textBox1.Text);
            else if (DeStagingcheckBox.Checked) cmd.Parameters.AddWithValue("@Notes", "De-Staging  " + textBox1.Text);
            else cmd.Parameters.AddWithValue("@Notes", textBox1.Text);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Added to calendar successfully.");

            Form1.updateBoldedDates();
            UpdateCalendarDataTable();
            UpdatedataGridView1();
            con.Close();
            this.Close();
        }
        protected void DeleteInfo()
        {
            con.Open();
            string QUERY = "DELETE FROM Staging WHERE Date = @Date";

            SqlCommand cmd = new SqlCommand(QUERY, con);
            cmd.Parameters.AddWithValue("@Date", DateHeader.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Removed from calendar successfully.");

            Form1.updateBoldedDates();
            UpdateCalendarDataTable();
            UpdatedataGridView1();
            con.Close();
            this.Close();

        }
        public void CloseInfo()
        {
            this.Close();
        }

        public static void DeleteOldDates()
        {
            string constr = (@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\USERS\STUDENT\SOURCE\REPOS\AUTOSTAGER\AUTOSTAGER\CALENDAR.MDF;Integrated Security=True;Connect Timeout = 30");
            SqlConnection conn = new SqlConnection(constr);
            {
                DateTime today = DateTime.Now;
                conn.Open();
                string QUERY = "DELETE FROM Staging WHERE Date < @Date";

                SqlCommand cmd = new SqlCommand(QUERY, conn);
                cmd.Parameters.AddWithValue("@Date", today);
                cmd.ExecuteNonQuery();

                conn.Close();
            }
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            SaveInfo();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DeleteInfo();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            CloseInfo();
        }


    }
}
