using Core;

namespace Core
{
    using System;

    public partial class Materialxportableapi
    {
        public static void SaveToMaterial(Materialxportable materialxportable, Materialxportablesavecontext materialxportablesavecontext, Materialxportablewriteclose materialxportablewriteclose, String fileName)
        {
            Materialxportablesave.SaveToMaterial(materialxportable, materialxportablesavecontext, materialxportablewriteclose, fileName);

            return;
        }
    }
}
