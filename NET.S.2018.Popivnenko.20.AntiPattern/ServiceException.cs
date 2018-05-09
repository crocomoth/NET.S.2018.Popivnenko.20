using System;

namespace NET.S._2018.Popivnenko._20.AntiPattern
{
    public class ServiceException : Exception
    {
        public ServiceException(string message) : base(message)
        {
        }
    }
}
