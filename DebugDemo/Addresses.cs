using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebugExample
{

    [DebuggerDisplay("Street = {Street}")]
    internal class Addresses
    {
        public Addresses(string street)
        {
            Street = street;
        }
        public string Street { get; set; }
    }
}
