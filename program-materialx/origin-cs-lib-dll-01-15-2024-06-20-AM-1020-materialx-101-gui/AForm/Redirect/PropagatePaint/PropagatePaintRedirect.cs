using Core;

namespace Core
{
    using System;

    using System.Windows;
    using System.Windows.Forms;

    using System.Drawing;

    public partial class AForm
    {
        public static void PropagatePaintRedirect(Object sender, PaintEventArgs e)
        {
            var reflect = (Image)(Materialxportableoverlap.BitmapUpscaleObject as Object);

            Boolean isDefaultCheck, shouldReturnCheck;

            isDefaultCheck = (reflect == default).Equals(true);

            shouldReturnCheck = isDefaultCheck is true;

            if (shouldReturnCheck is true)
            {
                return;
            }
            else
                "false".ToString();

            Int32 x, y;

            x = 0;

            y = 0;

            Int32 width, height;

            width = ((AForm)sender).ClientRectangle.Width;

            height = ((AForm)sender).ClientRectangle.Height;

            Point point;

            point = new Point(x, y);

            Size size;

            size = new Size(width, height);

            Rectangle rectangle;

            rectangle = new Rectangle(point, size);

            e.Graphics.DrawImage(reflect, rectangle);

            return;
        }
    }
}
