using System;

namespace SalesWebMvc.Services.Exceptions
{
    public class DbConcurrentyException : ApplicationException
    {
        public DbConcurrentyException(string message) : base(message)
        {
             
        }
    }
}
