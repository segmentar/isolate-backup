using Core;

namespace Core
{
    using System;

    public partial class Materialxportableremoteout
    {
        public static Object GroupSByte(Byte[] array_BYTE)
        {
            Object objectResult = default;

            var value = BitConverter.ToInt16(array_BYTE, 0);

            var convert = Convert.ToSByte(value);

            var result = convert;

            objectResult = result;

            return objectResult;
        }
    }
}
