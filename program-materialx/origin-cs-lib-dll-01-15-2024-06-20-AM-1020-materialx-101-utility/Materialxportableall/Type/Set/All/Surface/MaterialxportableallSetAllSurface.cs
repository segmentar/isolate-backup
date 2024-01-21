using Core;

namespace Core
{
    using System;

    public partial class Materialxportableall
    {
        public static Materialxportable[] MaterialxportableallAllSetSurface(Materialxportable value_MATERIALXPORTABLE, Boolean answer_SELF_should)
        {
            Materialxportable[] arrayResult = default;

            var list = MaterialxportableallAllSet(value_MATERIALXPORTABLE, answer_SELF_should);

            var array = new Materialxportable[list.Count];

            list.CopyTo(array, MaterialxportablePolicy.MaterialxportableIndexPolicy);

            arrayResult = array;

            return arrayResult;
        }
    }
}
