using System;
using System.Net.Mail;

namespace LearnASPNET
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
//
        }

        protected void EmailButton_Click(object sender, EventArgs e)
        {
            string subject = "Email Test in ASP.NET";
            string body = "Thanks and Regards...";
            SmtpClient smtpClient = new SmtpClient();
            smtpClient.EnableSsl = true;
            smtpClient.Host = "localhost";
            smtpClient.Port = 61814;
            smtpClient.Send("ak.shrishesh@gmail.com", "ak.shrishesh@gmail.com", subject, body);
        }
    }
}