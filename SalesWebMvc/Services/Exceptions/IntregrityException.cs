using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Services.Exceptions
{
    public class IntregrityException : ApplicationException
    {
        public IntregrityException(string message) : base(message)
        {

        }
    }
}
