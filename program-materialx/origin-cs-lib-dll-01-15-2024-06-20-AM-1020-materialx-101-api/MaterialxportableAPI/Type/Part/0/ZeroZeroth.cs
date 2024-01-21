using Core;

namespace Core
{
    using System;

    public partial class Materialxportableescape
    {
        public static void ZeroZeroth(Materialxportable value_MATERIALXPORTABLE, String CharacterRoute__VALUE, String InputRoute__VALUE, String ResultRoute__VALUE)
        {
            var CharacterRoute__RESULT = Materialxportableroute.Route(CharacterRoute__VALUE);

            var InputRoute__RESULT = Materialxportableroute.Route(InputRoute__VALUE);

            var inflect = new Object[1];

            inflect[0] = ((Materialxportable[])value_MATERIALXPORTABLE.SegmentArrayObject)[CharacterRoute__RESULT];

            var list = Materialxportablemagic.MaterialxportablemagicArrayListDispenser(new Object[0]);

            while (true)
            {
                Boolean isDefaultCheck, shouldBreakCheck;

                isDefaultCheck = ((Materialxportable)inflect[0] == default).Equals(true);

                shouldBreakCheck = isDefaultCheck is true;

                if (shouldBreakCheck is true)
                {
                    break;
                }
                else
                    "false".ToString();

                list.Add(inflect[0]);

                var next = ((Materialxportable[])((Materialxportable)inflect[0]).SegmentArrayObject)[CharacterRoute__RESULT];

                Boolean isDefaultContagentCheck;

                isDefaultContagentCheck = (next == default).Equals(true);

                if (isDefaultContagentCheck)
                {
                    break;
                }
                else
                {
                    inflect[0] = next;
                }

                continue;
            }

            inflect[0] = ((Materialxportable[])((Materialxportable)inflect[0]).SegmentArrayObject)[InputRoute__RESULT];

            var reflect = (Materialxportable[])(list.ToArray(typeof(Materialxportable)) as Array);

            var array = Onefirstprimarysingle(reflect);

            Materialxportableportal.Portal(value_MATERIALXPORTABLE, reflect, ResultRoute__VALUE, array, (String)((Materialxportable)inflect[0]).ObjectIdentity);

            return;
        }
    }
}
