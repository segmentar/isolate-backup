using Core;

namespace Core
{
    using System;

    public partial class Materialxportablereload
    {
        public static Materialxportable GroupReloadInCurrentDirectory(Materialxportable value_MATERIALXPORTABLE, Materialxportablesavecontext value_MATERIALXPORTABLESAVECONTEXT, Materialxportablewriteclose value_MATERIALXPORTABLEWRITECLOSE, Materialxportableloadcontext value_MATERIALXPORTABLELOADCONTEXT, Materialxportablereadclose value_MATERIALXPORTABLEREADCLOSE, String FileName__VALUE)
        {
            Materialxportable materialxportableResult = default;

            Materialxportablesave.GroupSaveToCurrentDirectory(value_MATERIALXPORTABLE, value_MATERIALXPORTABLESAVECONTEXT, value_MATERIALXPORTABLEWRITECLOSE, FileName__VALUE);

            var result = Materialxportableload.GroupLoadFromCurrentDirectory(value_MATERIALXPORTABLELOADCONTEXT, value_MATERIALXPORTABLEREADCLOSE, FileName__VALUE);

            materialxportableResult = result;

            return materialxportableResult;
        }
    }
}
