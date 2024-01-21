using Core;

namespace Core
{
    using System;

    public partial class Materialxportableremotein
    {
        public static void GroupBoolean(Materialxportable value_MATERIALXPORTABLE)
        {
            var reflect = (Boolean)(value_MATERIALXPORTABLE.ObjectIdentity as Object);

            var data = BitConverter.GetBytes(reflect);

            var array = new Byte[sizeof(Boolean)];

            data.CopyTo(array, MaterialxportablePolicy.MaterialxportableIndexPolicy);

            value_MATERIALXPORTABLE.RemoteArrayObject = array;

            return;
        }
    }
}
