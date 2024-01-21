using Core;

namespace Core
{
    using System;

    public partial struct Materialxportablelayout
    {
        [Materialxportableism]
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] { 
            
                String.Empty + nameof(Materialxportablelayout) + ' ' + "::" + ' ' + '{',
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(MaterialCount) + ':' + ' ' + MaterialCount,
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(StartAddressSubjectTable) + ':' + ' ' + StartAddressSubjectTable,
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(StartAddressObjectTable) + ':' + ' ' + StartAddressObjectTable,
                String.Empty + '}'
            });
        }
    }
}
