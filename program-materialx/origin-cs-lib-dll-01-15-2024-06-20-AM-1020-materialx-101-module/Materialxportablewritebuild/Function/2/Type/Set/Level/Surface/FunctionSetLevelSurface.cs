using Core;

namespace Core
{
    using System;

    public partial class MaterialxportablewritebuildModule
    {
        public partial class XDouble
        {
            public static MaterialxportablewriteXl_velY[] FunctionLevelSetSurface(MaterialxportablewriteX_evelY[] Level_ARRAY)
            {
                MaterialxportablewriteXl_velY[] arrayResult = default;

                var list = FunctionLevelSet(Level_ARRAY);

                var array = new MaterialxportablewriteXl_velY[list.Count];

                list.CopyTo(array, MaterialxportablePolicy.MaterialxportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
