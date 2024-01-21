using Core;

namespace Core
{
    using System;

    public partial class Materialxportableremotein
    {
        public static void RemoteType(Materialxportable[] array_MATERIALXPORTABLE)
        {
            foreach (Materialxportable value_MATERIALXPORTABLE in array_MATERIALXPORTABLE)
            {
                Boolean isDefaultCheck, shouldContinueCheck;

                isDefaultCheck = (value_MATERIALXPORTABLE.ObjectIdentity == default).Equals(true);

                shouldContinueCheck = isDefaultCheck is true;

                if (shouldContinueCheck is true)
                {
                    continue;
                }
                else
                    "false".ToString();

                value_MATERIALXPORTABLE.Type = value_MATERIALXPORTABLE.ObjectIdentity.GetType();

                continue;
            }

            return;
        }
    }
}
