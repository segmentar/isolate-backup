using Core;

namespace Core
{
    using System;

    public partial class MaterialxportablereadbuildModule
    {
        public partial class XTriple
        {
            public static MaterialxportablereadXle_elY[] FunctionLevelSetSurface(MaterialxportablereadXl_velY[] Level_ARRAY)
            {
                MaterialxportablereadXle_elY[] arrayResult = default;

                var list = FunctionLevelSet(Level_ARRAY);

                var array = new MaterialxportablereadXle_elY[list.Count];

                list.CopyTo(array, MaterialxportablePolicy.MaterialxportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
