using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class MaterialxportablewritefileModule
    {

        [Materialxportableisc]
        public partial class XSingle
        {
            public FileStream FileStream;

            public XSingle(FileStream fileStream)
            {
                this.FileStream = fileStream;

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

                String.Empty + nameof(FileStream) + ' ' + "::" + ' ' + '{',
                String.Empty + '.' + "function",
                String.Empty + '\t' + '~' + "10" + ' ' + nameof(FileStream) + ':' + ' ' + ". . .",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(FileStream) + ':',
                String.Empty + FileStream
            });
            }
        }
    }
}
