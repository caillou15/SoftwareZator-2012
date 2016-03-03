﻿// *****************************************************************************
// 
//  © Component Factory Pty Ltd 2010. All rights reserved.
//	The software and associated documentation supplied hereunder are the 
//  proprietary information of Component Factory Pty Ltd, 17/267 Nepean Hwy, 
//  Seaford, Vic 3198, Australia and are supplied subject to licence terms.
// 
//  Version 4.3.1.0 	www.ComponentFactory.com
// *****************************************************************************

using System;
using System.Threading;

namespace VelerSoftware.Design.Toolkit
{
    internal class OperationThread : GlobalId
    {
        #region Instance Fields
        private Operation _op;
        private object _parameter;
        private int _state;
        private object _result;
        private Exception _exception;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the OperationThread class.
        /// </summary>
        /// <param name="op">Operation to perform on thread.</param>
        /// <param name="parameter">Parameter to pass into operation.</param>
        public OperationThread(Operation op, object parameter)
        {
            // Remember the passed operation details
            _op = op;
            _parameter = parameter;

            // Operation still running
            _state = 0;
        }
        #endregion

        #region Properties
        /// <summary>
        /// Gets the current operation state.
        /// </summary>
        public int State
        {
            get 
            {
                int ret;

                // Read the state in a thread state way
                lock (this)
                    ret = _state;

                return ret; 
            }
        }

        /// <summary>
        /// Gets the result from the operation.
        /// </summary>
        public object Result
        {
            get { return _result; }
        }

        /// <summary>
        /// Gets the exception generated by operation.
        /// </summary>
        public Exception Exception
        {
            get { return _exception; }
        }
        #endregion

        #region Run
        /// <summary>
        /// Entry point for performing operation.
        /// </summary>
        public void Run()
        {
            try
            {
                // Execute the operation
                _result = _op(_parameter);

                // Success
                lock(this)
                    _state = 1;
            }
            catch(Exception ex)
            {
                // Remember the exception details
                _exception = ex;

                // Failed with exception
                lock(this)
                    _state = 2;
            }
        }
        #endregion
    }
}
