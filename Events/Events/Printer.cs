using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class Printer
    {
        public event EventHandler PrintStarted;
        public event EventHandler Printing;
        public event EventHandler PrintFinished;


    }
}
