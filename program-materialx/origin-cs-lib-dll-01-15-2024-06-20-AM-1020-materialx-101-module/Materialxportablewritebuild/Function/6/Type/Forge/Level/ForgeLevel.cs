using Core;

namespace Core
{
    using System;

    public partial class MaterialxportablewritebuildModule
    {
        public partial class XSextuple
        {
            public static XSextuple ForgeLevel(MaterialxportablewriteXleve_Y[] Level_ARRAY)
            {
                XSextuple xsextupleResult = default;

                var array = FunctionLevelSetSurface(Level_ARRAY);

                XSextuple xsextuple;

                xsextuple = new XSextuple(array);

                xsextupleResult = xsextuple;

                return xsextupleResult;
            }
        }
    }
}
