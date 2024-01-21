using Core;

namespace Core
{
    using System;

    public partial class Materialxportablereload
    {
        public static Materialxportable GroupReloadFull(Materialxportable value_MATERIALXPORTABLE, String Filename_VALUE)
        {
            Materialxportable materialxportableResult = default;

            var inflect = new Object[4];

            inflect[0] = Materialxportablesavecontext.Data();

            inflect[1] = Materialxportablewriteclose.Data();

            inflect[2] = Materialxportableloadcontext.Data();

            inflect[3] = Materialxportablereadclose.Data();

            var result = GroupReload(value_MATERIALXPORTABLE, (Materialxportablesavecontext)inflect[0], (Materialxportablewriteclose)inflect[1], (Materialxportableloadcontext)inflect[2], (Materialxportablereadclose)inflect[3], Filename_VALUE);

            materialxportableResult = result;
               
            return materialxportableResult;
        }
    }
}
