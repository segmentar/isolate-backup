using Core;

namespace Core
{
    using System;

    public partial class MaterialxportablewritebuildModule
    {
        [Materialxportableisc]
        public partial class XQuintuple
        {
            public MaterialxportablewriteXleve_Y[] LevelArray;

            public XQuintuple(MaterialxportablewriteXleve_Y[] levelArray)
            {
                this.LevelArray = levelArray;

                return;
            }

            ~XQuintuple()
            {
                return;
            }

            [Materialxportableism]
            public override String ToString()
            {
                return String.Join('\n'.ToString(), new String[] { 
                
                    String.Empty + nameof(XQuintuple) + ' ' + "::" + ' ' + '{',
                    String.Empty + '.' + "function",
                    String.Empty + '\t' + '~' + "01" + ' ' + nameof(LevelArray) + ':' + ' ' + ". . ." + ' ' + $"<{LevelArray.Length}>",
                    String.Empty + '}',
                    String.Empty,
                    String.Empty + '~' + "10" + ' ' + nameof(LevelArray) + ':',
                    String.Empty + String.Join('\n'.ToString(), LevelArray)
                });
            }
        }
    }
}
