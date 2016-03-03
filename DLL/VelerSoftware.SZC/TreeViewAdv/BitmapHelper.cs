// *****************************************************************************
// 
//  � Veler Software 2012. All rights reserved.
//  The current code and the associated software are the proprietary 
//  information of Etienne Baudoux from Veler Software and are
//  supplied subject to licence terms.
// 
//  www.velersoftware.com
// *****************************************************************************

using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace VelerSoftware.SZC.TreeViewAdv
{
    public static class BitmapHelper
    {
        [StructLayout(LayoutKind.Sequential)]
        private struct PixelData
        {
            public byte B;
            public byte G;
            public byte R;
            public byte A;
        }

        public static void SetAlphaChanelValue(Bitmap image, byte value)
        {
            if (image == null)
                throw new ArgumentNullException("image");
            if (image.PixelFormat != PixelFormat.Format32bppArgb)
                throw new ArgumentException("Wrong PixelFormat");

            BitmapData bitmapData = image.LockBits(new Rectangle(0, 0, image.Width, image.Height),
                                     ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
            unsafe
            {
                PixelData* pPixel = (PixelData*)bitmapData.Scan0;
                for (int i = 0; i < bitmapData.Height; i++)
                {
                    for (int j = 0; j < bitmapData.Width; j++)
                    {
                        pPixel->A = value;
                        pPixel++;
                    }
                    pPixel += bitmapData.Stride - (bitmapData.Width * 4);
                }
            }
            image.UnlockBits(bitmapData);
        }
    }
}