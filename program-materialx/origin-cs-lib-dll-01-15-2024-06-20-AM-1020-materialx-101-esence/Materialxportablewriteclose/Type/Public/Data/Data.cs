using Core;

namespace Core
{
    using System;

    public partial struct Materialxportablewriteclose
    {
        public static Materialxportablewriteclose Data()
        {
            Materialxportablewriteclose materialxportablewritecloseResult = default;

            Materialxportablewriteclose materialxportablewriteclose;

            materialxportablewriteclose = new Materialxportablewriteclose();

            materialxportablewriteclose.FlushShould = true;

            materialxportablewriteclose.FileStreamCloseShould = true;

            materialxportablewriteclose.MemoryStreamCloseShould = true;

            materialxportablewriteclose.HeaderTableMemoryStreamCloseShould = true;

            materialxportablewriteclose.SubjectTableMemoryStreamCloseShould = true;

            materialxportablewriteclose.ObjectTableMemoryStreamCloseShould = true;

            materialxportablewritecloseResult = materialxportablewriteclose;

            return materialxportablewritecloseResult;
        }
    }
}
