using Core;

namespace Core
{
    using System;

    public partial class Materialxportableformat
    {
        public static String GroupDashless(String value_STRING)
        {
            String stringResult = default;

            var trim = value_STRING.Trim(Materialxportableradical.EntityFormat);

            var split = trim.Split(Materialxportableradical.EntityFormat, StringSplitOptions.RemoveEmptyEntries);

            var join = String.Join(((Char)Materialxportableascii.EntityUnderscore).ToString(), split);

            var result = join;

            stringResult = result;

            return stringResult;
        }
    }
}
