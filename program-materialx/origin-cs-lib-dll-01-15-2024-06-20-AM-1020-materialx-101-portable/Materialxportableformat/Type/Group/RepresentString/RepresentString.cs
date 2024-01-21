using Core;

namespace Core
{
    using System;

    public partial class Materialxportableformat
    {
        public static String RepresentString(Materialxportable value_MATERIALXPORTABLE, Int32 Ordinal_VALUE)
        {
            String stringResult = default;

            var value = new String((Char)Materialxportableascii.EntityArrowBracketRight, Ordinal_VALUE);

            var format = String.Format("{0} {1} <{2}>", value, $"[{String.Join(','.ToString(), ((Materialxportablestringarraysafe)value_MATERIALXPORTABLE.RouteIdentity).ValueSafe)}]", value_MATERIALXPORTABLE.ObjectIdentity);

            var concat = String.Concat(format, (Char)Materialxportableascii.EntityLineFeed);

            var result = String.Empty;

            result = result + concat;

            foreach (Materialxportable item in (Materialxportable[])value_MATERIALXPORTABLE.SegmentArrayObject)
            {
                Boolean isDefaultCheck, shouldContinueCheck;

                isDefaultCheck = (item == default).Equals(true);

                shouldContinueCheck = isDefaultCheck is true;

                if (shouldContinueCheck is true)
                {
                    continue;
                }
                else
                    "false".ToString();

                var next = (Ordinal_VALUE + 1);

                var entry = RepresentString(item, next);

                result = result + entry;

                continue;
            }

            stringResult = result;
            
            return stringResult;
        }
    }
}
