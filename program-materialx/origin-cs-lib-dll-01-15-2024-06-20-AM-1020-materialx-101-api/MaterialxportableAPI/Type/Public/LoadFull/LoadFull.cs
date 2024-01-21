using Core;

namespace Core
{
    using System;

    public partial class Materialxportableapi
    {
        public static Object[] LoadFull(String filename)
        {
            Object[] arrayResult = default;

            arrayResult = Materialxportableload.GroupLoadFull(filename);

            return arrayResult;
        }
    }
}
