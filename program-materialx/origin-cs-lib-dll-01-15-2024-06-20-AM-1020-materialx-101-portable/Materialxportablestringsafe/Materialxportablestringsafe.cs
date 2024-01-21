using Core;

namespace Core
{
    using System;

    [Materialxportableisc]
    public partial struct Materialxportablestringsafe
    {
        public String Value;

        public String ValueSafe;

        [Materialxportableism]
        public static Materialxportablestringsafe ForgeDefault(String value_STRING)
        {
            Materialxportablestringsafe safeResult = default;

            String value, valueSafe;

            value = value_STRING;

            valueSafe = Materialxportablesafe.GroupString(value_STRING);

            Materialxportablestringsafe safe;

            safe = new Materialxportablestringsafe();

            safe.Value = value;

            safe.ValueSafe = valueSafe;

            safeResult = safe;

            return safeResult;
        }
    }
}
