using Core;

namespace Core
{
    using System;

    public partial class Materialxportableremotein
    {
        public static void Remote(Materialxportable[] array_MATERIALXPORTABLE)
        {
            foreach (Materialxportable value_MATERIALXPORTABLE in array_MATERIALXPORTABLE)
            {
                if (Object.Equals(value_MATERIALXPORTABLE.Type, typeof(Boolean)))
                {
                    GroupBoolean(value_MATERIALXPORTABLE);
                }
                else if (Object.Equals(value_MATERIALXPORTABLE.Type, typeof(Char)))
                {
                    GroupChar(value_MATERIALXPORTABLE);
                }
                else if (Object.Equals(value_MATERIALXPORTABLE.Type, typeof(String)))
                {
                    GroupString(value_MATERIALXPORTABLE);
                }
                else if (Object.Equals(value_MATERIALXPORTABLE.Type, typeof(Byte)))
                {
                    GroupByte(value_MATERIALXPORTABLE);
                }
                else if (Object.Equals(value_MATERIALXPORTABLE.Type, typeof(UInt16)))
                {
                    GroupUInt16(value_MATERIALXPORTABLE);
                }
                else if (Object.Equals(value_MATERIALXPORTABLE.Type, typeof(UInt32)))
                {
                    GroupUInt32(value_MATERIALXPORTABLE);
                }
                else if (Object.Equals(value_MATERIALXPORTABLE.Type, typeof(UInt64)))
                {
                    GroupUInt64(value_MATERIALXPORTABLE);
                }
                else if (Object.Equals(value_MATERIALXPORTABLE.Type, typeof(SByte)))
                {
                    GroupSByte(value_MATERIALXPORTABLE);
                }
                else if (Object.Equals(value_MATERIALXPORTABLE.Type, typeof(Int16)))
                {
                    GroupInt16(value_MATERIALXPORTABLE);
                }
                else if (Object.Equals(value_MATERIALXPORTABLE.Type, typeof(Int32)))
                {
                    GroupInt32(value_MATERIALXPORTABLE);
                }
                else if (Object.Equals(value_MATERIALXPORTABLE.Type, typeof(Int64)))
                {
                    GroupInt64(value_MATERIALXPORTABLE);
                }
                else
                {
                    GroupObject(value_MATERIALXPORTABLE);
                }                   
                
                continue;
            }

            return;
        }
    }
}
