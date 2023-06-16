using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace TrackerLibrary
{
    public static class EmailLogic
    {

        public static void SendEmail(string to, string subject, string body)
        {
            SendEmail(new List<string> { to }, new List<string>(), subject, body);
        }

       public static void SendEmail(List<string> to,List<string> bcc,string subject, string body)
       {
            MailAddress fromAddress = new MailAddress(GlobalConfig.AppKeyLookup("senderEmail")); 

            MailMessage mail = new MailMessage();
            foreach (string item in to) 
            {
                mail.To.Add(item);
            }
            foreach (string item in bcc)
            {
                mail.Bcc.Add(item);
            }
            mail.From = fromAddress;
            mail.Subject = subject;
            mail.Body = body;
            mail.IsBodyHtml = true; 

            SmtpClient smtpClient = new SmtpClient(); 
            
            smtpClient.Send(mail);
       }
    }
}
