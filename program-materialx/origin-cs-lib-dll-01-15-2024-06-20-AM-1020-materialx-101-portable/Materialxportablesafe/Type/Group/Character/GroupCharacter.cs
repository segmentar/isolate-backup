using Core;

namespace Core
{
    using System;

    public partial class Materialxportablesafe
    {
        public static Char GroupCharacter(Char value_CHARACTER)
        {
            Char characterResult = default;

            Char character;

            if (Char.IsControl(value_CHARACTER))
            {
                character = (Char)Materialxportableascii.EntityWhitespace;
            }
            else
            {
                character = value_CHARACTER;
            }

            characterResult = character;

            return characterResult;
        }
    }
}
