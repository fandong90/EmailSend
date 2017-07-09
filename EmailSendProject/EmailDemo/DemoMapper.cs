using System;
using Email.Toolkit;
namespace EmailDemo
{
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
}
