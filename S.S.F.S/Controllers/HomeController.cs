using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Web;
using System.Web.Mvc;
using S.S.F.S;
using System.Net.Mail;

namespace S.S.F.S.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
      
        public ActionResult Contact()
        {
            ViewBag.Message = null;

            return View();
        }
        
        [HttpPost]
        public ActionResult Contact(string Name, string Email, string Message)
        {
            try
            {
                string Subject = "Contact";
                MailMessage mail = new MailMessage();
                mail.To.Add(Email);
                mail.From = new MailAddress("yasseraliammar@hotmail.com");
                mail.Subject = Subject;

                string userMessage = "";
                userMessage = "<br/>Name :" + Name;
                userMessage = userMessage + "<br/>Email Id: " + Email;
                userMessage = userMessage + "<br/>Message: " + Message;
                string Body = "Hi, <br/><br/> A new enquiry by user. Detail is as follows:<br/><br/> " + userMessage + "<br/><br/>Thanks";


                mail.Body = Body;
                mail.IsBodyHtml = true;

                SmtpClient smtp = new SmtpClient();
                //SMTP Server Address of gmail
                smtp.Host = "smtp.live.com";
                smtp.Port = 587;
                smtp.Credentials = new System.Net.NetworkCredential("yasseraliammar@hotmail.com", "Yuo1ehlonwc");
                // Smtp Email ID and Password For authentication
                smtp.EnableSsl = true;
                smtp.Send(mail);
                ViewBag.Message = "Thank you for contacting us.";
            }
            catch
            {
                ViewBag.Message = "Error............";
            }

            return View();
        }
    

    

            public ActionResult Teams()
        {
            ViewBag.Message = "Your Teams page.";

            return View();
        }

        public ActionResult Donate()
        {
            ViewBag.Message = "Your Teams page.";

            return View();
        }
    }
}