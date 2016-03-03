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
//     <version>$Revision: 4626 $</version>
// </file>

using System;
using System.Collections.Generic;
using VelerSoftware.SZC35.Utils;

namespace VelerSoftware.SZC35.Highlighting.Xshd
{
	/// <summary>
	/// A rule set in a XSHD file.
	/// </summary>
	[Serializable]
	public class XshdRuleSet : XshdElement
	{
		/// <summary>
		/// Gets/Sets the name of the rule set.
		/// </summary>
		public string Name { get; set; }
		
		/// <summary>
		/// Gets/sets whether the case is ignored in expressions inside this rule set.
		/// </summary>
		public bool? IgnoreCase { get; set; }
		
		readonly NullSafeCollection<XshdElement> elements = new NullSafeCollection<XshdElement>();
		
		/// <summary>
		/// Gets the collection of elements.
		/// </summary>
		public IList<XshdElement> Elements {
			get { return elements; }
		}
		
		/// <summary>
		/// Applies the visitor to all elements.
		/// </summary>
		public void AcceptElements(IXshdVisitor visitor)
		{
			foreach (XshdElement element in Elements) {
				element.AcceptVisitor(visitor);
			}
		}
		
		/// <inheritdoc/>
		public override object AcceptVisitor(IXshdVisitor visitor)
		{
			return visitor.VisitRuleSet(this);
		}
	}
}
