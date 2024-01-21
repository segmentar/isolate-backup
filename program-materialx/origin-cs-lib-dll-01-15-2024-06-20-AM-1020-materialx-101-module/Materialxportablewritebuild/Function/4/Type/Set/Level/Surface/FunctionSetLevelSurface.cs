using Core;

namespace Core
{
    using System;

    public partial class MaterialxportablewritebuildModule
    {
        public static MaterialxportablewriteXlev_lY[] FunctionLevelSetSurface(MaterialxportablewriteXle_elY[] Level_ARRAY)
        {
            MaterialxportablewriteXlev_lY[] arrayResult = default;

            var list = FunctionLevelSet(Level_ARRAY);

            var array = new MaterialxportablewriteXlev_lY[list.Count];

            list.CopyTo(array, MaterialxportablePolicy.MaterialxportableIndexPolicy);

            arrayResult = array;

            return arrayResult;
        }
    }
}
