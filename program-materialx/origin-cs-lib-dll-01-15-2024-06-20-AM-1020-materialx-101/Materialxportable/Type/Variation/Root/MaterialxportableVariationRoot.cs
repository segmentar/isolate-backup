using Core;

namespace Core
{
    using System;

    public partial class Materialxportable
    {
        public static Materialxportable MaterialxportableRootVariation()
        {
            Materialxportable materialxportableResult = default;

            Materialxportable materialxportable;

            materialxportable = new MaterialxportableSimple(Materialxportablename.EntityRoot).Result;

            materialxportableResult = materialxportable;

            return materialxportableResult;
        }
    }
}
