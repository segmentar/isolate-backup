using Core;

namespace Core
{
    using System;

    using System.Drawing;

    public partial class Materialxportableoverlap
    {
        public static void Overlap(Materialxportable value_MATERIALXPORTABLE)
        {
            BitmapObject = new Bitmap(1, 1);
            
            var value = Materialxportableasync.GroupDepth(true, false, true, false, true);
            
            Materialxportablemagic.MaterialxportablemagicThreadStart(value, 100);
            
            var array = Materialxportableall.MaterialxportableallAllSetSurface(value_MATERIALXPORTABLE, true);

            var size = 3;

            Int32 x, y;

            x = 2;

            y = 2;

            foreach (Materialxportable materialxportable in array)
            {
                System.Threading.Thread.Sleep(1000);

                Int32 u, v;

                u = x;

                v = y;

                var result = ((Materialxportablestringarraysafe)materialxportable.RouteIdentity).Value;

                foreach (String stringValue in result)
                {
                    if (Object.Equals(Materialxportablename.EntityRoot, stringValue))
                    {

                    }
                    else if (Object.Equals(Materialxportablename.EntityKAI, stringValue))
                    {
                        u = u - 3;

                        v = v - 3;
                    } 
                    else if (Object.Equals(Materialxportablename.EntitySAJ, stringValue))
                    {
                        u = u - 3;

                        v = v + 3;
                    }
                    else if (Object.Equals(Materialxportablename.EntityTAK, stringValue))
                    {
                        v = v - 3;
                    }
                    else if (Object.Equals(Materialxportablename.EntityNAL, stringValue))
                    {
                        v = v + 3;
                    }
                    else if (Object.Equals(Materialxportablename.EntityHAM, stringValue))
                    {
                        u = u + 3;

                        v = v - 3;
                    }
                    else if (Object.Equals(Materialxportablename.EntityMAN, stringValue))
                    {
                        u = u + 3;

                        v = v + 3;
                    }
                    else
                    {

                    }

                    continue;
                }

                BitmapObject = Materialxportableresize.Resize((Bitmap)BitmapObject, 3);
                
                Materialxportablehexagon.Hexagon((Bitmap)BitmapObject, u, v, Materialxportablerandom.GroupColor());

                BitmapUpscaleObject = Materialxportableupscale.Upscale(BitmapObject, 30.00F);

                AForm.Instance.Invalidate();

                x = x + size;

                y = y + size;

                continue;
            }

            return;
        }
    }
}
