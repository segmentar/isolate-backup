using Core;

namespace Core
{
    using System;

    public partial class Materialxportableremotein
    {
        public static void GroupInt32(Materialxportable value_MATERIALXPORTABLE)
        {
            var reflect = (Int32)(value_MATERIALXPORTABLE.ObjectIdentity as Object);

            var data = BitConverter.GetBytes(reflect);

            var array = new Byte[sizeof(Int32)];

            data.CopyTo(array, MaterialxportablePolicy.MaterialxportableIndexPolicy);

            value_MATERIALXPORTABLE.RemoteArrayObject = array;

            return;
        }
    }
}
