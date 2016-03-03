﻿// *****************************************************************************
// 
//  © Veler Software 2012. All rights reserved.
//  The current code and the associated software are the proprietary 
//  information of Etienne Baudoux from Veler Software and are
//  supplied subject to licence terms.
// 
//  www.velersoftware.com
// *****************************************************************************




using System;

namespace VelerSoftware.SZC.Debugger.Debugger.MetaData
{
    public class DebugLocalVariableInfo : System.Reflection.LocalVariableInfo
    {
        ValueGetter getter;
        int localIndex;
        DebugType localType;

        /// <inheritdoc/>
        public override int LocalIndex
        {
            get { return localIndex; }
        }

        /// <inheritdoc/>
        public override Type LocalType
        {
            get { return localType; }
        }

        /// <inheritdoc/>
        public override bool IsPinned
        {
            get { throw new NotSupportedException(); }
        }

        public string Name { get; internal set; }

        /// <summary> IL offset of the start of the variable scope (inclusive) </summary>
        public int StartOffset { get; private set; }

        /// <summary> IL offset of the end of the variable scope (exclusive) </summary>
        public int EndOffset { get; private set; }

        public bool IsThis { get; internal set; }

        public bool IsCaptured { get; internal set; }

        public DebugLocalVariableInfo(string name, int localIndex, int startOffset, int endOffset, DebugType localType, ValueGetter getter)
        {
            this.Name = name;
            this.localIndex = localIndex;
            this.StartOffset = startOffset;
            this.EndOffset = endOffset;
            this.localType = localType;
            this.getter = getter;
        }

        public Value GetValue(StackFrame context)
        {
            return getter(context);
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            string msg = this.LocalType + " " + this.Name;
            if (IsCaptured)
                msg += " (captured)";
            return msg;
        }
    }
}