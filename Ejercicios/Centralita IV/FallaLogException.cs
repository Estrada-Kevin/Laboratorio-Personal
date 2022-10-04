﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Centralita_IV
{
    public class FallaLogException : Exception
    {
        public FallaLogException()
        {
        }

        public FallaLogException(string message) : base(message)
        {
        }

        public FallaLogException(string message, Exception innerException) : base(message, innerException)
        {
        }

    }
}
