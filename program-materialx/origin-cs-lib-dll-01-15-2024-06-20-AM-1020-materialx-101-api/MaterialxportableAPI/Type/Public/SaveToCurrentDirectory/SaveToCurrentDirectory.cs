using Core;

namespace Core
{
    using System;

    public partial class Materialxportableapi
    {
        public static void SaveToCurrentDirectory(Materialxportable materialxportable, Materialxportablesavecontext materialxportablesavecontext, Materialxportablewriteclose materialxportablewriteclose, String fileName)
        {
            Materialxportablesave.GroupSaveToCurrentDirectory(materialxportable, materialxportablesavecontext, materialxportablewriteclose, fileName);

            return;
        }
    }
}
