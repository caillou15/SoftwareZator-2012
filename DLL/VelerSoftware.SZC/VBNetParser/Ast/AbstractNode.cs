﻿// *****************************************************************************
// 
//  © Veler Software 2012. All rights reserved.
//  The current code and the associated software are the proprietary 
//  information of Etienne Baudoux from Veler Software and are
//  supplied subject to licence terms.
// 
//  www.velersoftware.com
// *****************************************************************************




using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace VelerSoftware.SZC.VBNetParser.Ast
{
    public abstract class AbstractNode : INode
    {
        List<INode> children = new List<INode>();

        public INode Parent { get; set; }

        public Location StartLocation { get; set; }

        public Location EndLocation { get; set; }

        public object UserData { get; set; }

        public List<INode> Children
        {
            get
            {
                return children;
            }
            set
            {
                Debug.Assert(value != null);
                children = value;
            }
        }

        public virtual void AddChild(INode childNode)
        {
            Debug.Assert(childNode != null);
            childNode.Parent = this;
            children.Add(childNode);
        }

        public abstract object AcceptVisitor(IAstVisitor visitor, object data);

        public virtual object AcceptChildren(IAstVisitor visitor, object data)
        {
            foreach (INode child in children)
            {
                Debug.Assert(child != null);
                child.AcceptVisitor(visitor, data);
            }
            return data;
        }

        public static string GetCollectionString(ICollection collection)
        {
            StringBuilder output = new StringBuilder();
            output.Append('{');

            if (collection != null)
            {
                IEnumerator en = collection.GetEnumerator();
                bool isFirst = true;
                while (en.MoveNext())
                {
                    if (!isFirst)
                    {
                        output.Append(", ");
                    }
                    else
                    {
                        isFirst = false;
                    }
                    output.Append(en.Current == null ? "<null>" : en.Current.ToString());
                }
            }
            else
            {
                return "null";
            }

            output.Append('}');
            return output.ToString();
        }
    }
}