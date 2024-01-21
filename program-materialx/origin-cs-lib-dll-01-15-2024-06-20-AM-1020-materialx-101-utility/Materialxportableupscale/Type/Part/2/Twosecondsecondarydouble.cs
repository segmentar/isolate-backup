using Core;

namespace Core
{
    using System;

    using System.Drawing;

    public partial class Materialxportableupscale
    {
        public static void Twosecondsecondarydouble()
        {
            var value = ((Bitmap)ObjectItem).GetPixel(X, Y);

            U = 0;

            V = 0;

            for (; ; )
            {
                var boolean = true;

                boolean = boolean && Object.Equals(U, FactorEntry) is true;

                boolean = boolean && Object.Equals(V, FactorEntry) is true;

                Boolean isEqualCheck, shouldBreakCheck;

                isEqualCheck = boolean is true;

                shouldBreakCheck = isEqualCheck is true;

                if (shouldBreakCheck is true)
                {
                    break;
                }
                else
                    "false".ToString();

                if (Object.Equals(U, FactorEntry) is true)
                {
                    U = 0;

                    V = V + 1;
                }
                else
                    "false".ToString();

                if (Object.Equals(V, FactorEntry) is true)
                {
                    U = Convert.ToInt32(FactorItem);

                    continue;
                }
                else
                    "false".ToString();

                Z = 0;

                Z = Z + U;

                Z = Z + (Int32)((Single)X * FactorItem);

                W = 0;

                W = W + V;

                W = W + (Int32)((Single)Y * FactorItem);

                ((Bitmap)ObjectEntry).SetPixel(Z, W, value);

                if (Object.Equals(U, FactorEntry) is false)
                {
                    U = U + 1;
                }
                else
                    "false".ToString();

                continue;
            }

            return;
        }
    }
}
