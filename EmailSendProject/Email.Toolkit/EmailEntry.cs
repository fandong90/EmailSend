using System;
using System.Collections.Generic;
namespace Email.Toolkit
{
    public class EmailEntry
    {
        /// <summary>
        /// 发送人
        /// </summary>
        /// <value>To.</value>
        public string[] To { get; set; }
        /// <summary>
        /// 抄送人
        /// </summary>
        /// <value>The cc.</value>
        public string[] CC { get; set; }

        /// <summary>
        /// 密送
        /// </summary>
        /// <value>The bcc.</value>
        public string[] BCC { get; set; }


        public string Subject { get; set; }


        public string Context { get; set; }

        public override string ToString()
        {
            
            return string.Format("[EmailEntry: To={0}, CC={1}, BCC={2}, Subject={3}, Context={4}]", To, CC, BCC, Subject, Context);
        }
    }
}
