using Core;

namespace Core
{
    using System;

    public partial class Materialxportablereload
    {
        public static Materialxportable GroupReload(Materialxportable value_MATERIALXPORTABLE, Materialxportablesavecontext value_MATERIALXPORTABLESAVECONTEXT, Materialxportablewriteclose value_MATERIALXPORTABLEWRITECLOSE, Materialxportableloadcontext value_MATERIALXPORTABLELOADCONTEXT, Materialxportablereadclose value_MATERIALXPORTABLEREADCLOSE, String Filename_VALUE)
        {
            Materialxportable materialxportableResult = default;

            var array = Materialxportablesave.GroupSave(value_MATERIALXPORTABLE, value_MATERIALXPORTABLESAVECONTEXT, value_MATERIALXPORTABLEWRITECLOSE, Filename_VALUE);

            var value = Materialxportableload.GroupLoad(value_MATERIALXPORTABLELOADCONTEXT, value_MATERIALXPORTABLEREADCLOSE, Filename_VALUE);

            var reflect = (MaterialxportablereadbuildModule)(value[2] as Object);

            var result = reflect.MaterialxportablereadbuildPort.Materialxportable;

            materialxportableResult = result;

            return materialxportableResult;
        }
    }
}
