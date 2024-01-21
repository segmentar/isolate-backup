using Core;

namespace Core
{
    using System;

    using System.Text;

    public partial struct Materialxportableconfigure
    {
        public static void Import(Materialxportableconfigure value_MATERIALXPORTABLECONFIGURE)
        {
            WriterEncoding = (Encoding)value_MATERIALXPORTABLECONFIGURE.WriterEncodingObject;

            ReaderEncoding = (Encoding)value_MATERIALXPORTABLECONFIGURE.ReaderEncodingObject;

            StartAddress = (Int32)value_MATERIALXPORTABLECONFIGURE.StartAddressObject;

            ChunkSize = (Int32)value_MATERIALXPORTABLECONFIGURE.ChunkSizeObject;

            return;
        }
    }
}
