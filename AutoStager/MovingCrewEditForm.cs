using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;



namespace AutoStager
{
    public partial class MovingCrewEditForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Student\source\repos\AutoStager\AutoStager\AutoStager.mdf; Integrated Security = True; Connect Timeout = 30");



        public MovingCrewEditForm()
        {
            InitializeComponent();

            UpdateDataTable();


            Carriers.DisplayMember = "Key";
            Carriers.DataSource = CellCarriers.cellCarriers.ToList();
            Carriers.ValueMember = "Value";
        }
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DeleteInfo();
        }
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            UpdateInfo();
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            SaveInfo();
        }
        protected void SaveInfo()
        {
            con.Open();
            string QUERY = "INSERT INTO MovingCrew" +
                "(Name, Phone, Email, PhoneCarrier)" +
                "VALUES (@Name, @Phone, @Email, @PhoneCarrier)";

            SqlCommand cmd = new SqlCommand(QUERY, con);
            cmd.Parameters.AddWithValue("@Name", textBox1.Text);
            cmd.Parameters.AddWithValue("@Phone", textBox2.Text);
            cmd.Parameters.AddWithValue("@Email", textBox3.Text);
            cmd.Parameters.AddWithValue("@PhoneCarrier", Carriers.SelectedValue);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Crew member added successfully.");

            UpdateDataTable();
            con.Close();
            this.Close();
        }
        protected void UpdateInfo()
        {
            con.Open();
            string QUERY = "UPDATE MovingCrew SET Name=@Name, Phone=@Phone, Email=@Email, PhoneCarrier=@PhoneCarrier WHERE Id = @Id";

            SqlCommand cmd = new SqlCommand(QUERY, con);
            cmd.Parameters.AddWithValue("@Id", textId.Text);
            cmd.Parameters.AddWithValue("@Name", textBox1.Text);
            cmd.Parameters.AddWithValue("@Phone", textBox2.Text);
            cmd.Parameters.AddWithValue("@Email", textBox3.Text);
            cmd.Parameters.AddWithValue("@PhoneCarrier", Carriers.SelectedValue);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Crew member updated successfully.");

            UpdateDataTable();
            con.Close();
            this.Close();

        }
        protected void DeleteInfo()
        {
            con.Open();
            string QUERY = "DELETE FROM MovingCrew WHERE Id = @Id";

            SqlCommand cmd = new SqlCommand(QUERY, con);
            cmd.Parameters.AddWithValue("@Id", textId.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Crew member removed successfully.");

            UpdateDataTable();
            con.Close();
            this.Close();

        }
        protected void UpdateDataTable()
        {
            string constr = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Student\source\repos\AutoStager\AutoStager\AutoStager.mdf; Integrated Security = True; Connect Timeout = 30";
            SqlConnection conn = new SqlConnection(constr);
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM MovingCrew", conn);
                {
                    DataTable dt = new DataTable(constr);
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textId.Clear();
            Carriers.ResetText();

            var mainForm = Application.OpenForms.OfType<Form1>().Single();
            mainForm.MovTable();
        }

    }
}
