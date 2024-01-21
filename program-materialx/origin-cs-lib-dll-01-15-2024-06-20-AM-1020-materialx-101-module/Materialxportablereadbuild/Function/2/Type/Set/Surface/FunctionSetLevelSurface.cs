using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class MaterialxportablereadbuildModule
    {
        public partial class XDouble
        {
            public static MaterialxportablereadXl_velY[] FunctionLevelSetSurface(MaterialxportablereadX_evelY[] Level_ARRAY, BinaryReader value_BINARYREADER)
            {
                MaterialxportablereadXl_velY[] arrayResult = default;

                var list = FunctionLevelSet(Level_ARRAY, value_BINARYREADER);

                var array = new MaterialxportablereadXl_velY[list.Count];

                list.CopyTo(array, MaterialxportablePolicy.MaterialxportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
