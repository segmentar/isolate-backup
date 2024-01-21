using Core;

namespace Core
{
    using System;

    public partial class Materialxportablesegment
    {
        public static void TAK(Materialxportable value_MATERIALXPORTABLE, Object object_VALUE)
        {
            var reflect = (Materialxportablestringarraysafe)(value_MATERIALXPORTABLE.View.RouteIdentity as Object);

            var aoth = reflect.Value.Length;

            var zee = (aoth + 1);

            String[] stringArray;

            stringArray = new String[zee];

            reflect.Value.CopyTo(stringArray, MaterialxportablePolicy.MaterialxportableIndexPolicy);

            stringArray[aoth] = Materialxportablename.EntityTAK;

            Materialxportable materialxportable;

            materialxportable = new MaterialxportableSimple(stringArray).Result;

            materialxportable.ObjectIdentity = object_VALUE;

            ((Materialxportable[])value_MATERIALXPORTABLE.View.SegmentArrayObject)[2] = materialxportable;

            value_MATERIALXPORTABLE.View = materialxportable;

            return;
        }
    }
}
