using Core;

namespace Core
{
    using System;

    public partial class MaterialxportablewritebuildModule
    {
        [Materialxportableisc]
        public partial class XSingle
        {
            public MaterialxportablewriteX_evelY[] LevelArray;

            public XSingle(MaterialxportablewriteX_evelY[] levelArray)
            {
                this.LevelArray = levelArray;

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
