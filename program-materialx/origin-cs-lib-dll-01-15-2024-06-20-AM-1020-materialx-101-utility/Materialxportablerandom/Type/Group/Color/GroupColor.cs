using Core;

namespace Core
{
    using System;

    using System.Drawing;

    public partial class Materialxportablerandom
    {
        public static Color GroupColor()
        {
            Color colorResult = default;

            Int32 r, g, b, a;

            r = Random.Next(0, 255);

            g = Random.Next(0, 255);

            b = Random.Next(0, 255);

            a = 255;

            var result = Color.FromArgb(a, r, g, b);

            colorResult = result;

            return colorResult;
        }
    }
}
