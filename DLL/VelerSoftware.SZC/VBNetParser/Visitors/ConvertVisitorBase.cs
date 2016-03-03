﻿// *****************************************************************************
// 
//  © Veler Software 2012. All rights reserved.
//  The current code and the associated software are the proprietary 
//  information of Etienne Baudoux from Veler Software and are
//  supplied subject to licence terms.
// 
//  www.velersoftware.com
// *****************************************************************************




using System;
using System.Collections.Generic;
using VelerSoftware.SZC.VBNetParser.Ast;

namespace VelerSoftware.SZC.VBNetParser.Visitors
{
	/// <summary>
	/// Base class for the conversion visitors.
	/// </summary>
	public class ConvertVisitorBase : AbstractAstTransformer
	{
		// inserting before current position is not allowed in a Transformer
		// but inserting after it is possible
		protected void InsertAfterSibling(INode sibling, INode newNode)
		{
			if (sibling == null || sibling.Parent == null) return;
			int index = sibling.Parent.Children.IndexOf(sibling);
			sibling.Parent.Children.Insert(index + 1, newNode);
			newNode.Parent = sibling.Parent;
		}
		
		List<KeyValuePair<INode, INode>> insertions = new List<KeyValuePair<INode, INode>>();
		
		protected void InsertBeforeSibling(INode sibling, INode newNode)
		{
			if (sibling == null) return;
			if (!(sibling.Parent is TypeDeclaration))
				throw new NotSupportedException();
			insertions.Add(new KeyValuePair<INode, INode>(sibling, newNode));
		}
		
		public override object VisitTypeDeclaration(TypeDeclaration typeDeclaration, object data)
		{
			object result = base.VisitTypeDeclaration(typeDeclaration, data);
			for (int i = 0; i < insertions.Count; i++) {
				if (insertions[i].Key.Parent == typeDeclaration) {
					
					INode sibling = insertions[i].Key;
					INode newNode = insertions[i].Value;
					int index = sibling.Parent.Children.IndexOf(sibling);
					sibling.Parent.Children.Insert(index, newNode);
					newNode.Parent = sibling.Parent;
					
					insertions.RemoveAt(i--);
				}
			}
			return result;
		}
	}
}
