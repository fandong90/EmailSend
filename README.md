# EmailSend
Email

 1 各个邮件推送互不影响，使用很简单，就是如果要推送某个邮件发送，只需要继承Mapper类即可，
 
    重要的是要重写其中两个方法，
     1》 Step（）；如果返回true，则执行Map方法。
     2》 Map（Context context） ；核心部分，自定义。需要把发送的邮件写成如下定义即可。
 
 public class DemoMapper:Mapper
    {
        public DemoMapper()
        {
            
        }
        public override bool Step()
        {
            return base.Step();
        }

        public override void Map(Context context)
        {
            //base.Map(context);
            EmailEntry ee = new EmailEntry();
            ee.CC = new string[] { "test" };
            ee.BCC = new string[] { "teset" };
            ee.To = new string[]{"test"};
			      ee.Subject = "hehe";
		      	ee.Context = "context";
            context.Write(ee);

			//int a = 3;
			//int b = 0;
			//int c = a / b;
			//Console.WriteLine(c);
        }

        public override void CleanUp()
        {
            base.CleanUp();
        }
    }
2》调试也很方便：
        只需要添加自定义类部分，即可调试，不影响其他已完成的类。
        
	    IEmailHelper emailHelper = new EmailHelper();
            ILogFactory ilogFactory = new LogFactory();
            Tool tool = new Tool(emailHelper,ilogFactory);
            //tool.Run();	            tool.RunDebug("/Users/fandong/Projects/EmailSendProject/EmailDemo/bin/Debug/EmailDemo.exe","EmailDemo.DemoMapper");
3》扩展方便：
       只要实现以上接口，即可轻松扩展。
       
4》 后续扩展，在调试的类上搭上Debug，即可调试，不需要在更改
   其他设置
。

