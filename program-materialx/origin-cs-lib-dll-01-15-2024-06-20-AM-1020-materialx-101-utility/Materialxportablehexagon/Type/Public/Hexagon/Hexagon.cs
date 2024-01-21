using Core;

namespace Core
{
    using System;

    using System.Drawing;

    public partial class Materialxportablehexagon
    {
        public static void Hexagon(Object reflect_OBJECT, Int32 X_VALUE, Int32 Y_VALUE, Color value_COLOR)
        {
            var value = ((Bitmap)reflect_OBJECT).GetPixel(X_VALUE, Y_VALUE);

            if (Object.Equals(Materialxportableoverlap.Immutable.OverlapColor.ToArgb(), value.ToArgb()) is true)
            {
                //overlap
            }
            else
                "false".ToString();

            Materialxportablepixel.Pixel(reflect_OBJECT, X_VALUE, Y_VALUE, Materialxportableoverlap.Immutable.OverlapColor);

            Materialxportablepixel.Pixel(reflect_OBJECT, (X_VALUE + 1), Y_VALUE, value_COLOR);

            Materialxportablepixel.Pixel(reflect_OBJECT, (X_VALUE + 2), Y_VALUE, value_COLOR);

            Materialxportablepixel.Pixel(reflect_OBJECT, (X_VALUE + 1), (Y_VALUE + 1), value_COLOR);

            Materialxportablepixel.Pixel(reflect_OBJECT, X_VALUE, (Y_VALUE + 2), value_COLOR);

            Materialxportablepixel.Pixel(reflect_OBJECT, (X_VALUE + 1), (Y_VALUE + 2), value_COLOR);

            Materialxportablepixel.Pixel(reflect_OBJECT, (X_VALUE + 2), (Y_VALUE + 2), value_COLOR);

            return;
        }
    }
}
