using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewOnlineCourseReg.Domain.Interfaces
{
    internal interface IEmailSender
    {
        Task SendEmailAsync(string email);
    }
}
