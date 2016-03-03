﻿// *****************************************************************************
// 
//  © Veler Software 2012. All rights reserved.
//  The current code and the associated software are the proprietary 
//  information of Etienne Baudoux from Veler Software and are
//  supplied subject to licence terms.
// 
//  www.velersoftware.com
// *****************************************************************************




using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace VelerSoftware.SZC.Debugger.Base
{
    /// <summary>
    /// Scrolling related helpers.
    /// </summary>
    public static class ScrollUtils
    {
        /// <summary>
        /// Searches VisualTree of given object for a ScrollViewer.
        /// </summary>
        public static ScrollViewer GetScrollViewer(this DependencyObject o)
        {
            var scrollViewer = o as ScrollViewer;
            if (scrollViewer != null)
            {
                return scrollViewer;
            }

            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(o); i++)
            {
                var child = VisualTreeHelper.GetChild(o, i);
                var result = GetScrollViewer(child);
                if (result != null)
                {
                    return result;
                }
            }
            return null;
        }

        /// <summary>
        /// Scrolls ScrollViewer up by given offset.
        /// </summary>
        /// <param name="offset">Offset by which to scroll up. Should be positive.</param>
        public static void ScrollUp(this ScrollViewer scrollViewer, double offset)
        {
            ScrollUtils.ScrollByVerticalOffset(scrollViewer, -offset);
        }

        /// <summary>
        /// Scrolls ScrollViewer down by given offset.
        /// </summary>
        /// <param name="offset">Offset by which to scroll down. Should be positive.</param>
        public static void ScrollDown(this ScrollViewer scrollViewer, double offset)
        {
            ScrollUtils.ScrollByVerticalOffset(scrollViewer, offset);
        }

        /// <summary>
        /// Scrolls ScrollViewer by given vertical offset.
        /// </summary>
        public static void ScrollByVerticalOffset(this ScrollViewer scrollViewer, double offset)
        {
            scrollViewer.ScrollToVerticalOffset(scrollViewer.VerticalOffset + offset);
        }
    }
}