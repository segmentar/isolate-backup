using Core;

namespace Core
{
    using System;

    public partial class Materialxportablesave
    {
        public static Object[] GroupSaveFull(Materialxportable value_MATERIALXPORTABLE, String Filename_VALUE)
        {
            Object[] arrayResult = default;

            var inflect = new Object[2];

            inflect[0] = Materialxportablesavecontext.Data();

            inflect[1] = Materialxportablewriteclose.Data();

            var array = GroupSave(value_MATERIALXPORTABLE, (Materialxportablesavecontext)inflect[0], (Materialxportablewriteclose)inflect[1], Filename_VALUE);

            arrayResult = array;

            return arrayResult;
        }
    }
}
