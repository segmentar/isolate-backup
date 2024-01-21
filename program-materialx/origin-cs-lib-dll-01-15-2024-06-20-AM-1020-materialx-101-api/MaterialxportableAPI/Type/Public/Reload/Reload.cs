using Core;

namespace Core
{
    using System;

    public partial class Materialxportableapi
    {
        public static Materialxportable Reload(Materialxportable materialxportable, Materialxportablesavecontext materialxportablesavecontext, Materialxportablewriteclose materialxportablewriteclose, Materialxportableloadcontext materialxportableloadcontext, Materialxportablereadclose materialxportablereadclose, String filename)
        {
            Materialxportable materialxportableResult = default;

            materialxportableResult = Materialxportablereload.GroupReload(materialxportable, materialxportablesavecontext, materialxportablewriteclose, materialxportableloadcontext, materialxportablereadclose, filename);

            return materialxportableResult;
        }
    }
}
