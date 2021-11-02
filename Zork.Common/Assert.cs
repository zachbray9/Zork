﻿using System;
using System.Diagnostics;

namespace Zork.Common
{
    public static class Assert
    {
        [Conditional("DEBUG")]
        public static void IsTrue(bool expression, string message = null)
        {
            if(expression != true)
            {
                throw new Exception(message);
            }
        }
    }
}
