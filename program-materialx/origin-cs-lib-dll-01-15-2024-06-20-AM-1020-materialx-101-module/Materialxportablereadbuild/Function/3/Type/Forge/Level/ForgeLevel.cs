using Core;

namespace Core
{
    using System;

    public partial class MaterialxportablereadbuildModule
    {
        public partial class XTriple
        {
            public static XTriple ForgeLevel(MaterialxportablereadXl_velY[] Level_ARRAY)
            {
                XTriple xtripleResult = default;

                var array = FunctionLevelSetSurface(Level_ARRAY);

                XTriple xtriple;

                xtriple = new XTriple(array);

                xtripleResult = xtriple;

                return xtripleResult;
            }
        }
    }
}
