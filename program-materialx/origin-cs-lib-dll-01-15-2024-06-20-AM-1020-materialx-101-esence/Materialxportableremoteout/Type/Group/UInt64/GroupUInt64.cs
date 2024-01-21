using Core;

namespace Core
{
    using System;

    public partial class Materialxportableremoteout
    {
        public static Object GroupUInt64(Byte[] array_BYTE)
        {
            Object objectResult = default;

            var result = BitConverter.ToUInt64(array_BYTE, 0);

            objectResult = result;

            return objectResult;
        }
    }
}
