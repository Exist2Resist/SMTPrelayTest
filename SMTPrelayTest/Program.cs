using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace SMTPrelayTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SMTP Host IP: ");
            var smtpHOST = Console.ReadLine();
            Console.WriteLine("EMAIL FROM: ");
            var emailFROM = Console.ReadLine();
            Console.WriteLine("EMAIL TO: ");
            var emailTO = Console.ReadLine();
            Console.WriteLine("SUBJECT: ");
            var emailSUBJ = Console.ReadLine();
            Console.WriteLine("BODY MESSAGE: ");
            var emailBODY = Console.ReadLine();


            SmtpClient smtp = new SmtpClient();
            smtp.Host = smtpHOST;

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(emailFROM);
            mail.To.Add(emailTO);
            mail.Subject = emailSUBJ;
            mail.Body = emailBODY;

            try
            {
                smtp.Send(mail);
            }
            catch (SmtpException e)
            {
                Console.WriteLine(e.InnerException.Message);
                Console.ReadLine();
            }            
        }
    }
}
