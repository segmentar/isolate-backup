using Core;

namespace Core
{
    using System;

    public partial class Materialxportableapi
    {
        public static void SaveToCurrentDirectoryFull(Materialxportable materialxportable, String fileName)
        {
            Materialxportablesave.GroupSaveToCurrentDirectoryFull(materialxportable, fileName);

            return;
        }
    }
}
