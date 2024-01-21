using Core;

namespace Core
{
    using System;

    public partial class Materialxportableapi
    {
        public static Materialxportable Root()
        {
            Materialxportable materialxportableResult = default;

            materialxportableResult = Materialxportable.MaterialxportableRootVariation();

            return materialxportableResult;
        }
    }
}
