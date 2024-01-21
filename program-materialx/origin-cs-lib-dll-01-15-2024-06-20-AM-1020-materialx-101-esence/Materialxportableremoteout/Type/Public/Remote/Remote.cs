using Core;

namespace Core
{
    using System;

    public partial class  Materialxportableremoteout
    {
        public static Object Remote(Byte[] array_BYTE, Type value_TYPE)
        {
            Object objectResult = default;

            if (Object.Equals(value_TYPE, typeof(Boolean)))
            {
                objectResult = GroupBoolean(array_BYTE);
            }
            else if (Object.Equals(value_TYPE, typeof(Char)))
            {
                objectResult = GroupChar(array_BYTE);
            }
            else if (Object.Equals(value_TYPE, typeof(String)))
            {
                objectResult = GroupString(array_BYTE);
            }
            else if (Object.Equals(value_TYPE, typeof(Byte)))
            {
                objectResult = GroupByte(array_BYTE);
            }
            else if (Object.Equals(value_TYPE, typeof(UInt16)))
            {
                objectResult = GroupUInt16(array_BYTE);
            }
            else if (Object.Equals(value_TYPE, typeof(UInt32)))
            {
                objectResult = GroupUInt32(array_BYTE);
            }
            else if (Object.Equals(value_TYPE, typeof(UInt64)))
            {
                objectResult = GroupUInt64(array_BYTE);
            }
            else if (Object.Equals(value_TYPE, typeof(SByte)))
            {
                objectResult = GroupSByte(array_BYTE);
            }
            else if (Object.Equals(value_TYPE, typeof(Int16)))
            {
                objectResult = GroupInt16(array_BYTE);
            }
            else if (Object.Equals(value_TYPE, typeof(Int32)))
            {
                objectResult = GroupInt32(array_BYTE);
            }
            else if (Object.Equals(value_TYPE, typeof(Int64)))
            {
                objectResult = GroupInt64(array_BYTE);
            }
            else
            {
                objectResult = GroupObject(array_BYTE);
            }

            return objectResult;
        }
    }
}
