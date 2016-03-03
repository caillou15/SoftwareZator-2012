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
using System.ComponentModel;
using System.Windows.Forms;
using System.Diagnostics;

namespace VelerSoftware.Design.Toolkit
{
	/// <summary>
	/// Details of the context menu showing related to a bread crumb.
	/// </summary>
    public class BreadCrumbMenuArgs : ContextPositionMenuArgs
	{
		#region Instance Fields
        private KryptonBreadCrumbItem _crumb;
        #endregion

		#region Identity
        /// <summary>
        /// Initialize a new instance of the ContextMenuArgs class.
        /// </summary>
        /// <param name="crumb">Reference to related crumb.</param>
        /// <param name="kcm">KryptonContextMenu that can be customized.</param>
        /// <param name="positionH">Relative horizontal position of the KryptonContextMenu.</param>
        /// <param name="positionV">Relative vertical position of the KryptonContextMenu.</param>
        public BreadCrumbMenuArgs(KryptonBreadCrumbItem crumb,
                                  KryptonContextMenu kcm,
                                  KryptonContextMenuPositionH positionH,
                                  KryptonContextMenuPositionV positionV)
            : base(null, kcm, positionH, positionV)
        {
            _crumb = crumb;
        }
        #endregion

		#region Public
		/// <summary>
        /// Gets and sets the crumb related to the event.
		/// </summary>
        public KryptonBreadCrumbItem Crumb
		{
            get { return _crumb; }
            set { _crumb = value; }
		}
        #endregion
	}
}
