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

using VelerSoftware.Design.Toolkit;

namespace VelerSoftware.Design.Navigator
{
    /// <summary>
    /// Custom type converter so that ContextButtonAction values appear as neat text at design time.
    /// </summary>
    public class ContextButtonActionConverter : StringLookupConverter
    {
        #region Static Fields
        private Pair[] _pairs = new Pair[] { new Pair(ContextButtonAction.None,         "None (Do nothing)"),
                                             new Pair(ContextButtonAction.SelectPage,   "Select Page") };
        #endregion
                                             
        #region Identity
        /// <summary>
        /// Initialize a new instance of the ContextButtonActionConverter clas.
        /// </summary>
        public ContextButtonActionConverter()
            : base(typeof(ContextButtonAction))
        {
        }
        #endregion

        #region Protected
        /// <summary>
        /// Gets an array of lookup pairs.
        /// </summary>
        protected override Pair[] Pairs 
        {
            get { return _pairs; }
        }
        #endregion
    }
}
