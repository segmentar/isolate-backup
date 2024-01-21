using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class MaterialxportablereadbuildModule
    {
        public static MaterialxportablereadX_evelY[] FunctionLevelSetSurface(BinaryReader value_BINARYREADER, Materialxportablelayout value_MATERIALXPORTABLELAYOUT)
        {
            MaterialxportablereadX_evelY[] arrayResult = default;

            var list = FunctionLevelSet(value_BINARYREADER, value_MATERIALXPORTABLELAYOUT);

            var array = new MaterialxportablereadX_evelY[list.Count];

            list.CopyTo(array, MaterialxportablePolicy.MaterialxportableIndexPolicy);

            arrayResult = array;

            return arrayResult;
        }
    }
}
