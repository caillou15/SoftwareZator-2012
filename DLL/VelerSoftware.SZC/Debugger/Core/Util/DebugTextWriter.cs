﻿// *****************************************************************************
// 
//  © Veler Software 2012. All rights reserved.
//  The current code and the associated software are the proprietary 
//  information of Etienne Baudoux from Veler Software and are
//  supplied subject to licence terms.
// 
//  www.velersoftware.com
// *****************************************************************************




using System.Diagnostics;
using System.IO;
using System.Text;

namespace VelerSoftware.SZC.Debugger.Core
{
    /// <summary>
    /// TextWriter that writes into System.Diagnostics.Debug
    /// </summary>
    public class DebugTextWriter : TextWriter
    {
        public override Encoding Encoding
        {
            get
            {
                return Encoding.Unicode;
            }
        }

        public override void Write(char value)
        {
            Debug.Write(value.ToString());
        }

        public override void Write(char[] buffer, int index, int count)
        {
            Debug.Write(new string(buffer, index, count));
        }

        public override void Write(string value)
        {
            Debug.Write(value);
        }

        public override void WriteLine()
        {
            Debug.WriteLine(string.Empty);
        }

        public override void WriteLine(string value)
        {
            Debug.WriteLine(value);
        }
    }
}