﻿// *****************************************************************************
// 
//  © Veler Software 2012. All rights reserved.
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
//     <version>$Revision: 5529 $</version>
// </file>

using System;
using System.Windows.Media;
using VelerSoftware.SZC35.Document;

namespace VelerSoftware.SZC35.Snippets
{
	/// <summary>
	/// Represents an active element that allows the snippet to stay interactive after insertion.
	/// </summary>
	public interface IActiveElement
	{
		/// <summary>
		/// Called when the all snippet elements have been inserted.
		/// </summary>
		void OnInsertionCompleted();
		
		/// <summary>
		/// Called when the interactive mode is deactivated.
		/// </summary>
		void Deactivate();
		
		/// <summary>
		/// Gets whether this element is editable (the user will be able to select it with Tab).
		/// </summary>
		bool IsEditable { get; }
		
		/// <summary>
		/// Gets the segment associated with this element. May be null.
		/// </summary>
		ISegment Segment { get; }
	}
}
