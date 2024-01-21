using Core;

namespace Core
{
    using System;

    public partial class Materialxportableapi
    {
        public static Materialxportable ReloadInCurrentDirectory(Materialxportable materialxportable, Materialxportablesavecontext materialxportablesavecontext, Materialxportablewriteclose materialxportablewriteclose, Materialxportableloadcontext materialxportableloadcontext, Materialxportablereadclose materialxportablereadclose, String fileName)
        {
            Materialxportable materialxportableResult = default;

            materialxportableResult = Materialxportablereload.GroupReloadInCurrentDirectory(materialxportable, materialxportablesavecontext, materialxportablewriteclose, materialxportableloadcontext, materialxportablereadclose, fileName);

            return materialxportableResult;
        }
    }
}
