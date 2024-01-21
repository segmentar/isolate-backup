using Core;

namespace Core
{
    using System;

    public partial class MaterialxportablewritebuildModule
    {
        public partial class XQuintuple
        {
            public static XQuintuple ForgeLevel(MaterialxportablewriteXlev_lY[] Level_ARRAY, Materialxportablelayout value_MATERIALXPORTABLELAYOUT)
            {
                XQuintuple xquintupleResult = default;

                var array = FunctionLevelSetSurface(Level_ARRAY, value_MATERIALXPORTABLELAYOUT);

                XQuintuple xquintuple;

                xquintuple = new XQuintuple(array);

                xquintupleResult = xquintuple;

                return xquintupleResult;
            }
        }
    }
}
