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

        public void Print(int page)
        {
            OnPrintStarted();
            for (int i = 0; i < page; i++)
            {
                OnPrinting();
                Console.WriteLine("Printing: {0} out of {1} ", i+1, page);
            }
            OnPrintFinished();
        }

        public void OnPrintStarted()
        {
            if (PrintStarted != null)
            {
                PrintStarted(this,EventArgs.Empty);
            }
        }

        public void OnPrinting()
        {
            if (Printing != null)
            {
                Printing(this, EventArgs.Empty);
            }
        }

        public void OnPrintFinished()
        {
            if (PrintFinished != null)
            {
                PrintFinished(this, EventArgs.Empty);
            }
        }
    }
}
