using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Payroll
{
    public interface ConsoleApp
    {
        void WriteLine(string message, params object[] args);
    }
}
