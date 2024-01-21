using Core;

namespace Core
{
    using System;

    public partial class Materialxportablereload
    {
        public static Materialxportable GroupReloadInCurrentDirectoryFolderFull(Materialxportable value_MATERIALXPORTABLE, String FolderName__VALUE, String FileName__VALUE)
        {
            Materialxportable materialxportableResult = default;

            Materialxportablesave.GroupSaveToCurrentDirectoryFolderFull(value_MATERIALXPORTABLE, FolderName__VALUE, FileName__VALUE);

            var result = Materialxportableload.GroupLoadFromCurrentDirectoryFolderFull(FolderName__VALUE, FileName__VALUE);

            materialxportableResult = result;

            return materialxportableResult;
        }
    }
}
