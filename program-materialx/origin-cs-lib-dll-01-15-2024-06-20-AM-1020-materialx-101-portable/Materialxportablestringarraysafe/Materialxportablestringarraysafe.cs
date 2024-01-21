using Core;

namespace Core
{
    using System;

    [Materialxportableisc]
    public partial struct Materialxportablestringarraysafe
    {
        public String[] Value;

        public String[] ValueSafe;

        [Materialxportableism]
        public static Materialxportablestringarraysafe ForgeDefault(String[] array_STRING)
        {
            Materialxportablestringarraysafe safeResult = default;

            String[] value, valueSafe;

            value = array_STRING;

            valueSafe = Materialxportablesafe.GroupStringArray(array_STRING);

            Materialxportablestringarraysafe safe;

            safe = new Materialxportablestringarraysafe();

            safe.Value = value;

            safe.ValueSafe = valueSafe;

            safeResult = safe;

            return safeResult;
        }
    }
}
