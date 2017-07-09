using System;
using System.Collections.Generic;
namespace Email.Toolkit
{
    public class Context
    {
		public delegate void EmitHandler(object sender, EmailEventArgs e);
		public event EmitHandler emit;
        public Context()
        {
            
        }
        /// <summary>
        /// Write the specified emailCollection.
        /// </summary>
        /// <returns>The write.</returns>
        /// <param name="emailCollection">Email collection.</param>
        /// <typeparam name="T">The 1st type parameter.</typeparam>
        public void Write(ICollection<EmailEntry> emailCollection){

            //to-do
            Console.Write("wirte 执行类。。。");
            EmailEventArgs ea = new EmailEventArgs(emailCollection);


        }
        public void Write(EmailEntry email){
            Console.Write("write 执行类。。。");
            EmailEventArgs ea = new EmailEventArgs(email);

            emit(this, ea);
        }
    }
}
