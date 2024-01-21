using Core;

namespace Core
{
    using System;

    public partial class Materialxportableapi
    {
        public static Materialxportable ReloadInCurrentDirectoryFolder(Materialxportable materialxportable, Materialxportablesavecontext materialxportablesavecontext, Materialxportablewriteclose materialxportablewriteclose, Materialxportableloadcontext materialxportableloadcontext, Materialxportablereadclose materialxportablereadclose, String folderName, String fileName)
        {
            Materialxportable materialxportableResult = default;

            materialxportableResult = Materialxportablereload.GroupReloadInCurrentDirectoryFolder(materialxportable, materialxportablesavecontext, materialxportablewriteclose, materialxportableloadcontext, materialxportablereadclose, folderName, fileName);

            return materialxportableResult;
        }
    }
}
