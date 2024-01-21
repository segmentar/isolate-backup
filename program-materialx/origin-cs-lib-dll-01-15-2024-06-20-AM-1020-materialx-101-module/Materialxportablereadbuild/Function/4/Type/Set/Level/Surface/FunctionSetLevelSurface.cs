using Core;

namespace Core
{
    using System;

    public partial class MaterialxportablereadbuildModule
    {
        public partial class XQuadruple
        {
            public static MaterialxportablereadXlev_lY[] FunctionLevelSetSurface(MaterialxportablereadXle_elY[] Level_ARRAY)
            {
                MaterialxportablereadXlev_lY[] arrayResult = default;

                var list = FunctionLevelSet(Level_ARRAY);

                var array = new MaterialxportablereadXlev_lY[list.Count];

                list.CopyTo(array, MaterialxportablePolicy.MaterialxportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
