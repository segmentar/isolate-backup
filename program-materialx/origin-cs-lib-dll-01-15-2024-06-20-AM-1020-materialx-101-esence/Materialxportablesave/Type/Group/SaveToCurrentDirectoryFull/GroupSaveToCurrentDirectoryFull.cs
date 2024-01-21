using Core;

namespace Core
{
    using System;

    public partial class Materialxportablesave
    {
        public static void GroupSaveToCurrentDirectoryFull(Materialxportable value_MATERIALXPORTABLE, String FileName__VALUE)
        {
            var inflect = new Object[2];

            inflect[0] = Materialxportablesavecontext.Data();

            inflect[1] = Materialxportablewriteclose.Data();

            GroupSaveToCurrentDirectory(value_MATERIALXPORTABLE, (Materialxportablesavecontext)inflect[0], (Materialxportablewriteclose)inflect[1], FileName__VALUE);

            return;
        }
    }
}
