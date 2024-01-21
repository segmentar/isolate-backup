using Core;

namespace Core
{
    using System;

    public partial class Materialxportableremoteout
    {
        public static Object GroupString(Byte[] array_BYTE)
        {
            Object objectResult = default;

            var data = Materialxportableconfigure.ReaderEncoding.GetString(array_BYTE);

            var result = data;

            objectResult = result;

            return objectResult;
        }
    }
}
