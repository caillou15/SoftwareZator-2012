// *****************************************************************************
// 
//  � Veler Software 2012. All rights reserved.
//  The current code and the associated software are the proprietary 
//  information of Etienne Baudoux from Veler Software and are
//  supplied subject to licence terms.
// 
//  www.velersoftware.com
// *****************************************************************************

// <file>
//     <copyright see="prj:///doc/copyright.txt"/>
//     <license see="prj:///doc/license.txt"/>
//     <author name="Daniel Grunwald"/>
//     <version>$Revision: 4142 $</version>
// </file>

using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.TextFormatting;

namespace VelerSoftware.SZC35.Rendering
{
	sealed class GlobalTextRunProperties : TextRunProperties
	{
		internal Typeface typeface;
		internal double fontRenderingEmSize;
		internal Brush foregroundBrush;
        internal Brush backgroundBrush = null;
		internal System.Globalization.CultureInfo cultureInfo;
		
		public override Typeface Typeface { get { return typeface; } }
		public override double FontRenderingEmSize { get { return fontRenderingEmSize; } }
		public override double FontHintingEmSize { get { return fontRenderingEmSize; } }
		public override TextDecorationCollection TextDecorations { get { return null; } }
		public override Brush ForegroundBrush { get { return foregroundBrush; } }
		public override Brush BackgroundBrush { get { return backgroundBrush; } }
		public override System.Globalization.CultureInfo CultureInfo { get { return cultureInfo; } }
		public override TextEffectCollection TextEffects { get { return null; } }
	}
}
