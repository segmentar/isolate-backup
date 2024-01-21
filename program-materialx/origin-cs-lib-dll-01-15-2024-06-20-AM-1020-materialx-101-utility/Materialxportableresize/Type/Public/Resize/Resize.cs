using Core;

namespace Core
{
    using System;

    using System.Drawing;

    public partial class Materialxportableresize
    {
        public static Bitmap Resize(Image value_IMAGE, Int32 value_INTEGER)
        {
            Bitmap bitmapResult = default;

            Int32 width, height;

            width = 0;

            width = width + value_IMAGE.Width;
            
            width = width + (Int32)((Single)value_INTEGER * 2.00F);

            height = 0;

            height = height + value_IMAGE.Height;
            
            height = height + (Int32)((Single)value_INTEGER * 2.00F);

            Bitmap bitmap;

            bitmap = new Bitmap(width, height);

            Graphics graphics;

            graphics = Graphics.FromImage(bitmap);

            /*using (graphics)
            {

                graphics.Dispose();
            }*/

            graphics.Clear(Color.Blue);

            Int32 x, y;

            x = value_INTEGER;

            y = value_INTEGER;

            Point point;

            point = new Point(x, y);

            graphics.DrawImageUnscaled(value_IMAGE, point);

            bitmapResult = bitmap;

            return bitmapResult;
        }
    }
}
