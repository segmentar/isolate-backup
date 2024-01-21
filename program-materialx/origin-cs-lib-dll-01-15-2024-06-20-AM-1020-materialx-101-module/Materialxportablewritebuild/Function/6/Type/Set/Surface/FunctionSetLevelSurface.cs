using Core;

namespace Core
{
    using System;

    public partial class MaterialxportablewritebuildModule
    {
        public partial class XSextuple
        {
            public static MaterialxportablewriteU_evelV[] FunctionLevelSetSurface(MaterialxportablewriteXleve_Y[] Level_ARRAY)
            {
                MaterialxportablewriteU_evelV[] arrayResult = default;

                var list = FunctionLevelSet(Level_ARRAY);

                var array = new MaterialxportablewriteU_evelV[list.Count];

                list.CopyTo(array, MaterialxportablePolicy.MaterialxportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
