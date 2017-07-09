using System;
using System.Collections.Generic;
namespace Email.Toolkit
{
    public class EmailEventArgs:EventArgs
    {
        private List<EmailEntry> _emailEntries;
        public EmailEventArgs(ICollection<EmailEntry> emailEntries)
        {
            this._emailEntries = new List<EmailEntry>();
            this._emailEntries.AddRange(emailEntries); 
        }

        public EmailEventArgs(EmailEntry emailEntry){

            this._emailEntries = new List<EmailEntry>();
            this._emailEntries.Add(emailEntry);
        }

        /// <summary>
        /// Gets or sets the email entries.
        /// </summary>
        /// <value>The email entries.</value>
        public List<EmailEntry> EmailEntries(){
            return this._emailEntries;
        }

    }
}
