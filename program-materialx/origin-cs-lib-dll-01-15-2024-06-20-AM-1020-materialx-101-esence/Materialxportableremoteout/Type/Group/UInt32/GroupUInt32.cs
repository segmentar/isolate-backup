using Core;

namespace Core
{
    using System;

    public partial class Materialxportableremoteout
    {
        public static Object GroupUInt32(Byte[] array_BYTE)
        {
            Object objectResult = default;

            var result = BitConverter.ToUInt32(array_BYTE, 0);

            objectResult = result;

            return objectResult;
        }
    }
}
