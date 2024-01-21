using Core;

namespace Core
{
    using System;

    public partial class Materialxportableapi
    {
        public static Materialxportable LoadFromMaterial(Materialxportableloadcontext materialxportableloadcontext, Materialxportablereadclose materialxportablereadclose, String fileName)
        {
            Materialxportable materialxportableResult = default;

            materialxportableResult = Materialxportableload.GroupLoadFromMaterial(materialxportableloadcontext, materialxportablereadclose, fileName);

            return materialxportableResult;
        }
    }
}
