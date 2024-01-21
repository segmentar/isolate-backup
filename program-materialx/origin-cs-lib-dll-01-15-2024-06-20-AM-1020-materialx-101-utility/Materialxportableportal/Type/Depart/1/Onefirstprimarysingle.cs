using Core;

namespace Core
{
    using System;
    
    public partial class Materialxportableportal
    {
        public static void Onefirstprimarysingle()
        {
            if (Object.Equals(EscapeCharacter, InputCharacter) is true)
            {
                IsBlackhole = IsBlackhole.Equals(false);
            }
            else
                "false".ToString();

            if (IsBlackhole)
            {
                BlackholeCharacterArray[Error] = InputCharacter;
            }
            else
            {
                BlackholeCharacterArray[Error] = (Char)Materialxportableascii.EntityWhitespace;
            }

            return;
        }
    }
}
