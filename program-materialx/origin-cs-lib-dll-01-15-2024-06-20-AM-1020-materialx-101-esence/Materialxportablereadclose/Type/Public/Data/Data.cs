using Core;

namespace Core
{
    using System;

    public partial struct Materialxportablereadclose
    {
        public static Materialxportablereadclose Data()
        {
            Materialxportablereadclose materialxportablereadcloseResult = default;

            Materialxportablereadclose materialxportablereadclose;

            materialxportablereadclose = new Materialxportablereadclose();

            materialxportablereadclose.FileStreamCloseShould = true;

            materialxportablereadclose.MemoryStreamCloseShould = true;

            materialxportablereadcloseResult = materialxportablereadclose;

            return materialxportablereadcloseResult;
        }
    }
}
