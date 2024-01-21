using Core;

namespace Core
{
    using System;

    public partial class Materialxportableremotein
    {
        public static void GroupUInt32(Materialxportable value_MATERIALXPORTABLE)
        {
            var reflect = (UInt32)(value_MATERIALXPORTABLE.ObjectIdentity as Object);

            var data = BitConverter.GetBytes(reflect);

            var array = new Byte[sizeof(UInt32)];

            data.CopyTo(array, MaterialxportablePolicy.MaterialxportableIndexPolicy);

            value_MATERIALXPORTABLE.RemoteArrayObject = array;

            return;
        }
    }
}
