using Core;

namespace Core
{
    using System;

    public partial class Materialxportableapi
    {
        public static Object[] Save(Materialxportable materialxportable, Materialxportablesavecontext materialxportablesavecontext, Materialxportablewriteclose materialxportablewriteclose, String filename)
        {
            Object[] arrayResult = default;

            arrayResult = Materialxportablesave.GroupSave(materialxportable, materialxportablesavecontext, materialxportablewriteclose, filename);

            return arrayResult;
        }
    }
}
