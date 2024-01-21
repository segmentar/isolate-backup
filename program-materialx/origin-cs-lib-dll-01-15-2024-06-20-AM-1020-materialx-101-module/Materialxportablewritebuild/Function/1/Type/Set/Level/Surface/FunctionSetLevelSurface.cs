using Core;

namespace Core
{
    using System;

    public partial class MaterialxportablewritebuildModule
    {
        public partial class XSingle
        {
            public static MaterialxportablewriteX_evelY[] FunctionLevelSetSurface(Materialxportable[] array_MATERIALXPORTABLE)
            {
                MaterialxportablewriteX_evelY[] arrayResult = default;

                var list = FunctionLevelSet(array_MATERIALXPORTABLE);

                var array = new MaterialxportablewriteX_evelY[list.Count];

                list.CopyTo(array, MaterialxportablePolicy.MaterialxportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
