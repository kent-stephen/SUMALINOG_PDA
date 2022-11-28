using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUMALINOG_PDA
{
    public class Context
    {
        IPDAChecking pdaChecking;

        public Context(IPDAChecking pdaChecking)
        {
            this.pdaChecking = pdaChecking;
        }

        public string CheckInput(string text)
        {
            return pdaChecking.Checking(text);
        }
    }
}
