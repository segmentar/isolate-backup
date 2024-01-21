using Core;

namespace Core
{
    using System;

    public partial class Materialxportableapi
    {
        public static Materialxportable LoadFromMaterialFull(String fileName)
        {
            Materialxportable materialxportableResult = default;

            materialxportableResult = Materialxportableload.GroupLoadFromMaterialFull(fileName);

            return materialxportableResult;
        }
    }
}
