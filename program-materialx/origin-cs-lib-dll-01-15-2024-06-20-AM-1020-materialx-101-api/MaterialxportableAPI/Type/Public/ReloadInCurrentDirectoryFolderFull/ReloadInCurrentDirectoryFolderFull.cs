using Core;

namespace Core
{
    using System;

    public partial class Materialxportableapi
    {
        public static Materialxportable ReloadInCurrentDirectoryFolderFull(Materialxportable materialxportable, String folderName, String fileName)
        {
            Materialxportable materialxportableResult = default;

            materialxportableResult = Materialxportablereload.GroupReloadInCurrentDirectoryFolderFull(materialxportable, folderName, fileName);

            return materialxportableResult;
        }
    }
}
