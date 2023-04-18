using HuzurELiProjesi.Models;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HuzurELiProjesi.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MailController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        } 

        [HttpPost]
        public IActionResult Index(MailRequest mailRequest )
        {
            MimeMessage mimeMessage = new MimeMessage();

            MailboxAddress mailboxAddressFrom = new MailboxAddress("Admin", "denmarkli@outlook.com");
           
            mimeMessage.From.Add(mailboxAddressFrom);

            var userName = TempData["userName"].ToString();


            MailboxAddress mailboxAddressTo = new MailboxAddress(userName, mailRequest.ReceiverMail);
            
            mimeMessage.To.Add(mailboxAddressTo);

            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = mailRequest.Body;
            mimeMessage.Body = bodyBuilder.ToMessageBody();
            mimeMessage.Subject = mailRequest.Subject;

            SmtpClient client = new SmtpClient();
            client.Connect("smtp.office365.com", 587);
            client.Authenticate("denmarkli@outlook.com", "qhipqqrhdlentoaD");
            client.Send(mimeMessage);
            client.Disconnect(true);
            return View();
        }
    }
}
