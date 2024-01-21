using Core;

namespace Core
{
    using System;

    public partial class MaterialxportablewritebuildModule
    {
        public partial class XTriple
        {
            public static XTriple ForgeLevel(MaterialxportablewriteXl_velY[] Level_ARRAY)
            {
                XTriple xtripleResult = default;

                var array = FunctionLeveLSetSurface(Level_ARRAY);

                XTriple xtriple;

                xtriple = new XTriple(array);

                xtripleResult = xtriple;

                return xtripleResult;
            }
        }
    }
}
