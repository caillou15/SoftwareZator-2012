// *****************************************************************************
// 
//  � Veler Software 2012. All rights reserved.
//  The current code and the associated software are the proprietary 
//  information of Etienne Baudoux from Veler Software and are
//  supplied subject to licence terms.
// 
//  www.velersoftware.com
// *****************************************************************************

using System.Drawing;
using System.Windows.Forms;

namespace VelerSoftware.SZC.TreeViewAdv.Tree
{
    internal class ResizeColumnState : ColumnState
    {
        private Point _initLocation;
        private int _initWidth;

        public ResizeColumnState(TreeViewAdv tree, TreeColumn column, Point p)
            : base(tree, column)
        {
            _initLocation = p;
            _initWidth = column.Width;
        }

        public override void KeyDown(KeyEventArgs args)
        {
            args.Handled = true;
            if (args.KeyCode == Keys.Escape)
                FinishResize();
        }

        public override void MouseDown(TreeNodeAdvMouseEventArgs args)
        {
        }

        public override void MouseUp(TreeNodeAdvMouseEventArgs args)
        {
            FinishResize();
        }

        private void FinishResize()
        {
            Tree.ChangeInput();
            Tree.FullUpdate();
            Tree.OnColumnWidthChanged(Column);
        }

        public override bool MouseMove(MouseEventArgs args)
        {
            Column.Width = _initWidth + args.Location.X - _initLocation.X;
            Tree.UpdateView();
            return true;
        }
    }
}