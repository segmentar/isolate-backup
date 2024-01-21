using Core;

namespace Core
{
    using System;

    public partial class Materialxportableapi
    {
        public static void SaveToCurrentDirectoryFolderFull(Materialxportable materialxportable, String folderName, String fileName)
        {
            Materialxportablesave.GroupSaveToCurrentDirectoryFolderFull(materialxportable, folderName, fileName);

            return;
        }
    }
}
