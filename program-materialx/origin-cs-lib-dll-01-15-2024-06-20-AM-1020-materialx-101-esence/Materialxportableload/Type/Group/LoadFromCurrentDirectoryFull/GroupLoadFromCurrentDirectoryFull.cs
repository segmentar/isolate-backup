using Core;

namespace Core
{
    using System;

    public partial class Materialxportableload
    {
        public static Materialxportable GroupLoadFromCurrentDirectoryFull(String FileName__VALUE)
        {
            Materialxportable materialxportableResult = default;

            var inflect = new Object[2];

            inflect[0] = Materialxportableloadcontext.Data();

            inflect[1] = Materialxportablereadclose.Data();

            var result = GroupLoadFromCurrentDirectory((Materialxportableloadcontext)inflect[0], (Materialxportablereadclose)inflect[1], FileName__VALUE);

            materialxportableResult = result;

            return materialxportableResult;
        }
    }
}
