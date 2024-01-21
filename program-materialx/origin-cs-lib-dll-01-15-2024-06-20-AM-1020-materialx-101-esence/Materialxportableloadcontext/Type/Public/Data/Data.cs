using Core;

namespace Core
{
    using System;

    public partial struct Materialxportableloadcontext
    {
        public static Materialxportableloadcontext Data()
        {
            Materialxportableloadcontext materialxportableloadcontextResult = default;

            Materialxportableloadcontext materialxportableloadcontext;

            materialxportableloadcontext = new Materialxportableloadcontext();

            materialxportableloadcontext.Should16Bit = false;

            materialxportableloadcontext.Should32Bit = true;

            materialxportableloadcontext.Should64Bit = false;

            materialxportableloadcontext.ShouldDebug = true;

            materialxportableloadcontextResult = materialxportableloadcontext;

            return materialxportableloadcontextResult;
        }
    }
}
