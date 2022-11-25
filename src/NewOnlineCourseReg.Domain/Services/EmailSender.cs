using NewOnlineCourseReg.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewOnlineCourseReg.Domain.Services
{
    internal class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email)
        {
            //  throw new NotImplementedException();
            return Task.CompletedTask;
        }
    }
}
