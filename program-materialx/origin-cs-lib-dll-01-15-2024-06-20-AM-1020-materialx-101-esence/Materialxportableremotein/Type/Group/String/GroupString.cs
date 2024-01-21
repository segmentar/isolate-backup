using Core;

namespace Core
{
    using System;

    public partial class Materialxportableremotein
    {
        public static void GroupString(Materialxportable value_MATERIALXPORTABLE)
        {
            var reflect = (String)(value_MATERIALXPORTABLE.ObjectIdentity as Object);

            var data = Materialxportableconfigure.WriterEncoding.GetBytes(reflect);

            var array = new Byte[data.Length];

            data.CopyTo(array, MaterialxportablePolicy.MaterialxportableIndexPolicy);

            value_MATERIALXPORTABLE.RemoteArrayObject = array;

            return;
        }
    }
}
