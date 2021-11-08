using System;
using System.Collections.Generic;
using System.Text;

namespace Zork.Common
{
    public interface IOutputService
    {
        void Write(object value)
        {
            Console.Write(value);
        }

        void WriteLine(object value)
        {
            Console.WriteLine(value);
        }
    }
}
