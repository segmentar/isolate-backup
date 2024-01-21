using Core;

namespace Core
{
    using System;

    public partial class Materialxportableremoteout
    {
        public static Object GroupInt64(Byte[] array_BYTE)
        {
            Object objectResult = default;

            var result = BitConverter.ToInt64(array_BYTE, 0);

            objectResult = result;

            return objectResult;
        }
    }
}
