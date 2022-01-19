using System;
using System.Collections.Generic;
using System.Text;

namespace Treinamento2.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {
        }
    }
}
