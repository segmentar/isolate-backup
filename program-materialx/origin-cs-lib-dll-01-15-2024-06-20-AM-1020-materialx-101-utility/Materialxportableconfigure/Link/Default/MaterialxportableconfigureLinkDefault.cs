using Core;

namespace Core
{
    using System;

    using System.Text;

    public partial class MaterialxportableconfigureDefault
    {
        public static Encoding WriterEncodingDefault;

        public static Encoding ReaderEncodingDefault;

        public static Int32 StartAddressDefault;

        public static Int32 ChunkSizeDefault;

        static MaterialxportableconfigureDefault()
        {
            WriterEncodingDefault = Encoding.Default;

            ReaderEncodingDefault = Encoding.Default;

            StartAddressDefault = 300;

            ChunkSizeDefault = 300;

            return;
        }
    }
}
