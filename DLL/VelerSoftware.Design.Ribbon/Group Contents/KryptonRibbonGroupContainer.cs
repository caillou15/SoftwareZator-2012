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
using System.Text;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.ComponentModel;
using System.Windows.Forms;
using System.Diagnostics;
using VelerSoftware.Design.Toolkit;

namespace VelerSoftware.Design.Ribbon
{
    /// <summary>
    /// Represents the base class for all ribbon group containers.
    /// </summary>
    [ToolboxItem(false)]
    [DesignerCategory("code")]
    [DesignTimeVisible(false)]
    public abstract class KryptonRibbonGroupContainer : KryptonRibbonGroupItem,
                                                        IRibbonGroupContainer
    {
        #region Instance Fields
        private KryptonRibbonGroup _ribbonGroup;
        #endregion

        #region Identity
        /// <summary>
        /// Initialise a new instance of the KryptonRibbonGroupContainer class.
        /// </summary>
        public KryptonRibbonGroupContainer()
        {
        }
        #endregion

        #region Public
        /// <summary>
        /// Gets access to the parent group instance.
        /// </summary>
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public virtual KryptonRibbonGroup RibbonGroup
        {
            get { return _ribbonGroup; }
            set { _ribbonGroup = value; }
        }

        /// <summary>
        /// Gets an array of all the contained components.
        /// </summary>
        /// <returns>Array of child components.</returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public virtual Component[] GetChildComponents()
        {
            return new Component[] { };
        }
        #endregion
    }
}
