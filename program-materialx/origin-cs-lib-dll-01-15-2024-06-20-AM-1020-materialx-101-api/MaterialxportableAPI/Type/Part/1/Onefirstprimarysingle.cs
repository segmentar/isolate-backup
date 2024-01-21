using Core;

namespace Core
{
    using System;

    public partial class Materialxportableescape
    {
        public static Char[] Onefirstprimarysingle(Materialxportable[] array_MATERIALXPORTABLE)
        {
            Char[] arrayResult = default;

            var array = new Char[array_MATERIALXPORTABLE.Length];

            var indexer = 0;

            foreach (Materialxportable value_MATERIALXPORTABLE in array_MATERIALXPORTABLE)
            {
                var convert = Convert.ToChar(value_MATERIALXPORTABLE.ObjectIdentity);

                array[indexer] = convert;

                indexer = indexer + 1;

                continue;
            }

            arrayResult = array;

            return arrayResult;
        }
    }
}
