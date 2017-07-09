using System;
using System.Collections.Generic;
namespace Email.Toolkit
{
    public interface IEmailHelper
    {
        /// <summary>
        /// Sends the email.
        /// </summary>
        /// <param name="emailEntries">Email entries.</param>
        void SendEmail(ICollection<EmailEntry> emailEntries);
    }
}
