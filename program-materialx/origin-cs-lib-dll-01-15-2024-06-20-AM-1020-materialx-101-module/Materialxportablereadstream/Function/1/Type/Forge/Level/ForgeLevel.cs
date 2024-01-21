using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class MaterialxportablereadstreamModule
    {
        public partial class XSingle
        {
            public static XSingle ForgeLevel(MemoryStream memoryStream)
            {
                XSingle xsingleResult = default;

                BinaryReader binaryReader;

                binaryReader = new BinaryReader(memoryStream, Materialxportableconfigure.ReaderEncoding, true);

                Materialxportablelayout materialxportablelayout;

                materialxportablelayout = new Materialxportablelayout();

                using (binaryReader)
                {
                    var absorb = new Int32[3];

                    absorb[0] = Convert.ToInt32(binaryReader.ReadUInt32());

                    absorb[1] = Convert.ToInt32(binaryReader.ReadUInt32());

                    absorb[2] = Convert.ToInt32(binaryReader.ReadUInt32());

                    materialxportablelayout.MaterialCount = absorb[0];

                    materialxportablelayout.StartAddressSubjectTable = absorb[1];

                    materialxportablelayout.StartAddressObjectTable = absorb[2];

                    binaryReader.Close();

                    binaryReader.Dispose();
                }

                XSingle xsingle;

                xsingle = new XSingle(binaryReader, materialxportablelayout);

                xsingleResult = xsingle;

                return xsingleResult;
            }
        }
    }
}
