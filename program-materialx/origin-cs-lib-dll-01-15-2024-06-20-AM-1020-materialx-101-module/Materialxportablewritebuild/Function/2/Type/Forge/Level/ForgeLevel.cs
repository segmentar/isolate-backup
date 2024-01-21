using Core;

namespace Core
{
    using System;

    public partial class MaterialxportablewritebuildModule
    {
        public partial class XDouble
        {
            public static XDouble ForgeLevel(MaterialxportablewriteX_evelY[] Level_ARRAY)
            {
                var array = FunctionLevelSetSurface(Level_ARRAY);

                XDouble xdoubleResult = default;

                XDouble xdouble;

                xdouble = new XDouble(array);

                xdoubleResult = xdouble;

                return xdoubleResult;
            }
        }
    }
}
