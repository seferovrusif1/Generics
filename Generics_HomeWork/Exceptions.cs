using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_HomeWork
{
    internal class Exceptions : Exception
    {
        public Exceptions(string? message) : base(message)
        {
        }
    }
}
