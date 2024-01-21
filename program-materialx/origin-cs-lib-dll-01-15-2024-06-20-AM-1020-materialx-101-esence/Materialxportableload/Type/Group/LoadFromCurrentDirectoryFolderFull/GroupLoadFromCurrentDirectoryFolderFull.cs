using Core;

namespace Core
{
    using System;

    public partial class Materialxportableload
    {
        public static Materialxportable GroupLoadFromCurrentDirectoryFolderFull(String FolderName__VALUE, String FileName__VALUE)
        {
            Materialxportable materialxportableResult = default;

            var inflect = new Object[2];

            inflect[0] = Materialxportableloadcontext.Data();

            inflect[1] = Materialxportablereadclose.Data();

            var result = GroupLoadFromCurrentDirectoryFolder((Materialxportableloadcontext)inflect[0], (Materialxportablereadclose)inflect[1], FolderName__VALUE, FileName__VALUE);

            materialxportableResult = result;

            return materialxportableResult;
        }
    }
}
