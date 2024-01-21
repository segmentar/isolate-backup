using Core;

namespace Core
{
    using System;

    public partial class Materialxportableapi
    {
        public static Object[] Load(Materialxportableloadcontext materialxportableloadcontext, Materialxportablereadclose materialxportablereadclose, String filename)
        {
            Object[] arrayResult = default;

            arrayResult = Materialxportableload.GroupLoad(materialxportableloadcontext, materialxportablereadclose, filename);

            return arrayResult;
        }
    }
}
