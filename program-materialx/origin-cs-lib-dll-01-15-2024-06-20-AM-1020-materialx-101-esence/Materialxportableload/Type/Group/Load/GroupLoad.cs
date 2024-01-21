using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Materialxportableload
    {
        public static Object[] GroupLoad(Materialxportableloadcontext value_MATERIALXPORTABLELOADCONTEXT, Materialxportablereadclose value_MATERIALXPORTABLEREADCLOSE, String Filename_VALUE)
        {
            Object[] arrayResult = default;

            if (value_MATERIALXPORTABLELOADCONTEXT.ShouldDebug is true)
            {
                MaterialxportablePolicy.MaterialxportableIdentityPolicy = Path.GetRandomFileName();

                MaterialxportablePolicy.MaterialxportableIdentityOrdinalPolicy = MaterialxportablePolicy.MaterialxportableIdentityOrdinalPolicy + 1;
            }
            else
                "false".ToString();

            MaterialxportablereadfileModule materialxportablereadfileModule = MaterialxportablereadfileModule.Action(Filename_VALUE);

            MaterialxportablereadstreamModule materialxportablereadstreamModule = MaterialxportablereadstreamModule.Action(Filename_VALUE, materialxportablereadfileModule.MaterialxportablereadfilePort);

            MaterialxportablereadbuildModule materialxportablereadbuildModule = MaterialxportablereadbuildModule.Action(Filename_VALUE, materialxportablereadfileModule.MaterialxportablereadfilePort, materialxportablereadstreamModule.MaterialxportablereadstreamPort);

            var inflect = new Object[3];

            inflect[0] = materialxportablereadfileModule;

            inflect[1] = materialxportablereadstreamModule;

            inflect[2] = materialxportablereadbuildModule;

            Materialxportablereadclose.Close(value_MATERIALXPORTABLEREADCLOSE, inflect);

            var result = inflect;

            arrayResult = result;

            return arrayResult;
        }
    }
}
