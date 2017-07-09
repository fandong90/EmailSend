using System;
namespace Email.Toolkit
{
    public abstract class LogFactory : ILogFactory
    {
        public void Write<T>(T log)
        {
            throw new NotImplementedException();
        }
    }
}
