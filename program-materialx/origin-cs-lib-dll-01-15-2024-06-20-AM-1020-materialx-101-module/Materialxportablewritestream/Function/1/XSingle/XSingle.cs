using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class MaterialxportablewritestreamModule
    {
        [Materialxportableisc]
        public partial class XSingle
        {
            public MemoryStream MemoryStream;

            public BinaryWriter BinaryWriter;

            public Byte[] ByteArray;

            public XSingle(MemoryStream memoryStream, BinaryWriter binaryWriter, Byte[] byteArray)
            {
                this.MemoryStream = memoryStream;

                this.BinaryWriter = binaryWriter;

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
                    String.Empty + '\t' + '~' + "01" + ' ' + nameof(MemoryStream) + ':' + ' ' + ". . .",
                    String.Empty + '\t' + '~' + "02" + ' ' + nameof(BinaryWriter) + ':' + ' ' + ". . .",
                    String.Empty + '\t' + '~' + "03" + ' ' + nameof(ByteArray) + ':' + ' ' + ". . ." + ' ' + $"<{ByteArray.Length}>",
                    String.Empty + '}',
                    String.Empty,
                    String.Empty + '~' + "10" + ' ' + nameof(MemoryStream) + ':',
                    String.Empty + MemoryStream,
                    String.Empty,
                    String.Empty + '~' + "20" + ' ' + nameof(BinaryWriter) + ':',
                    String.Empty + BinaryWriter,
                    String.Empty,
                    String.Empty + '~' + "30" + ' ' + nameof(ByteArray) + ':',
                    String.Empty + String.Join('\n'.ToString(), ByteArray)
                });
            }
        }
    }
}
