using Core;

namespace Core
{
    using System;

    public partial class Materialxportableapi
    {
        public static Materialxportable ReloadFull(Materialxportable materialxportable, String filename)
        {
            Materialxportable materialxportableResult = default;

            materialxportableResult = Materialxportablereload.GroupReloadFull(materialxportable, filename);

            return materialxportableResult;
        }
    }
}
