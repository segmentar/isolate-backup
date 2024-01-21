using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class MaterialxportablereadstreamModule
    {
        [Materialxportableisc]
        public partial class XSingle
        {
            public BinaryReader BinaryReader;

            public Materialxportablelayout Materialxportablelayout;

            public XSingle(BinaryReader binaryReader, Materialxportablelayout materialxportablelayout)
            {
                this.BinaryReader = binaryReader;

                this.Materialxportablelayout = materialxportablelayout;

                return;
            }

            ~XSingle()
            {
                return;
            }

            [Materialxportableism]
            public override String ToString()
            {
                return String.Join('\n'.ToString(), new String[] {

                String.Empty + nameof(XSingle) + ' ' + "::" + ' ' + '{',
                String.Empty + '.' + "function",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(BinaryReader) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(Materialxportablelayout) + ':' + ' ' + ". . .",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(BinaryReader) + ':',
                String.Empty + BinaryReader,
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(Materialxportablelayout) + ':',
                String.Empty + Materialxportablelayout
            });
            }
        }
    }
}
