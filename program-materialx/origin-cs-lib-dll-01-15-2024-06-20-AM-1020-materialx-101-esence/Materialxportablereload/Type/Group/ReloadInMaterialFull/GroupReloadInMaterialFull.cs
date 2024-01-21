using Core;

namespace Core
{
    using System;

    public partial class Materialxportablereload
    {
        public static Materialxportable GroupReloadInMaterialFull(Materialxportable value_MATERIALXPORTABLE, String FileName__VALUE)
        {
            Materialxportable materialxportableResult = default;

            Materialxportablesave.SaveToMaterialFull(value_MATERIALXPORTABLE, FileName__VALUE);

            var result = Materialxportableload.GroupLoadFromMaterialFull(FileName__VALUE);

            materialxportableResult = result;

            return materialxportableResult;
        }
    }
}
