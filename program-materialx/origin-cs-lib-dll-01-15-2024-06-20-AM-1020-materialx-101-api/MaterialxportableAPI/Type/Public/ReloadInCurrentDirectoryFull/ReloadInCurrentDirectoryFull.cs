using Core;

namespace Core
{
    using System;

    public partial class Materialxportableapi
    {
        public static Materialxportable ReloadInCurrentDirectoryFull(Materialxportable materialxportable, String fileName)
        {
            Materialxportable materialxportableResult = default;

            materialxportableResult = Materialxportablereload.GroupReloadInCurrentDirectoryFull(materialxportable, fileName);

            return materialxportableResult;
        }
    }
}
