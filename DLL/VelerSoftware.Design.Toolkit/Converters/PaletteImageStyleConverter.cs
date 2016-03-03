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

namespace VelerSoftware.Design.Toolkit
{
    /// <summary>
    /// Custom type converter so that PaletteImageStyle values appear as neat text at design time.
    /// </summary>
    internal class PaletteImageStyleConverter : StringLookupConverter
    {
        #region Static Fields
        private Pair[] _pairs = new Pair[] { new Pair(PaletteImageStyle.Inherit,        "Inherit"),
                                             new Pair(PaletteImageStyle.Stretch,        "Stretch"),
                                             new Pair(PaletteImageStyle.Tile,           "Tile"),
                                             new Pair(PaletteImageStyle.TileFlipX,      "TileFlip - X"),
                                             new Pair(PaletteImageStyle.TileFlipY,      "TileFlip - Y"),
                                             new Pair(PaletteImageStyle.TileFlipXY,     "TileFlip - XY"),
                                             new Pair(PaletteImageStyle.TopLeft,        "Top - Left"),
                                             new Pair(PaletteImageStyle.TopMiddle,      "Top - Middle"),
                                             new Pair(PaletteImageStyle.TopRight,       "Top - Right"),
                                             new Pair(PaletteImageStyle.CenterLeft,     "Center - Left"),
                                             new Pair(PaletteImageStyle.CenterMiddle,   "Center - Middle"),
                                             new Pair(PaletteImageStyle.CenterRight,    "Center - Right"),
                                             new Pair(PaletteImageStyle.BottomLeft,     "Bottom - Left"),
                                             new Pair(PaletteImageStyle.BottomMiddle,   "Bottom - Middle"),
                                             new Pair(PaletteImageStyle.BottomRight,    "Bottom - Right") };
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the PaletteImageStyleConverter clas.
        /// </summary>
        public PaletteImageStyleConverter()
            : base(typeof(PaletteImageStyle))
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
