using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class EmailLogger : ILogger
    {
        public void Handle(string error)
        {
            // log errors to event viewer
        }
    }
}
