using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial struct MaterialxportablewritebuildPort
    {
        public MaterialxportablewriteX_evelY[] Level;

        public MaterialxportablewriteXl_velY[] LevelLevel;

        public MaterialxportablewriteXle_elY[] LevelLevelLevel;

        public MaterialxportablewriteXlev_lY[] LevelLevelLevelLevel;

        public MaterialxportablewriteXleve_Y[] LevelLevelLevelLevelLevel;

        public MaterialxportablewriteU_evelV[] LevelLevelLevelLevelLevelLevel;
    }

    public partial struct MaterialxportablewritestreamPort
    {
        public MemoryStream HeaderTableMemoryStream;

        public MemoryStream SubjectTableMemoryStream;

        public MemoryStream ObjectTableMemoryStream;

        public Byte[] HeaderTableByteArray;

        public Byte[] SubjectTableByteArray;

        public Byte[] ObjectTableByteArray;
    }

    public partial struct MaterialxportablewritefilePort
    {
        public FileStream FileStream;

        public MemoryStream MemoryStream;
    }

    public partial struct MaterialxportablereadfilePort
    {
        public FileStream FileStream;

        public MemoryStream MemoryStream;

        public Byte[] ByteArray;
    }

    public partial struct MaterialxportablereadstreamPort
    {
        public Materialxportablelayout Materialxportablelayout;
    }

    public partial struct MaterialxportablereadbuildPort
    {
        public MaterialxportablereadX_evelY[] Level;

        public MaterialxportablereadXl_velY[] LevelLevel;

        public MaterialxportablereadXle_elY[] LevelLevelLevel;

        public MaterialxportablereadXlev_lY[] LevelLevelLevelLevel;

        public Materialxportable[] MaterialxportableArray;

        public Materialxportable Materialxportable;
    }
}
