using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class MaterialxportablewritefileModule
    {
        [Materialxportableisc]
        public partial class XDouble
        {
            public MemoryStream MemoryStream;

            public XDouble(MemoryStream memoryStream)
            {
                this.MemoryStream = memoryStream;
            }

            [Materialxportableism]
            public override String ToString()
            {
                return String.Join('\n'.ToString(), new String[] { 
                
                    String.Empty + nameof(XDouble) + ' ' + "::" + ' ' + '{',
                    String.Empty + '.' + "function",
                    String.Empty + '\t' + '~' + "01" + ' ' + nameof(MemoryStream) + ':' + ' ' + ". . .",
                    String.Empty + '}',
                    String.Empty,
                    String.Empty + '~' + "10" + ' ' + nameof(MemoryStream) + ':',
                    String.Empty + MemoryStream
                });
            }
        }
    }
}
