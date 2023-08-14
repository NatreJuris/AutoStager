using System;
using System.Windows.Forms;

namespace AutoStager
{
    public class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]


        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static void MovingCrewEditForm()
        {
            MovingCrewEditForm editForm = new MovingCrewEditForm();
            editForm.Show();
        }
        public static void StaCrewEditForm()
        {
            StaCrewEditForm editForm = new StaCrewEditForm();
            editForm.Show();
        }
        public static void CalendarForm()
        {
            CalendarForm editForm = new CalendarForm();
            editForm.Show();
        }

    }
}
