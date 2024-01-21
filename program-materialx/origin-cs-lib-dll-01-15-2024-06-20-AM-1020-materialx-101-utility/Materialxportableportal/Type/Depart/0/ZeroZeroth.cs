using Core;

namespace Core
{
    using System;

    public partial class Materialxportableportal
    {
        public static void ZeroZeroth(Materialxportable value_MATERIALXPORTABLE, Materialxportable[] array_MATERIALXPORTABLE, String ResultRoute__VALUE, Char[] array_CHARACTER, String value_STRING)
        {
            Materialxportable = value_MATERIALXPORTABLE;

            EscapeCharacterArray = array_CHARACTER;

            InputCharacterArray = value_STRING.ToCharArray();

            Indexer = 0;

            do
            {
                Boolean isEqualCheck, shouldBreakCheck;

                isEqualCheck = Object.Equals(EscapeCharacterArray.Length, Indexer) is true;

                shouldBreakCheck = isEqualCheck is true;

                if (shouldBreakCheck is true)
                {
                    break;
                }
                else
                    "false".ToString();

                BlackholeCharacterArray = new Char[value_STRING.Length];

                WhiteholeCharacterArray = new Char[value_STRING.Length];

                AdditiveholeCharacterArray = new Char[value_STRING.Length];

                NegateholeCharacterArray = new Char[value_STRING.Length];

                ResultCharacterArray = new Char[value_STRING.Length];

                IsBlackhole = false;

                IsWhitehole = false;

                IsAdditivehole = false;

                IsNegatehole = false;

                IsResult = false;

                EscapeCharacter = EscapeCharacterArray[Indexer];

                Error = -1;

                foreach (Char character in InputCharacterArray)
                {
                    Error = Error + 1;

                    InputCharacter = character;

                    Onefirstprimarysingle();

                    Twosecondsecondarydouble();

                    Threethirdtertiarytriple();

                    Fourfourthquatenaryquadruple();

                    Fivefifthquinaryquintuple();

                    continue;
                }

                var join = String.Join(String.Empty, ResultCharacterArray);

                var separator = new Char[] { EscapeCharacter };

                SplitArray = join.Split(separator, StringSplitOptions.RemoveEmptyEntries);

                foreach (Materialxportable result_MATERIALXPORTABLE in array_MATERIALXPORTABLE)
                {
                    if (Object.Equals(result_MATERIALXPORTABLE.ObjectIdentity, EscapeCharacter) is true)
                    {
                        var result = Materialxportableadd.Add(result_MATERIALXPORTABLE, ResultRoute__VALUE);

                        result.ObjectIdentity = SplitArray;
                    }
                    else
                        "false".ToString();
                    
                    continue;
                }

                Indexer = Indexer + 1;

                continue;

            } while (true);

            return;
        }
    }
}
