using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class MaterialxportablewritestreamModule
    {
        public partial class XSingle
        {
            public static XSingle ForgeLevel(Materialxportablelayout value_MATERIALXPORTABLELAYOUT)
            {
                XSingle xsingleResult = default;

                MemoryStream memoryStream;

                memoryStream = new MemoryStream();

                BinaryWriter binaryWriter;

                binaryWriter = new BinaryWriter(memoryStream, Materialxportableconfigure.WriterEncoding, true);

                using (binaryWriter)
                {
                    var absorb = new UInt32[3];

                    absorb[0] = Convert.ToUInt32(value_MATERIALXPORTABLELAYOUT.MaterialCount);

                    absorb[1] = Convert.ToUInt32(value_MATERIALXPORTABLELAYOUT.StartAddressSubjectTable);

                    absorb[2] = Convert.ToUInt32(value_MATERIALXPORTABLELAYOUT.StartAddressObjectTable);

                    binaryWriter.Write(absorb[0]);

                    binaryWriter.Write(absorb[1]);

                    binaryWriter.Write(absorb[2]);

                    binaryWriter.Close();

                    binaryWriter.Dispose();
                }

                var array = memoryStream.ToArray();

                XSingle xsingle;

                xsingle = new XSingle(memoryStream, binaryWriter, array);

                xsingleResult = xsingle;

                return xsingleResult;
            }
        }
    }
}
