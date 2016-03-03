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
using System.Text;
using VelerSoftware.SZC.Debugger.Debugger;
using VelerSoftware.SZC.VBNetParser.Ast;

namespace VelerSoftware.SZC.Debugger.TreeModel
{
    public partial class Utils
    {
        public static IEnumerable<TreeNode> LazyGetChildNodesOfArray(Expression expression, ArrayDimensions dimensions)
        {
            if (dimensions.TotalElementCount == 0)
                return new TreeNode[] { new TreeNode(null, "(empty)", null, null, null) };

            return new ArrayRangeNode(expression, dimensions, dimensions).ChildNodes;
        }
    }

    /// <summary> This is a partent node for all elements within a given bounds </summary>
    public class ArrayRangeNode : TreeNode
    {
        const int MaxElementCount = 100;

        Expression arrayTarget;
        ArrayDimensions bounds;
        ArrayDimensions originalBounds;

        public ArrayRangeNode(Expression arrayTarget, ArrayDimensions bounds, ArrayDimensions originalBounds)
        {
            this.arrayTarget = arrayTarget;
            this.bounds = bounds;
            this.originalBounds = originalBounds;

            this.Name = GetName();
            this.ChildNodes = LazyGetChildren();
        }

        private string GetName()
        {
            StringBuilder name = new StringBuilder();
            bool isFirst = true;
            name.Append("[");
            for (int i = 0; i < bounds.Count; i++)
            {
                if (!isFirst) name.Append(", ");
                isFirst = false;
                ArrayDimension dim = bounds[i];
                ArrayDimension originalDim = originalBounds[i];

                if (dim.Count == 0)
                {
                    throw new DebuggerException("Empty dimension");
                }
                else if (dim.Count == 1)
                {
                    name.Append(dim.LowerBound.ToString());
                }
                else if (dim.Equals(originalDim))
                {
                    name.Append("*");
                }
                else
                {
                    name.Append(dim.LowerBound);
                    name.Append("..");
                    name.Append(dim.UpperBound);
                }
            }
            name.Append("]");
            return name.ToString();
        }

        private static string GetName(int[] indices)
        {
            StringBuilder sb = new StringBuilder(indices.Length * 4);
            sb.Append("[");
            bool isFirst = true;
            foreach (int index in indices)
            {
                if (!isFirst) sb.Append(", ");
                sb.Append(index.ToString());
                isFirst = false;
            }
            sb.Append("]");
            return sb.ToString();
        }

        private IEnumerable<TreeNode> LazyGetChildren()
        {
            // The whole array is small - just add all elements as childs
            if (bounds.TotalElementCount <= MaxElementCount)
            {
                foreach (int[] indices in bounds.Indices)
                {
                    yield return new ExpressionNode(ExpressionNode.GetImageForArrayIndexer(), GetName(indices), arrayTarget.AppendIndexer(indices));
                }
                yield break;
            }

            // Find a dimension of size at least 2
            int splitDimensionIndex = bounds.Count - 1;
            for (int i = 0; i < bounds.Count; i++)
            {
                if (bounds[i].Count > 1)
                {
                    splitDimensionIndex = i;
                    break;
                }
            }
            ArrayDimension splitDim = bounds[splitDimensionIndex];

            // Split the dimension
            int elementsPerSegment = 1;
            while (splitDim.Count > elementsPerSegment * MaxElementCount)
            {
                elementsPerSegment *= MaxElementCount;
            }
            for (int i = splitDim.LowerBound; i <= splitDim.UpperBound; i += elementsPerSegment)
            {
                List<ArrayDimension> newDims = new List<ArrayDimension>(bounds);
                newDims[splitDimensionIndex] = new ArrayDimension(i, Math.Min(i + elementsPerSegment - 1, splitDim.UpperBound));
                yield return new ArrayRangeNode(arrayTarget, new ArrayDimensions(newDims), originalBounds);
            }
            yield break;
        }
    }
}