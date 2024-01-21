using Core;

namespace Core
{
    using System;

    public partial struct Materialxportableconfigure
    {
        public static Materialxportableconfigure Export()
        {
            Materialxportableconfigure materialxportableconfigureResult = default;

            Materialxportableconfigure materialxportableconfigure;

            materialxportableconfigure.WriterEncodingObject = WriterEncoding;

            materialxportableconfigure.ReaderEncodingObject = ReaderEncoding;

            materialxportableconfigure.StartAddressObject = StartAddress;

            materialxportableconfigure.ChunkSizeObject = ChunkSize;

            materialxportableconfigureResult = materialxportableconfigure;

            return materialxportableconfigureResult;
        }
    }
}
