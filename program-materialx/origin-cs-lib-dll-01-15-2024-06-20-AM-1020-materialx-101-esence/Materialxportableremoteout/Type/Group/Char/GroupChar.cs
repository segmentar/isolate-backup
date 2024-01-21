using Core;

namespace Core
{
    using System;

    public partial class Materialxportableremoteout
    {
        public static Object GroupChar(Byte[] array_BYTE)
        {
            Object objectResult = default;

            var result = BitConverter.ToChar(array_BYTE, 0);

            objectResult = result;

            return objectResult;
        }
    }
}
