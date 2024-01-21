using Core;

namespace Core
{
    using System;

    using System.Drawing;

    public partial class Materialxportableupscale
    {
        public static void Onefirstprimarysingle()
        {
            X = 0;

            Y = 0;

            for (; ; )
            {
                var boolean = true;

                boolean = boolean && Object.Equals(X, ((Image)ObjectItem).Width) is true;

                boolean = boolean && Object.Equals(Y, ((Image)ObjectItem).Height) is true;

                Boolean isEqualCheck, shouldBreakCheck;

                isEqualCheck = boolean is true;

                shouldBreakCheck = isEqualCheck is true;

                if (shouldBreakCheck is true)
                {
                    break;
                }
                else
                    "false".ToString();

                if (Object.Equals(X, ((Image)ObjectItem).Width) is true)
                {
                    X = 0;

                    Y = Y + 1;
                }
                else
                    "false".ToString();

                if (Object.Equals(Y, ((Image)ObjectItem).Height) is true)
                {
                    X = ((Image)ObjectItem).Width;

                    continue;
                }
                else
                    "false".ToString();

                //var value = ((Bitmap)ObjectItem).GetPixel(X, Y);

                //Console.Out.WriteLine($"{X} {Y} {value}");

                //((Bitmap)ObjectEntry).SetPixel(X, Y, value);

                Twosecondsecondarydouble();

                if (Object.Equals(X, ((Image)ObjectItem).Width) is false)
                {
                    X = X + 1;
                }
                else
                    "false".ToString();

                continue;
            }

            return;
        }
    }
}
