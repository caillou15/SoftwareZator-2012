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
using System.ComponentModel;
using VelerSoftware.Design.Toolkit;
using VelerSoftware.Design.Navigator;

namespace VelerSoftware.Design.Docking
{
	/// <summary>
    /// Event arguments for cancellable events that need to provide a unique name and context menu.
	/// </summary>
    public class CancelDropDownEventArgs : CancelEventArgs
	{
		#region Instance Fields
        private KryptonContextMenu _contextMenu;
        private KryptonPage _page;
		#endregion

		#region Identity
		/// <summary>
        /// Initialize a new instance of the CancelDropDownEventArgs class.
		/// </summary>
        /// <param name="contextMenu">Reference to associated context menu.</param>
        /// <param name="page">Reference to the associated page.</param>
        public CancelDropDownEventArgs(KryptonContextMenu contextMenu, KryptonPage page)
            : base(false)
		{
            _contextMenu = contextMenu;
            _page = page;
		}
        #endregion

		#region Public
        /// <summary>
        /// Gets a reference to the context menu.
        /// </summary>
        public KryptonContextMenu KryptonContextMenu
        {
            get { return _contextMenu; }
        }

        /// <summary>
        /// Gets a reference to the page.
        /// </summary>
        public KryptonPage Page
        {
            get { return _page; }
        }
        #endregion
	}
}
