using Core;

namespace Core
{
    using System;

    public partial class Materialxportablesafe
    {
        public static String GroupString(String value_STRING)
        {
            String stringResult = default;

            var item = value_STRING.ToCharArray();

            var entry = GroupCharacterArray(item);

            var result = new String(entry);

            stringResult = result;

            return stringResult;
        }
    }
}
