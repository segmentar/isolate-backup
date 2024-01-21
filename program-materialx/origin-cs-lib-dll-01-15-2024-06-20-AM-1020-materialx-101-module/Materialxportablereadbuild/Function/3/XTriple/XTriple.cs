using Core;

namespace Core
{
    using System;

    public partial class MaterialxportablereadbuildModule
    {
        [Materialxportableisc]
        public partial class XTriple
        {
            public MaterialxportablereadXle_elY[] LevelArray;

            public XTriple(MaterialxportablereadXle_elY[] levelArray)
            {
                this.LevelArray = levelArray;

                return;
            }

            ~XTriple()
            {
                return;
            }

            [Materialxportableism]
            public override String ToString()
            {
                return String.Join('\n'.ToString(), new String[] {
                
                    String.Empty + nameof(XTriple) + ' ' + "::" + ' ' + '{',
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
