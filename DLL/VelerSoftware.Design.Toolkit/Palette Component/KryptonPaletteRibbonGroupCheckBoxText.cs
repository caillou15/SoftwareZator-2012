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
using System.Drawing;
using System.Drawing.Design;
using System.Windows.Forms;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Collections.Generic;

namespace VelerSoftware.Design.Toolkit
{
	/// <summary>
	/// Storage for palette ribbon group button text states.
	/// </summary>
    public class KryptonPaletteRibbonGroupCheckBoxText : KryptonPaletteRibbonGroupBaseText
    {
        #region Identity
        /// <summary>
        /// Initialize a new instance of the KryptonPaletteRibbonGroupCheckBoxText class.
		/// </summary>
        /// <param name="redirect">Redirector to inherit values from.</param>
        /// <param name="needPaint">Delegate for notifying paint requests.</param>
        public KryptonPaletteRibbonGroupCheckBoxText(PaletteRedirect redirect,
                                                     NeedPaintHandler needPaint)
            : base(redirect, PaletteRibbonTextStyle.RibbonGroupCheckBoxText, needPaint)
		{
        }
        #endregion
    }
}
