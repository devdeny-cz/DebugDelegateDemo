using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebugExample
{
    [DebuggerDisplay("Name = {FirstName} {LastName}. BirthDate = {BirthDate.ToShortDateString()};")]
    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
        public List<Addresses> Addresses{ get; set; }
    }
}
