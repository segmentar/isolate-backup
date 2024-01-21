using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class MaterialxportablereadbuildModule
    {
        public partial class XDouble
        {
            public static XDouble ForgeLeveL(MaterialxportablereadX_evelY[] Level_ARRAY, MemoryStream value_MEMORYSTREAM)
            {
                XDouble xdoubleResult = default;

                BinaryReader binaryReader;

                binaryReader = new BinaryReader(value_MEMORYSTREAM, Materialxportableconfigure.ReaderEncoding, true);

                var array = FunctionLevelSetSurface(Level_ARRAY, binaryReader);

                XDouble xdouble;

                xdouble = new XDouble(binaryReader, array);

                xdoubleResult = xdouble;

                return xdoubleResult;
            }
        }
    }
}
