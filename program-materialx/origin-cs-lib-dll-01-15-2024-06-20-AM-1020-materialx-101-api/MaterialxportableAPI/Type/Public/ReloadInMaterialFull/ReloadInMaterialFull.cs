using Core;

namespace Core
{
    using System;

    public partial class Materialxportableapi
    {
        public static Materialxportable ReloadInMaterialFull(Materialxportable materialxportable, String fileName)
        {
            Materialxportable materialxportableResult = default;

            materialxportableResult = Materialxportablereload.GroupReloadInMaterialFull(materialxportable, fileName);

            return materialxportableResult;
        }
    }
}
