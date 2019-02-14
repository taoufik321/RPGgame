using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net.Mail;

namespace Portfolio.Pages
{
    public class TestModel : PageModel
    {
        public string ToMail = "taoufik.abou@capgemini.com";

        public string fullName { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }

        public bool IsHtml { get; set; }

        public async Task OnPost()
        {
            using (var smtp = new SmtpClient())
            {
                smtp.DeliveryMethod = SmtpDeliveryMethod.SpecifiedPickupDirectory;
                smtp.PickupDirectoryLocation = @"c:\maildump";

                var message = new MailMessage
                {
                    Body = Request.Form["Message"][0],
                    Subject = "Portfolio question from : " + Request.Form["fullName"][0],
                    From = new MailAddress(Request.Form["Email"][0])
                };

                message.To.Add(ToMail);

                await smtp.SendMailAsync(message);
            }
        }

        public void OnGet()
        {

        }
    }
}