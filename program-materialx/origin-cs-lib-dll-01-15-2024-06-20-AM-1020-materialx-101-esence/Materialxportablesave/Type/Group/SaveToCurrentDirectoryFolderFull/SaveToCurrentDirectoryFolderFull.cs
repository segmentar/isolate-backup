using Core;

namespace Core
{
    using System;

    public partial class Materialxportablesave
    {
        public static void GroupSaveToCurrentDirectoryFolderFull(Materialxportable value_MATERIALXPORTABLE, String FolderName__VALUE, String FileName__VALUE)
        {
            var inflect = new Object[2];

            inflect[0] = Materialxportablesavecontext.Data();

            inflect[1] = Materialxportablewriteclose.Data();

            GroupSaveToCurrentDirectoryFolder(value_MATERIALXPORTABLE, (Materialxportablesavecontext)inflect[0], (Materialxportablewriteclose)inflect[1], FolderName__VALUE, FileName__VALUE);
          
            return;
        }
    }
}
