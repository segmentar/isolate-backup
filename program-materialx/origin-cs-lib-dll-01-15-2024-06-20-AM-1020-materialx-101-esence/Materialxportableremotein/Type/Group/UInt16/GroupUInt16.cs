using Core;

namespace Core
{
    using System;

    public partial class Materialxportableremotein
    {
        public static void GroupUInt16(Materialxportable value_MATERIALXPORTABLE)
        {
            var reflect = (UInt16)(value_MATERIALXPORTABLE.ObjectIdentity as Object);

            var data = BitConverter.GetBytes(reflect);

            var array = new Byte[sizeof(UInt16)];

            data.CopyTo(array, MaterialxportablePolicy.MaterialxportableIndexPolicy);

            value_MATERIALXPORTABLE.RemoteArrayObject = array;

            return;
        }
    }
}
