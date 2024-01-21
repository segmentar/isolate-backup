using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class MaterialxportablereadbuildModule
    {
        [Materialxportableisc]
        public partial class XDouble
        {
            public BinaryReader BinaryReader;

            public MaterialxportablereadXl_velY[] LevelArray;

            public XDouble(BinaryReader binaryReader, MaterialxportablereadXl_velY[] levelArray)
            {
                this.BinaryReader = binaryReader;

                this.LevelArray = levelArray;

                return;
            }

            ~XDouble()
            {
                return;
            }

            [Materialxportableism]
            public override String ToString()
            {
                return String.Join('\n'.ToString(), new String[] { 
                
                    String.Empty + nameof(XDouble) + ' ' + "::" + ' ' + '{',
                    String.Empty + '.' + "function",
                    String.Empty + '\t' + '~' + "01" + ' ' + nameof(BinaryReader) + ':' + ' ' + ". . .",
                    String.Empty + '\t' + '~' + "02" + ' ' + nameof(LevelArray) + ':' + ' ' + ". . ." + ' ' + $"<{LevelArray.Length}>",
                    String.Empty + '}',
                    String.Empty,
                    String.Empty + '~' + "10" + ' ' + nameof(BinaryReader) + ':',
                    String.Empty + BinaryReader,
                    String.Empty,
                    String.Empty + '~' + "20" + ' ' + nameof(LevelArray) + ':',
                    String.Empty + String.Join('\n'.ToString(), LevelArray)
                });
            }
        }
    }
}
