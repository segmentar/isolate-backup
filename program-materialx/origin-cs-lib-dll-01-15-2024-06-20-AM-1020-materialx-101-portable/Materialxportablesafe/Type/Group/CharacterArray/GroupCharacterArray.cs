using Core;

namespace Core
{
    using System;

    public partial class Materialxportablesafe
    {
        public static Char[] GroupCharacterArray(Char[] array_CHARACTER)
        {
            Char[] arrayResult = default;

            Char[] characterArray;

            characterArray = new Char[array_CHARACTER.Length];

            var indexer = 0;

            foreach (Char value_CHARACTER in array_CHARACTER)
            {
                var result = GroupCharacter(value_CHARACTER);

                characterArray[indexer] = result;

                indexer = indexer + 1;

                continue;
            }

            arrayResult = characterArray;

            return arrayResult;
        }
    }
}
