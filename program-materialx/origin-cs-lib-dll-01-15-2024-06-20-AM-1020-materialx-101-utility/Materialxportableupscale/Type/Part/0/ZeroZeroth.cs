using Core;

namespace Core
{
    using System;

    using System.Drawing;

    public partial class Materialxportableupscale
    {
        public static Bitmap ZeroZeroth(Object reflect_OBJECT, Single Factor_VALUE)
        {
            Bitmap bitmapResult = default;

            ObjectItem = reflect_OBJECT;

            FactorItem = Factor_VALUE;

            FactorEntry = Convert.ToInt32(FactorItem);

            Single widthf, heightf;

            widthf = (((Image)reflect_OBJECT).Width * FactorItem);

            heightf = (((Image)reflect_OBJECT).Height * FactorItem);

            Width = Convert.ToInt32(widthf);

            Height = Convert.ToInt32(heightf);

            Bitmap bitmap;

            bitmap = new Bitmap(Width, Height);

            ObjectEntry = bitmap;

            Graphics.FromImage((Bitmap)ObjectEntry).Clear(Color.Blue);

            Onefirstprimarysingle();

            bitmapResult = (Bitmap)ObjectEntry;

            return bitmapResult;
        }
    }
}
