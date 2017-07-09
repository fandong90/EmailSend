using System;
using Email.Toolkit;
namespace EmailDemo
{
    public class DemoMapperFirst:Mapper
    {
        public DemoMapperFirst()
        {
        }

        public override bool Step()
        {
            return base.Step();
        }
        public override void Map(Context context)
        {
			// base.Map(context);
			EmailEntry ee = new EmailEntry();
			ee.CC = new string[] { "test2" };
			ee.BCC = new string[] { "teset2" };
			ee.To = new string[] { "test2" };
			ee.Subject = "hehe2";
			ee.Context = "context2";
			context.Write(ee);
        }

        public override void CleanUp()
        {
            base.CleanUp();
        }
    }
}
