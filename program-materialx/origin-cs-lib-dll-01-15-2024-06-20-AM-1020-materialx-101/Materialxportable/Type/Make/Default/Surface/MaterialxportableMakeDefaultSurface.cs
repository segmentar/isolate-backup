using Core;

namespace Core
{
    using System;

    public partial class Materialxportable
    {
        public static Materialxportable MaterialxportableMakeDefaultSurface(Materialxportablestringarraysafe RouteIdentity__VALUE)
        {
            Materialxportable materialxportableResult = default;

            materialxportableResult = MaterialxportableMakeDefault(RouteIdentity__VALUE, MaterialxportablePolicy.MaterialxportableDebugPolicy);

            return materialxportableResult;
        }
    }
}
