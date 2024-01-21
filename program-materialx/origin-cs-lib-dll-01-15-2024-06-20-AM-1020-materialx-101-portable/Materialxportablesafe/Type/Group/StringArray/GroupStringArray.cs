using Core;

namespace Core
{
    using System;

    public partial class Materialxportablesafe
    {
        public static String[] GroupStringArray(String[] array_STRING)
        {
            String[] arrayResult = default;

            String[] stringArray;

            stringArray = new String[array_STRING.Length];

            var indexer = 0;

            foreach (String value_STRING in array_STRING)
            {
                var result = GroupString(value_STRING);

                stringArray[indexer] = result;

                indexer = indexer + 1;

                continue;
            }

            arrayResult = stringArray;

            return arrayResult;
        }
    }
}
