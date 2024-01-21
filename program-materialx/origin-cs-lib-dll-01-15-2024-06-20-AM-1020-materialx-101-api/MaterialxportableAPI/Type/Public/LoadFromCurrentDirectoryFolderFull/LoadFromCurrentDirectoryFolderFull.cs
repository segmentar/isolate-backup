using Core;

namespace Core
{
    using System;

    public partial class Materialxportableapi
    {
        public static Materialxportable LoadFromCurrentDirectoryFolderFull(String folderName, String fileName)
        {
            Materialxportable materialxportableResult = default;

            materialxportableResult = Materialxportableload.GroupLoadFromCurrentDirectoryFolderFull(folderName, fileName);

            return materialxportableResult;
        }
    }
}
