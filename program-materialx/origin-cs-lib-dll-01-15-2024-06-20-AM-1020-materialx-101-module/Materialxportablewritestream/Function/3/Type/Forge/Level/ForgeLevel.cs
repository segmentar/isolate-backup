using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class MaterialxportablewritestreamModule
    {
        public partial class XTriple
        {
            public static XTriple ForgeLevel(MaterialxportablewriteU_evelV[] Level_ARRAY)
            {
                XTriple xtripleResult = default;

                MemoryStream memoryStream;

                memoryStream = new MemoryStream();

                BinaryWriter binaryWriter;

                binaryWriter = new BinaryWriter(memoryStream, Materialxportableconfigure.WriterEncoding, true);

                using (binaryWriter)
                {
                    foreach (MaterialxportablewriteU_evelV Level_VALUE in Level_ARRAY)
                    {
                        binaryWriter.Write(Level_VALUE.RouteByteArray);

                        binaryWriter.Write(Level_VALUE.ObjectByteArray);

                        binaryWriter.Write(Level_VALUE.TypeByteArray);

                        continue;
                    }

                    binaryWriter.Close();

                    binaryWriter.Dispose();
                }

                var array = memoryStream.ToArray();

                XTriple xtriple;

                xtriple = new XTriple(memoryStream, binaryWriter, array);

                xtripleResult = xtriple;

                return xtripleResult;
            }
        }
    }
}
