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
    /// Delegate used for hooking into a KryptonRibbonContext typed collection.
    /// </summary>
    public delegate void RibbonContextHandler(object sender, TypedCollectionEventArgs<KryptonRibbonContext> e);

    /// <summary>
    /// Specialise the generic collection with type specific rules for context item accessor.
    /// </summary>
    public class KryptonRibbonContextCollection : TypedCollection<KryptonRibbonContext>
    {
        #region Public
        /// <summary>
        /// Gets the item with the provided unique name.
        /// </summary>
        /// <param name="name">Name of the ribbon context instance.</param>
        /// <returns>Item at specified index.</returns>
        public override KryptonRibbonContext this[string name]
        {
            get
            {
                // Search for a context with the same name as that requested.
                foreach (KryptonRibbonContext context in this)
                    if (context.ContextName == name)
                        return context;

                // Let base class perform standard processing
                return base[name];
            }
        }
        #endregion
    }
}
