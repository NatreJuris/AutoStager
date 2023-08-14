using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace AutoStager
{
    public partial class Form1 : Form
    {
        public static List<String> stagingDates = new List<String>();
        public static string MovDate { get; set; }
        public static string MovTime { get; set; }
        public static string StaDate { get; set; }
        public static string StaTime { get; set; }

        public Form1()
        {
            InitializeComponent();
            Text = "HEMMA STAGING";

            UpdateMovingCrewData();
            UpdateStagingCrewData();
            UpdateCalendarData();
            updateBoldedDates();
        }

        private void UpdateMovingCrewData()
        {
            string constr = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Student\source\repos\AutoStager\AutoStager\AutoStager.mdf; Integrated Security = True; Connect Timeout = 30";
            SqlConnection conn = new SqlConnection(constr);
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT Name, Phone, PhoneCarrier, Email FROM MovingCrew", conn);
                {
                    DataTable dt = new DataTable(constr);
                    sda.Fill(dt);

                    checkedListBox1.DataSource = dt;
                    checkedListBox1.DisplayMember = "Name";
                    checkedListBox1.ValueMember = "Phone";
                }
            }
        }
        public void UpdateStagingCrewData()
        {
            string constr = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Student\source\repos\AutoStager\AutoStager\AutoStager.mdf; Integrated Security = True; Connect Timeout = 30";
            SqlConnection conn = new SqlConnection(constr);
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT Name, Phone, PhoneCarrier, Email FROM StagingCrew", conn);
                {
                    DataTable dt = new DataTable(constr);
                    sda.Fill(dt);

                    checkedListBox2.DataSource = dt;
                    checkedListBox2.DisplayMember = "Name";
                    checkedListBox2.ValueMember = "Phone";
                }
            }
        }
        public void UpdateCalendarData()
        {
            CalendarForm.DeleteOldDates();
            string constr = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\USERS\STUDENT\SOURCE\REPOS\AUTOSTAGER\AUTOSTAGER\CALENDAR.MDF;Integrated Security=True;Connect Timeout = 30";
            SqlConnection conn = new SqlConnection(constr);
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Staging order by Date", conn);
                {
                    DataTable dt = new DataTable(constr);
                    sda.Fill(dt);
                    CalendarTable.DataSource = dt;
                }
            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)     //uhaul link
        {
            System.Diagnostics.Process.Start("http://www.uhaul.com");
        }
        public void MovTable()                                           //DataTables
        {
            UpdateMovingCrewData();
        }
        public void StaTable()                                
        {
            UpdateStagingCrewData();
        }
        public void CalendarTableData()
        {
            UpdateCalendarData();
        }
        private void SendMovbtn_Click(object sender, EventArgs e)          //Send Text Btns
        {
            MovText();

            ShowSendMov();
        }
        private void SendStabtn_Click(object sender, EventArgs e)
        {
            StaText();

            ShowSendSta();
        }                                                                                                   //DateTimePickers
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)               //MovText Subject
        {
            MovDate = Convert.ToString(dateTimePicker1.Value.Date.ToShortDateString());
            Mail.MovDate = MovDate;
        }
        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            MovTime = Convert.ToString(dateTimePicker3.Value.ToShortTimeString());
            Mail.MovTime = MovTime; 
        }
        private void dateTimePicker4_ValueChanged(object sender, EventArgs e)               //StaText Subject
        {
            StaDate = Convert.ToString(dateTimePicker4.Value.Date.ToShortDateString());
            Mail.StaDate = StaDate;
        }
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            StaTime = Convert.ToString(dateTimePicker2.Value.ToShortTimeString());
            Mail.StaTime = StaTime; 
        }
       
        private void MovTextBoxUpdate()
        {
            string constr = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\USERS\STUDENT\SOURCE\REPOS\AUTOSTAGER\AUTOSTAGER\CALENDAR.MDF;Integrated Security=True;Connect Timeout = 30";
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();
            {
                string query = "SELECT Notes FROM Staging WHERE Date = Date";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var note = reader.GetString(0);
                            MovTextBox.Text = note;
                        }
                    }
                }
            }
            conn.Close();
        }

        private void MovEditFormBtn_Click(object sender, EventArgs e)           //Edit Forms
        {
            Program.MovingCrewEditForm();
        } 
        private void StaEditFormBtn_Click(object sender, EventArgs e)
        {
            Program.StaCrewEditForm();
        }
        private async void MovText()                                           //Mov Text
        {
            List<string> EmailList = new List<string>();

            string sendto = "";
            foreach (object item in checkedListBox1.CheckedItems)
            {
                sendto = null;
                DataRowView row = item as DataRowView;
                sendto += row["Phone"];
                sendto += row["PhoneCarrier"];
                EmailList.Add(sendto);
                Mail.MovSend = (EmailList);
                await Mail.SendMov();
            }
        }
        private async void MovEmail()                                           //Mov Email
        {
            List<string> EmailList = new List<string>();

            string sendto = "";
            foreach (object item in checkedListBox1.CheckedItems)
            {
                sendto = null;
                DataRowView row = item as DataRowView;
                sendto += row["Email"];
                EmailList.Add(sendto);
                Mail.MovSend = (EmailList);
                await Mail.SendMov();
            }
        }
        private void ShowSendMov()                                              //ShowSendMov
        {
            string showsendto = "";
            foreach (object item in checkedListBox1.CheckedItems)
            {
                DataRowView row = item as DataRowView;
                showsendto += Environment.NewLine;
                showsendto += "Name: " + row["Name"];
                showsendto += Environment.NewLine;
                showsendto += "Phone: " + row["Phone"];
                showsendto += Environment.NewLine;
            }
            MessageBox.Show(showsendto, "Message Sent To:");
        }private void ShowSendMovEmail()                                        //ShowSendMovEmail
        {
            string showsendto = "";
            foreach (object item in checkedListBox1.CheckedItems)
            {
                DataRowView row = item as DataRowView;
                showsendto += Environment.NewLine;
                showsendto += "Name: " + row["Name"];
                showsendto += Environment.NewLine;
                showsendto += "Email: " + row["Email"];
                showsendto += Environment.NewLine;
            }
            MessageBox.Show(showsendto, "Message Sent To:");
        }
        private async void StaText()                                                      //Sta Text
        {
            List<string> EmailList = new List<string>();

            string sendto = "";
            foreach (object item in checkedListBox2.CheckedItems)
            {
                sendto = null;
                DataRowView row = item as DataRowView;
                sendto += row["Phone"];
                sendto += row["PhoneCarrier"];
                EmailList.Add(sendto);
                Mail.StaSend = EmailList;
                await Mail.SendSta();
            }
        }
        private async void StaEmail()                                                    //Sta Email
        {
            List<string> EmailList = new List<string>();

            string sendto = "";
            foreach (object item in checkedListBox2.CheckedItems)
            {
                sendto = null;
                DataRowView row = item as DataRowView;
                sendto += row["Email"];
                EmailList.Add(sendto);
                Mail.StaSend = (EmailList);
                await Mail.SendSta();
            }
        }
        private void ShowSendSta()                                                      //ShowSendSta
        {
            string showsendto = "";
            foreach (object item in checkedListBox2.CheckedItems)
            {
                DataRowView row = item as DataRowView;
                showsendto += Environment.NewLine;
                showsendto += "Name: " + row["Name"];
                showsendto += Environment.NewLine;
                showsendto += "Phone: " + row["Phone"];
                showsendto += Environment.NewLine;
            }
            MessageBox.Show(showsendto, "Message Sent To:");
        }
        private void ShowSendStaEmail()                                                 //ShowSendStaEmail
        {
            string showsendto = "";
            foreach (object item in checkedListBox2.CheckedItems)
            {
                DataRowView row = item as DataRowView;
                showsendto += Environment.NewLine;
                showsendto += "Name: " + row["Name"];
                showsendto += Environment.NewLine;
                showsendto += "Email: " + row["Email"];
                showsendto += Environment.NewLine;
            }
            MessageBox.Show(showsendto, "Message Sent To:");
        }
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)         //Calendar Form
        {
            if (Application.OpenForms.OfType<CalendarForm>().Count() == 1)
                Application.OpenForms.OfType<CalendarForm>().First().Close();
            Program.CalendarForm();
            var calForm = Application.OpenForms.OfType<CalendarForm>().Single();
            string DateString = e.Start.ToShortDateString();
            calForm.DateHeader.Text = DateString;
        }
        public static void LoadDates()                                                      //Bold Dates
        {
            monthCalendar1.RemoveAllBoldedDates();

            String myInput;                                                          
            try
            {
                StreamReader myInputStream = File.OpenText("BoldDates.txt");
                while ((myInput = myInputStream.ReadLine()) != null)
                {
                    monthCalendar1.AddBoldedDate(DateTime.Parse(myInput));
                }
                monthCalendar1.UpdateBoldedDates();
                myInputStream.Close();
            }
            catch (FileNotFoundException fnfe)
            {
                Console.WriteLine("An error occurred: '{0}'", fnfe);
            }
        }
        public static void updateBoldedDates()
        {
            stagingDates.Clear();
            var today = DateTime.Today;
            using (SqlConnection conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\USERS\STUDENT\SOURCE\REPOS\AUTOSTAGER\AUTOSTAGER\CALENDAR.MDF; Integrated Security = True; Connect Timeout = 30"))
            {
                conn.Open();
                string query = "SELECT Date FROM Staging";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var date = reader.GetDateTime(0);                             
                            if (date > today) stagingDates.Add(Convert.ToString(date));
                        }
                    }
                }
            }
            File.Delete("BoldDates.txt");
            foreach (var line in stagingDates)
            {
                TextWriter txt = new StreamWriter("BoldDates.txt", true);
                txt.WriteLine(line);
                txt.Close();
            }
            LoadDates();
        }
        private void MovSendEmail_Click(object sender, EventArgs e)             //send email btns
        {
            MovEmail();
            ShowSendMovEmail();
        }
        private void StaSendEmail_Click(object sender, EventArgs e)
        {
            StaEmail();
            ShowSendStaEmail();
        }
    }
}
