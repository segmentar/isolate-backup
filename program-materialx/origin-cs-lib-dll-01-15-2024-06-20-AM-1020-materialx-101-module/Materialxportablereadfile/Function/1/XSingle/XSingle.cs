using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class MaterialxportablereadfileModule
    {
        [Materialxportableisc]
        public partial class XSingle
        {
            public FileStream FileStream;

            public MemoryStream MemoryStream;

            public Byte[] ByteArray;

            public XSingle(FileStream fileStream, MemoryStream memoryStream, Byte[] byteArray)
            {
                this.FileStream = fileStream;

                this.MemoryStream = memoryStream;

                this.ByteArray = byteArray;

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
                    String.Empty + '\t' + '~' + "01" + ' ' + nameof(FileStream) + ':' + ' ' + ". . .",
                    String.Empty + '\t' + '~' + "02" + ' ' + nameof(MemoryStream) + ':' + ' ' + ". . .",
                    String.Empty + '\t' + '~' + "03" + ' ' + nameof(ByteArray) + ':' + ' ' + ". . ." + ' ' + $"<{ByteArray.Length}>",
                    String.Empty + '}',
                    String.Empty,
                    String.Empty + '~' + "10" + ' ' + nameof(FileStream) + ':',
                    String.Empty + FileStream,
                    String.Empty,
                    String.Empty + '~' + "20" + ' ' + nameof(MemoryStream) + ':',
                    String.Empty + MemoryStream,
                    String.Empty,
                    String.Empty + '~' + "30" + ' ' + nameof(ByteArray) + ':',
                    String.Empty + String.Join('\n'.ToString(), ByteArray)
                });
            }
        }
    }
}
