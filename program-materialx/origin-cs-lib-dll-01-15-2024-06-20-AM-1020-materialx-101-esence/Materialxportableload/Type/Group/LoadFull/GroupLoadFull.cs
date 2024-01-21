using Core;

namespace Core
{
    using System;

    public partial class Materialxportableload
    {
        public static Object[] GroupLoadFull(String Filename_VALUE)
        {
            Object[] arrayResult = default;

            var inflect = new Object[2];

            inflect[0] = Materialxportableloadcontext.Data();

            inflect[1] = Materialxportablereadclose.Data();

            var array = GroupLoad((Materialxportableloadcontext)inflect[0], (Materialxportablereadclose)inflect[1], Filename_VALUE);

            arrayResult = array;

            return arrayResult;
        }
    }
}
