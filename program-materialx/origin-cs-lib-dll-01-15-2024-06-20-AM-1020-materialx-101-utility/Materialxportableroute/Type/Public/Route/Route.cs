using Core;

namespace Core
{
    using System;

    public partial class Materialxportableroute
    {
        public static Int32 Route(String value_STRING)
        {
            Int32 integerResult = default;

            Int32 integer;

            switch (value_STRING)
            {
                case Materialxportablename.EntityKAI:
                    integer = 0;
                    break;

                case Materialxportablename.EntitySAJ:
                    integer = 1;
                    break;

                case Materialxportablename.EntityTAK:
                    integer = 2;
                    break;

                case Materialxportablename.EntityNAL:
                    integer = 3;
                    break;

                case Materialxportablename.EntityHAM:
                    integer = 5;
                    break;

                case Materialxportablename.EntityMAN:
                    integer = 6;
                    break;

                default:
                    integer = default;
                    break;
            }

            integerResult = integer;

            return integerResult;
        }
    }
}
