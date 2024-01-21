using Core;

namespace Core
{
    using System;

    public partial class Materialxportableapi
    {
        public static Object[] SaveFull(Materialxportable materialxportable, String filename)
        {
            Object[] arrayResult = default;

            arrayResult = Materialxportablesave.GroupSaveFull(materialxportable, filename);

            return arrayResult;
        }
    }
}
