using Core;

namespace Core
{
    using System;

    public partial class Materialxportableapi
    {
        public static void SaveToCurrentDirectoryFolder(Materialxportable materialxportable, Materialxportablesavecontext materialxportablesavecontext, Materialxportablewriteclose materialxportablewriteclose, String folderName, String fileName)
        {
            Materialxportablesave.GroupSaveToCurrentDirectoryFolder(materialxportable, materialxportablesavecontext, materialxportablewriteclose, folderName, fileName);

            return;
        }
    }
}
