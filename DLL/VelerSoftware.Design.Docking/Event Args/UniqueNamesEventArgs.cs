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
using System.Drawing;
using System.Diagnostics;
using VelerSoftware.Design.Toolkit;
using VelerSoftware.Design.Workspace;

namespace VelerSoftware.Design.Docking
{
	/// <summary>
    /// Event arguments for events that need to provide a set of unique names.
	/// </summary>
	public class UniqueNamesEventArgs : EventArgs
	{
		#region Instance Fields
        private string[] _uniqueNames;
		#endregion

		#region Identity
		/// <summary>
        /// Initialize a new instance of the UniqueNamesEventArgs class.
		/// </summary>
        /// <param name="uniqueNames">Array of unique names.</param>
        public UniqueNamesEventArgs(string[] uniqueNames)
		{
            _uniqueNames = uniqueNames;
		}
        #endregion

		#region Public
        /// <summary>
        /// Gets the array of unique names associated with the event.
        /// </summary>
        public string[] UniqueNames
        {
            get { return _uniqueNames; }
        }
        #endregion
	}
}
