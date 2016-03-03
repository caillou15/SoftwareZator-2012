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
using System.Drawing.Drawing2D;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;
using VelerSoftware.Design.Toolkit;

namespace VelerSoftware.Design.Ribbon
{
    internal class RibbonRecentDocsShortcutToContent : RibbonRecentDocsEntryToContent
    {
        #region Identity
        /// <summary>
        /// Initialize a new instance of the RibbonRecentDocsShortcutToContent class.
        /// </summary>
        /// <param name="ribbonGeneral">Source for general ribbon settings.</param>
        /// <param name="ribbonRecentDocEntryText">Source for ribbon recent document entry settings.</param>
        public RibbonRecentDocsShortcutToContent(PaletteRibbonGeneral ribbonGeneral,
                                                 IPaletteRibbonText ribbonRecentDocEntryText)
            : base(ribbonGeneral, ribbonRecentDocEntryText)
        {
        }
        #endregion

        #region IPaletteContent
        /// <summary>
        /// Gets the prefix drawing setting for short text.
        /// </summary>
        /// <param name="state">Palette value should be applicable to this state.</param>
        /// <returns>PaletteTextPrefix value.</returns>
        public override PaletteTextHotkeyPrefix GetContentShortTextPrefix(PaletteState state)
        {
            return PaletteTextHotkeyPrefix.Show;
        }
        #endregion
    }
}
