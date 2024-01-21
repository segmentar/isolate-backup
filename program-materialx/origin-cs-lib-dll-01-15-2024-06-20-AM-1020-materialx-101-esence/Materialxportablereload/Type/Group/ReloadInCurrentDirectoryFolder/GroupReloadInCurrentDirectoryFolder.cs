using Core;

namespace Core
{
    using System;

    public partial class Materialxportablereload
    {
        public static Materialxportable GroupReloadInCurrentDirectoryFolder(Materialxportable value_MATERIALXPORTABLE, Materialxportablesavecontext value_MATERIALXPORTABLESAVECONTEXT, Materialxportablewriteclose value_MATERIALXPORTABLEWRITECLOSE, Materialxportableloadcontext value_MATERIALXPORTABLELOADCONTEXT, Materialxportablereadclose value_MATERIALXPORTABLEREADCLOSE, String FolderName__VALUE, String FileName__VALUE)
        {
            Materialxportable materialxportableResult = default;

            Materialxportablesave.GroupSaveToCurrentDirectoryFolder(value_MATERIALXPORTABLE, value_MATERIALXPORTABLESAVECONTEXT, value_MATERIALXPORTABLEWRITECLOSE, FolderName__VALUE, FileName__VALUE);

            var result = Materialxportableload.GroupLoadFromCurrentDirectoryFolder(value_MATERIALXPORTABLELOADCONTEXT, value_MATERIALXPORTABLEREADCLOSE, FolderName__VALUE, FileName__VALUE);

            materialxportableResult = result;

            return materialxportableResult;
        }
    }
}
