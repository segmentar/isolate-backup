using Core;

namespace Core
{
    using System;

    public partial struct Materialxportableconfigure
    {
        public static Materialxportableconfigure Data()
        {
            Materialxportableconfigure materialxportableconfigureResult = default;

            Materialxportableconfigure materialxportableconfigure;

            materialxportableconfigure.WriterEncodingObject = Immutable.WriterEncoding;

            materialxportableconfigure.ReaderEncodingObject = Immutable.ReaderEncoding;

            materialxportableconfigure.StartAddressObject = Immutable.StartAddress;

            materialxportableconfigure.ChunkSizeObject = Immutable.ChunkSize;

            materialxportableconfigureResult = materialxportableconfigure;

            return materialxportableconfigureResult;
        }
    }
}
