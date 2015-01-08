using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Payroll
{
    public class StaticConsole : ConsoleApp
    {
        public void WriteLine(string message, params object[] args)
        {
            Console.WriteLine(message, args);
        }
    }
}
