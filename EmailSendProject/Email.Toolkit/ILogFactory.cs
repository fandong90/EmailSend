using System;
namespace Email.Toolkit
{
    public interface ILogFactory
    {
        void  Write<T>(T log);

    }
}
