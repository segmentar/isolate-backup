using Core;

namespace Core
{
    using System;

    public partial class Materialxportableapi
    {
        public static Materialxportable LoadFromCurrentDirectoryFolder(Materialxportableloadcontext materialxportableloadcontext, Materialxportablereadclose materialxportablereadclose, String folderName, String fileName)
        {
            Materialxportable materialxportableResult = default;

            materialxportableResult = Materialxportableload.GroupLoadFromCurrentDirectoryFolder(materialxportableloadcontext, materialxportablereadclose, folderName, fileName);

            return materialxportableResult;
        }
    }
}
