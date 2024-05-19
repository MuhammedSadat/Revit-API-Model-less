using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERevit.RevitSystem
{
    // RevitRequestHandler.cs
    public static class RevitRequestHandler
    {
        private static RevitRequestType _request = RevitRequestType.None;
        private static readonly object lockObject = new object();

        public static RevitRequestType Request
        {
            get { lock (lockObject) return _request; }
            set { lock (lockObject) _request = value; }
        }
    }

    public enum RevitRequestType { None, Command1, Command2 }
}
