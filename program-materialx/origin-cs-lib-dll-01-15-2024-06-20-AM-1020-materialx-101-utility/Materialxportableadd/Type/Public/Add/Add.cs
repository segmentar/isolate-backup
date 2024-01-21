using Core;

namespace Core
{
    using System;

    public partial class Materialxportableadd
    {
        public static Materialxportable Add(Materialxportable value_MATERIALXPORTABLE, String Route_VALUE)
        {
            Materialxportable materialxportableResult = default;

            var reflect = (Materialxportablestringarraysafe)(value_MATERIALXPORTABLE.RouteIdentity as Object);

            var value = Materialxportableroute.Route(Route_VALUE);

            var aoth = reflect.Value.Length;

            var zee = (aoth + 1);

            var array = new String[zee];

            reflect.Value.CopyTo(array, MaterialxportablePolicy.MaterialxportableIndexPolicy);

            array[aoth] = Route_VALUE;

            Materialxportable materialxportable;

            materialxportable = new MaterialxportableSimple(array).Result;

            ((Materialxportable[])value_MATERIALXPORTABLE.SegmentArrayObject)[value] = materialxportable;

            materialxportableResult = materialxportable;

            return materialxportableResult;
        }
    }
}
