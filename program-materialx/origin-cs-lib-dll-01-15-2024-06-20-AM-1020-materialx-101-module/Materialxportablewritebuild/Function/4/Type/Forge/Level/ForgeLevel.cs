using Core;

namespace Core
{
    using System;

    public partial class MaterialxportablewritebuildModule
    {
        public partial class XQuadruple
        {
            public static XQuadruple ForgeLevel(MaterialxportablewriteXle_elY[] Level_ARRAY)
            {
                XQuadruple xquadrupleResult = default;

                var array = FunctionLevelSetSurface(Level_ARRAY);

                XQuadruple xquadruple;

                xquadruple = new XQuadruple(array);

                xquadrupleResult = xquadruple;

                return xquadrupleResult;
            }
        }
    }
}
