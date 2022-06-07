using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2Mac1.Costino.Core.Exceptions
{
    public class ResourceNotFoundException : Exception
    {
        public ResourceNotFoundException(string? message) : base(message) { }
        public ResourceNotFoundException(Type type) : base($"{type} is missing") { }
    }
}
