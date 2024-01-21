using Core;

namespace Core
{
    using System;

    public partial class MaterialxportablereadbuildModule
    {
        public partial class XZeroth
        {
            public static Materialxportable[] FunctionMaterialSetSurface(MaterialxportablereadXlev_lY[] Level_ARRAY)
            {
                Materialxportable[] arrayResult = default;

                var list = FunctionMaterialSet(Level_ARRAY);

                var array = new Materialxportable[list.Count];

                list.CopyTo(array, MaterialxportablePolicy.MaterialxportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
