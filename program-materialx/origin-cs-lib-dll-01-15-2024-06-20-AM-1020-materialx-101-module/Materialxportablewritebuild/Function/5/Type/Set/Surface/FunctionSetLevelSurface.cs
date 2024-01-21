using Core;

namespace Core
{
    using System;

    public partial class MaterialxportablewritebuildModule
    {
        public partial class XQuintuple
        {
            public static MaterialxportablewriteXleve_Y[] FunctionLevelSetSurface(MaterialxportablewriteXlev_lY[] Level_ARRAY, Materialxportablelayout value_MATERIALXPORTABLELAYOUT)
            {
                MaterialxportablewriteXleve_Y[] arrayResult = default;

                var list = FunctionLevelSet(Level_ARRAY, value_MATERIALXPORTABLELAYOUT);

                var array = new MaterialxportablewriteXleve_Y[list.Count];

                list.CopyTo(array, MaterialxportablePolicy.MaterialxportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
