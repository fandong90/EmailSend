using System;
using System.Collections.Generic;

namespace Email.Toolkit
{
    public class EmailHelper:IEmailHelper
    {
        public EmailHelper()
        {
            
        }

        public void SendEmail(ICollection<EmailEntry> emailEntries)
        {
            foreach(var item in emailEntries){
                Console.WriteLine(item.ToString());
            }
        }
    }
}
