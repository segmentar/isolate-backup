using Core;

namespace Core
{
    using System;

    public partial class Materialxportableerror
    {
        [Materialxportableism]
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] { 
            
                String.Empty + nameof(Materialxportableerror) + ' ' + "::" + ' ' + '{',
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(InformationArray) + ':' + ' ' + ". . ." + ' ' + $"<{InformationArray.Length}>",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(ExceptionValue) + ':' + ' ' + ". . ." + ' ' + $"<{ExceptionValue == default}>",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(InformationArray) + ':',
                String.Empty + String.Join('\n'.ToString(), InformationArray)
            });
        }
    }
}
