using Core;

namespace Core
{
    using System;

    public partial struct Materialxportablesavecontext
    {
        public static Materialxportablesavecontext Data()
        {
            Materialxportablesavecontext materialxportablesavecontextResult = default;

            Materialxportablesavecontext materialxportablesavecontext;

            materialxportablesavecontext = new Materialxportablesavecontext();

            materialxportablesavecontext.Should16Bit = false;

            materialxportablesavecontext.Should32Bit = true;

            materialxportablesavecontext.Should64Bit = false;

            materialxportablesavecontext.ShouldDebug = true;

            materialxportablesavecontext.ShouldRemote = true;

            materialxportablesavecontext.ShouldOverlap = false;

            materialxportablesavecontext.ShouldOverflow = false;

            materialxportablesavecontextResult = materialxportablesavecontext;

            return materialxportablesavecontextResult;
        }
    }
}
