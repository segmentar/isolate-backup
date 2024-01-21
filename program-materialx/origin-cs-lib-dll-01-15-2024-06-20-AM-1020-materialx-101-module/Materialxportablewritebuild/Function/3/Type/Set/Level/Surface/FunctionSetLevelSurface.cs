using Core;

namespace Core
{
    using System;

    public partial class MaterialxportablewritebuildModule
    {
        public partial class XTriple
        {
            public static MaterialxportablewriteXle_elY[] FunctionLeveLSetSurface(MaterialxportablewriteXl_velY[] Level_ARRAY)
            {
                MaterialxportablewriteXle_elY[] arrayResult = default;

                var list = FunctionLeveLSet(Level_ARRAY);

                var array = new MaterialxportablewriteXle_elY[list.Count];

                list.CopyTo(array, MaterialxportablePolicy.MaterialxportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
