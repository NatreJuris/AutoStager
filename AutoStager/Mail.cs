using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace AutoStager
{
    public class Mail
    {
        public static List<string> MovSend = new List<string>();
        public static List<string> StaSend = new List<string>();

        static string smtp = "smtp.gmail.com";
        static int port = 587;
        static bool enableSSL = true;
        static string from = "autostager1@gmail.com";
        static string password = "pgrm avil nbun ottq";

        public static string MovDate = "";
        public static string MovTime = "";
        public static string StaDate = "";
        public static string StaTime = "";
   
        public static async Task SendMov()
        {
            using(MailMessage mail = new MailMessage())
            {
                foreach (string add in MovSend)
                {
                    mail.To.Add(new MailAddress(add));
                }
                mail.From = new MailAddress(from);
                mail.Subject = (MovDate + "   " + MovTime);
                mail.Body = Form1.MovTextBox.Text;
                mail.IsBodyHtml = false;

                using (SmtpClient smtpClient = new SmtpClient(smtp, port))
                {
                    smtpClient.Credentials = new NetworkCredential(from, password);
                    smtpClient.EnableSsl = enableSSL;
                    smtpClient.Send(mail);
                }
                mail.Dispose();
            }
        }
        public static async Task SendSta()
        {
            using (MailMessage mail = new MailMessage())
            {
                foreach (string add in StaSend)
                {
                    mail.To.Add(new MailAddress(add));
                }
                mail.From = new MailAddress(from);
                mail.Subject = (StaDate + "   " + StaTime);
                mail.Body = Form1.StaTextBox.Text;
                mail.IsBodyHtml = false;

                using (SmtpClient smtpClient = new SmtpClient(smtp, port))
                {
                    smtpClient.Credentials = new NetworkCredential(from, password);
                    smtpClient.EnableSsl = enableSSL;
                    smtpClient.Send(mail);
                }
                mail.Dispose();
            }
        }
    }
}
