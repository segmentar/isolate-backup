using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class MaterialxportablereadbuildModule
    {
        public partial class XSingle
        {
            public static XSingle ForgeLevel(MemoryStream value_MEMORYSTREAM, Materialxportablelayout value_MATERIALXPORTABLELAYOUT)
            {
                XSingle xsingleResult = default;

                BinaryReader binaryReader;

                binaryReader = new BinaryReader(value_MEMORYSTREAM, Materialxportableconfigure.ReaderEncoding, true);

                var array = FunctionLevelSetSurface(binaryReader, value_MATERIALXPORTABLELAYOUT);

                XSingle xsingle;

                xsingle = new XSingle(binaryReader, array);

                xsingleResult = xsingle;

                return xsingleResult;
            }
        }
    }
}
