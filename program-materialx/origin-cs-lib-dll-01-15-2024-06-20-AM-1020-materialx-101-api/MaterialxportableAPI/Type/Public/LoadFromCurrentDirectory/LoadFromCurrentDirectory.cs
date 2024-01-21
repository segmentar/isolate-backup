using Core;

namespace Core
{
    using System;

    public partial class Materialxportableapi
    {
        public static Materialxportable LoadFromCurrentDirectory(Materialxportableloadcontext materialxportableloadcontext, Materialxportablereadclose materialxportablereadclose, String fileName)
        {
            Materialxportable materialxportableResult = default;

            materialxportableResult = Materialxportableload.GroupLoadFromCurrentDirectory(materialxportableloadcontext, materialxportablereadclose, fileName);

            return materialxportableResult;
        }
    }
}
