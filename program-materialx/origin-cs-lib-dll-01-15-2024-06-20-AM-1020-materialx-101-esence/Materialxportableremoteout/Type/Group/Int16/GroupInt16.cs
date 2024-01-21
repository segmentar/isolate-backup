using Core;

namespace Core
{
    using System;

    public partial class Materialxportableremoteout
    {
        public static Object GroupInt16(Byte[] array_BYTE)
        {
            Object objectResult = default;

            var result = BitConverter.ToInt16(array_BYTE, 0);

            objectResult = result;

            return objectResult;
        }
    }
}
