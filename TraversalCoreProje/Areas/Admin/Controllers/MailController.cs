using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using TraversalCoreProje.Models;

namespace TraversalCoreProje.Areas.Admin.Controllers;
[Area("Admin")]
public class MailController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index(MailRequest mailRequest)
    {
        MimeMessage mimeMessage = new MimeMessage();
        MailboxAddress MailboxAddressFrom = new MailboxAddress("Admin","deneme250405@gmail.com");
      
        mimeMessage.From.Add(MailboxAddressFrom);
       MailboxAddress mailboxAddressTo = new MailboxAddress("User", mailRequest.ReceiverMail);
       mimeMessage.To.Add(mailboxAddressTo);
       var bodyBuilder = new BodyBuilder();
       bodyBuilder.TextBody = mailRequest.Body;
       mimeMessage.Body = bodyBuilder.ToMessageBody();
       
       mimeMessage.Subject = mailRequest.Subject;

       SmtpClient client = new SmtpClient();
       client.Connect("smtp.gmail.com",587,false); 
        client.Authenticate("deneme250405@gmail.com","Halime121.");
       client.Send(mimeMessage);
       client.Disconnect(true);
       return View();
    }
    
}
//deneme250405@gmail.com