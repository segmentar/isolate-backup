using Core;

namespace Core
{
    using System;

    using System.IO;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class MaterialxportablereadbuildModule
    {
        public static IList<MaterialxportablereadX_evelY> FunctionLevelSet(BinaryReader value_BINARYREADER, Materialxportablelayout value_MATERIALXPORTABLELAYOUT)
        {
            ICollection<MaterialxportablereadX_evelY> collectionResult = default;

            collectionResult = new Collection<MaterialxportablereadX_evelY>();

            using (value_BINARYREADER)
            {
                var position = 0;

                position = position + value_MATERIALXPORTABLELAYOUT.StartAddressSubjectTable;

                var indexer = 0;

                do
                {
                    Boolean shouldBreakContagentCheck;

                    shouldBreakContagentCheck = Object.Equals(value_MATERIALXPORTABLELAYOUT.MaterialCount, indexer) is true;

                    if (shouldBreakContagentCheck)
                    {
                        break;
                    }
                    else
                    {
                        value_BINARYREADER.BaseStream.Seek(position, SeekOrigin.Begin);
                    }

                    position = position + Materialxportableconfigure.ChunkSize;

                    var absorb = new Int32[8];

                    absorb[0] = Convert.ToInt32(value_BINARYREADER.ReadUInt32());

                    absorb[1] = Convert.ToInt32(value_BINARYREADER.ReadUInt32());

                    absorb[2] = Convert.ToInt32(value_BINARYREADER.ReadUInt32());

                    absorb[3] = Convert.ToInt32(value_BINARYREADER.ReadUInt32());

                    absorb[4] = Convert.ToInt32(value_BINARYREADER.ReadUInt32());

                    absorb[5] = Convert.ToInt32(value_BINARYREADER.ReadUInt32());

                    absorb[6] = Convert.ToInt32(value_BINARYREADER.ReadUInt32());

                    absorb[7] = Convert.ToInt32(value_BINARYREADER.ReadUInt32());

                    MaterialxportablereadX_evelY level;

                    level = new MaterialxportablereadX_evelY();

                    level.Ordinal = absorb[0];

                    level.Length = absorb[1];

                    level.RouteStartAddress = absorb[2];

                    level.RouteEndAddress = absorb[3];

                    level.ObjectStartAddress = absorb[4];

                    level.ObjectEndAddress = absorb[5];

                    level.TypeStartAddress = absorb[6];

                    level.TypeEndAddress = absorb[7];

                    collectionResult.Add(level);

                    indexer = indexer + 1;

                    continue;

                } while (true);

                value_BINARYREADER.Close();

                value_BINARYREADER.Dispose();
            }

            return new List<MaterialxportablereadX_evelY>(collectionResult);
        }
    }
}
