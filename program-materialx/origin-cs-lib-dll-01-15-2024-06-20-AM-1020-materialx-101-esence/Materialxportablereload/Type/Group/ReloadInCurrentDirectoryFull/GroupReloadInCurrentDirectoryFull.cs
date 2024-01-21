using Core;

namespace Core
{
    using System;

    public partial class Materialxportablereload
    {
        public static Materialxportable GroupReloadInCurrentDirectoryFull(Materialxportable value_MATERIALXPORTABLE, String FileName__VALUE)
        {
            Materialxportable materialxportableResult = default;

            var inflect = new Object[4];

            inflect[0] = Materialxportablesavecontext.Data();

            inflect[1] = Materialxportablewriteclose.Data();

            inflect[2] = Materialxportableloadcontext.Data();

            inflect[3] = Materialxportablereadclose.Data();

            var result = GroupReloadInCurrentDirectory(value_MATERIALXPORTABLE, (Materialxportablesavecontext)inflect[0], (Materialxportablewriteclose)inflect[1], (Materialxportableloadcontext)inflect[2], (Materialxportablereadclose)inflect[3], FileName__VALUE);

            materialxportableResult = result;

            return materialxportableResult;
        }
    }
}
