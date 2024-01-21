using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class MaterialxportablewritestreamModule
    {
        public partial class XDouble
        {
            public static XDouble ForgeLevel(Materialxportablelayout value_MATERIALXPORTABLELAYOUT, MaterialxportablewriteU_evelV[] Level_ARRAY)
            {
                XDouble xdoubleResult = default;

                MemoryStream memoryStream;

                memoryStream = new MemoryStream();

                BinaryWriter binaryWriter;

                binaryWriter = new BinaryWriter(memoryStream, Materialxportableconfigure.WriterEncoding, true);

                using (binaryWriter)
                {
                    var index = 0;

                    foreach (MaterialxportablewriteU_evelV Level_VALUE in Level_ARRAY)
                    {
                        binaryWriter.BaseStream.Seek(index, SeekOrigin.Begin);

                        var absorb = new UInt32[8];

                        absorb[0] = Convert.ToUInt32(Level_VALUE.Ordinal);

                        absorb[1] = Convert.ToUInt32(Level_VALUE.Length);

                        absorb[2] = Convert.ToUInt32(Level_VALUE.RouteStartAddress);

                        absorb[3] = Convert.ToUInt32(Level_VALUE.RouteEndAddress);

                        absorb[4] = Convert.ToUInt32(Level_VALUE.ObjectStartAddress);

                        absorb[5] = Convert.ToUInt32(Level_VALUE.ObjectEndAddress);

                        absorb[6] = Convert.ToUInt32(Level_VALUE.TypeStartAddress);

                        absorb[7] = Convert.ToUInt32(Level_VALUE.TypeEndAddress);

                        binaryWriter.Write(absorb[0]);

                        binaryWriter.Write(absorb[1]);

                        binaryWriter.Write(absorb[2]);

                        binaryWriter.Write(absorb[3]);

                        binaryWriter.Write(absorb[4]);

                        binaryWriter.Write(absorb[5]);

                        binaryWriter.Write(absorb[6]);

                        binaryWriter.Write(absorb[7]);

                        index = index + Materialxportableconfigure.ChunkSize;

                        continue;
                    }

                    binaryWriter.Close();

                    binaryWriter.Dispose();
                }

                var array = memoryStream.ToArray();

                XDouble xdouble;

                xdouble = new XDouble(memoryStream, binaryWriter, array);

                xdoubleResult = xdouble;

                return xdoubleResult;
            }
        }
    }
}
