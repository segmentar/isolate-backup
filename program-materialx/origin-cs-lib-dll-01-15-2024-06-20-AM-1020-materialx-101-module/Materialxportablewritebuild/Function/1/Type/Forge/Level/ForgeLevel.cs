using Core;

namespace Core
{
    using System;

    public partial class MaterialxportablewritebuildModule
    {
        public partial class XSingle
        {
            public static XSingle ForgeLevel(Materialxportable[] array_MATERIALXPORTABLE)
            {
                XSingle xsingleResult = default;

                var array = FunctionLevelSetSurface(array_MATERIALXPORTABLE);

                XSingle xsingle;

                xsingle = new XSingle(array);

                xsingleResult = xsingle;

                return xsingleResult;
            }
        }
    }
}
