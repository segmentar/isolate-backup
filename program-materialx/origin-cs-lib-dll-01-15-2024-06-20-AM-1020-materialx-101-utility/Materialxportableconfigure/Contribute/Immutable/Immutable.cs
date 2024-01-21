using Core;

namespace Core
{
    using System;

    using System.Text;

    public partial struct Materialxportableconfigure
    {
        public partial class Immutable
        {
            public static readonly Encoding WriterEncoding;

            public static readonly Encoding ReaderEncoding;

            public static readonly Int32 StartAddress;

            public static readonly Int32 ChunkSize;

            static Immutable()
            {
                WriterEncoding = MaterialxportableconfigureDefault.WriterEncodingDefault;

                ReaderEncoding = MaterialxportableconfigureDefault.ReaderEncodingDefault;

                StartAddress = MaterialxportableconfigureDefault.StartAddressDefault;

                ChunkSize = MaterialxportableconfigureDefault.ChunkSizeDefault;

                return;
            }
        }
    }
}
