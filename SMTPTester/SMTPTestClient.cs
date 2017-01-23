using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SMTPTester
{
    internal class SMTPTestClient
    {
        public async void SendMailAsync()
        {
            var x = await SendEmailAsync();
        }

        public async Task<bool> SendEmailAsync()
        {
            //await Task.Delay(1);
            return true;
        }
    }
}