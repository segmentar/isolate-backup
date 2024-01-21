using Core;

namespace Core
{
    using System;

    public partial class Materialxportableremotein
    {
        public static void GroupByte(Materialxportable value_MATERIALXPORTABLE)
        {
            var reflect = (Byte)(value_MATERIALXPORTABLE.ObjectIdentity as Object);

            var data = BitConverter.GetBytes(reflect);

            var array = new Byte[sizeof(Byte)];

            data.CopyTo(array, MaterialxportablePolicy.MaterialxportableIndexPolicy);

            value_MATERIALXPORTABLE.RemoteArrayObject = array;

            return;
        }
    }
}
