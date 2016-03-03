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
using System.Windows.Forms;
using System.ComponentModel;
using System.ComponentModel.Design;

namespace VelerSoftware.Design.Toolkit
{
    /// <summary>
    /// CollectionEditor used for a KryptonContextMenuItemCollection instance.
    /// </summary>
	public class KryptonContextMenuItemCollectionEditor : CollectionEditor
	{
		/// <summary>
        /// Initialize a new instance of the KryptonContextMenuItemCollectionEditor class.
		/// </summary>
        public KryptonContextMenuItemCollectionEditor()
            : base(typeof(KryptonContextMenuItemCollection))
		{
		}

		/// <summary>
		/// Gets the data types that this collection editor can contain. 
		/// </summary>
		/// <returns>An array of data types that this collection can contain.</returns>
		protected override Type[] CreateNewItemTypes()
		{
            return new Type[] { typeof(KryptonContextMenuItem),
                                typeof(KryptonContextMenuSeparator),
                                typeof(KryptonContextMenuHeading) };
		}
	}
}
