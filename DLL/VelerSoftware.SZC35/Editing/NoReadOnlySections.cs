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
using System.Linq;
using System.Collections.Generic;
using VelerSoftware.SZC35.Document;
using VelerSoftware.SZC35.Utils;

namespace VelerSoftware.SZC35.Editing
{
	/// <summary>
	/// <see cref="IReadOnlySectionProvider"/> that has no read-only sections; all text is editable.
	/// </summary>
	sealed class NoReadOnlySections : IReadOnlySectionProvider
	{
		public static readonly NoReadOnlySections Instance = new NoReadOnlySections();
		
		public bool CanInsert(int offset)
		{
			return true;
		}
		
		public IEnumerable<ISegment> GetDeletableSegments(ISegment segment)
		{
			if (segment == null)
				throw new ArgumentNullException("segment");
			// the segment is always deletable
			return ExtensionMethods.Sequence(segment);
		}
	}
	
	/// <summary>
	/// <see cref="IReadOnlySectionProvider"/> that completely disables editing.
	/// </summary>
	sealed class ReadOnlyDocument : IReadOnlySectionProvider
	{
		public static readonly ReadOnlyDocument Instance = new ReadOnlyDocument();
		
		public bool CanInsert(int offset)
		{
			return false;
		}
		
		public IEnumerable<ISegment> GetDeletableSegments(ISegment segment)
		{
			return Enumerable.Empty<ISegment>();
		}
	}
}
