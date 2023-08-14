using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;




namespace AutoStager
{
    public class SendText
    {
        const string apiKey = ("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");
        public static string SubjectDateMov { get; set; }
        public static string SubjectTimeMov { get; set; }
        public static string SubjectDateSta { get; set; }
        public static string SubjectTimeSta { get; set; }
        public static string ContentMov { get; set; }
        public static string ContentSta { get; set; }

        public static List<EmailAddress> MovSendTo = new List<EmailAddress>();
        public static List<EmailAddress> StaSendTo = new List<EmailAddress>();


        public static async Task SendMov()
        {
            var client = new SendGridClient(apiKey);
            var recipients = MovSendTo;
            var msg = new SendGridMessage();
            msg.SetFrom(new EmailAddress("autostager1@gmail.com", "AutoStager"));
            msg.SetSubject(SubjectDateMov + "   " + SubjectTimeMov);
            msg.AddContent(MimeType.Text, ContentMov);
            msg.AddContent(MimeType.Html, ContentMov);
            msg.AddTos(recipients);
            await client.SendEmailAsync(msg);
        }
        public static async Task SendSta()
        {
            var client = new SendGridClient(apiKey);
            var recipients = StaSendTo;
            var msg = new SendGridMessage();
            msg.SetFrom(new EmailAddress("autostager1@gmail.com", "AutoStager"));
            msg.SetSubject(SubjectDateSta + "   " + SubjectTimeSta);
            msg.AddContent(MimeType.Text, ContentSta);
            msg.AddContent(MimeType.Html, ContentSta);
            msg.AddTos(recipients);
            await client.SendEmailAsync(msg);
        }
    }
}
