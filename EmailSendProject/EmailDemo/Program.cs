using System;
using Email.Toolkit;
namespace EmailDemo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            IEmailHelper emailHelper = new EmailHelper();
            Tool tool = new Tool(emailHelper);
            tool.Run();
		   // tool.RunDebug("/Users/fandong/Projects/EmailSendProject/EmailDemo/bin/Debug/EmailDemo.exe","EmailDemo.DemoMapper");
		}
    }
}
