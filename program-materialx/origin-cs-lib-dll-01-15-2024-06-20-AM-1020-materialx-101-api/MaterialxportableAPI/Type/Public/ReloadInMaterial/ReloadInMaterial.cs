using Core;

namespace Core
{
    using System;

    public partial class Materialxportableapi
    {
        public static Materialxportable ReloadInMaterial(Materialxportable materialxportable, Materialxportablesavecontext materialxportablesavecontext, Materialxportablewriteclose materialxportablewriteclose, Materialxportableloadcontext materialxportableloadcontext, Materialxportablereadclose materialxportablereadclose, String fileName)
        {
            Materialxportable materialxportableResult = default;

            materialxportableResult = Materialxportablereload.GroupReloadInMaterial(materialxportable, materialxportablesavecontext, materialxportablewriteclose, materialxportableloadcontext, materialxportablereadclose, fileName);

            return materialxportableResult;
        }
    }
}
