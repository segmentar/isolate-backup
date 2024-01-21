using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class Materialxportableall
    {
        public static IList<Materialxportable> MaterialxportableallAllSet(Materialxportable value_MATERIALXPORTABLE, Boolean answer_SELF_should)
        {
            ICollection<Materialxportable> collectionResult = default;

            collectionResult = new Collection<Materialxportable>();

            if (answer_SELF_should is true)
            {
                collectionResult.Add(value_MATERIALXPORTABLE);
            }
            else
                "false".ToString();

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

                var array = MaterialxportableallAllSetSurface(item, answer_SELF_should);

                foreach (Materialxportable entry in array)
                {
                    collectionResult.Add(entry);

                    continue;
                }

                continue;
            }            

            return new List<Materialxportable>(collectionResult);
        }
    }
}
