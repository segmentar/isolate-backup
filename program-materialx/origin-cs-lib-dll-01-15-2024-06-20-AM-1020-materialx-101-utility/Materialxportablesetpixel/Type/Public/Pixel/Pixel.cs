using Core;

namespace Core
{
    using System;

    using System.Drawing;

    public partial class Materialxportablepixel
    {
        public static void Pixel(Object reflect_OBJECT, Int32 X_VALUE, Int32 Y_VALUE, Color value_COLOR)
        {
            ((Bitmap)reflect_OBJECT).SetPixel(X_VALUE, Y_VALUE, value_COLOR);

            return;
        }
    }
}
