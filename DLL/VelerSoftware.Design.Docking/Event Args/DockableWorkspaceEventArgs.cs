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
    /// Event arguments for a DockableWorkspaceRemoved event.
	/// </summary>
	public class DockableWorkspaceEventArgs : EventArgs
	{
		#region Instance Fields
        private KryptonDockableWorkspace _workspace;
        private KryptonDockingWorkspace _element;
		#endregion

		#region Identity
		/// <summary>
        /// Initialize a new instance of the DockableWorkspaceEventArgs class.
		/// </summary>
        /// <param name="workspace">Reference to dockable workspace control instance.</param>
        /// <param name="element">Reference to docking workspace element that is managing the dockable workspace control.</param>
        public DockableWorkspaceEventArgs(KryptonDockableWorkspace workspace,
                                          KryptonDockingWorkspace element)
		{
            _workspace = workspace;
            _element = element;
		}
        #endregion

		#region Public
        /// <summary>
        /// Gets a reference to the KryptonDockableWorkspace control.
        /// </summary>
        public KryptonDockableWorkspace DockableWorkspaceControl
        {
            get { return _workspace; }
        }

        /// <summary>
        /// Gets a reference to the KryptonDockingWorkspace that is managing the dockable workspace control.
        /// </summary>
        public KryptonDockingWorkspace DockingWorkspaceElement
        {
            get { return _element; }
        }
        #endregion
	}
}
