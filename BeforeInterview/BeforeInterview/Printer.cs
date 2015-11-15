using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BeforeInterview
{
    public class Printer
    {
        public event EventHandler<PrinterEventArgs> PrintStarted;

        public void OnPrintStarted(int current, int total)
        {
            if (PrintStarted != null)
            {
               // EventHandler<PrinterEventArgs> del = (EventHandler<PrinterEventArgs>)PrintStarted;
                PrinterEventArgs p = new PrinterEventArgs(){
                    Current = current
                };
            PrintStarted(this, p);
        }

        }

        public void Print()
        {
            for (int i = 0; i < 3; i++)
            {
                Thread.Sleep(1000);
                OnPrintStarted(i + 1, 3);
            }
        }
        
    }
}
