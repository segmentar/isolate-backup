using Core;

namespace Core
{
    using System;

    public partial class Materialxportableremotein
    {
        public static void GroupUInt64(Materialxportable value_MATERIALXPORTABLE)
        {
            var reflect = (UInt64)(value_MATERIALXPORTABLE.ObjectIdentity as Object);

            var data = BitConverter.GetBytes(reflect);

            var array = new Byte[sizeof(UInt64)];

            data.CopyTo(array, MaterialxportablePolicy.MaterialxportableIndexPolicy);

            value_MATERIALXPORTABLE.RemoteArrayObject = array;

            return;
        }
    }
}
