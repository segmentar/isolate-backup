using Core;

namespace Core
{
    using System;

    public partial class MaterialxportablereadbuildModule
    {
        public static MaterialxportablereadbuildModule Action(String Filename_VALUE, MaterialxportablereadfilePort value_MATERIALXPORTABLEREADFILEPORT, MaterialxportablereadstreamPort value_MATERIALXPORTABLEREADSTREAMPORT)
        {
            MaterialxportablereadbuildModule moduleResult = default;

            moduleResult = Default(Filename_VALUE, value_MATERIALXPORTABLEREADFILEPORT, value_MATERIALXPORTABLEREADSTREAMPORT);

            if (MaterialxportablePolicy.MaterialxportablereadbuildPolicy is true)
            {
                try
                {
                    Materialxportablerender.GroupRender($"{MaterialxportableCode.ProductPath.Core_Materialxportable_Render}-{MaterialxportablePolicy.MaterialxportableIdentityOrdinalPolicy}x{MaterialxportablePolicy.MaterialxportableIdentityPolicy}-{nameof(MaterialxportablereadbuildModule)}-0", MaterialxportablereadbuildCycle.XZeroth);

                    Materialxportablerender.GroupRender($"{MaterialxportableCode.ProductPath.Core_Materialxportable_Render}-{MaterialxportablePolicy.MaterialxportableIdentityOrdinalPolicy}x{MaterialxportablePolicy.MaterialxportableIdentityPolicy}-{nameof(MaterialxportablereadbuildModule)}-1", MaterialxportablereadbuildCycle.XPrimary.XSingle);

                    Materialxportablerender.GroupRender($"{MaterialxportableCode.ProductPath.Core_Materialxportable_Render}-{MaterialxportablePolicy.MaterialxportableIdentityOrdinalPolicy}x{MaterialxportablePolicy.MaterialxportableIdentityPolicy}-{nameof(MaterialxportablereadbuildModule)}-2", MaterialxportablereadbuildCycle.XSecondary.XDouble);

                    Materialxportablerender.GroupRender($"{MaterialxportableCode.ProductPath.Core_Materialxportable_Render}-{MaterialxportablePolicy.MaterialxportableIdentityOrdinalPolicy}x{MaterialxportablePolicy.MaterialxportableIdentityPolicy}-{nameof(MaterialxportablereadbuildModule)}-3", MaterialxportablereadbuildCycle.XTertiary.XTriple);

                    Materialxportablerender.GroupRender($"{MaterialxportableCode.ProductPath.Core_Materialxportable_Render}-{MaterialxportablePolicy.MaterialxportableIdentityOrdinalPolicy}x{MaterialxportablePolicy.MaterialxportableIdentityPolicy}-{nameof(MaterialxportablereadbuildModule)}-4", MaterialxportablereadbuildCycle.XQuaternary.XQuadruple);

                } catch (Exception exception)
                {
                    Materialxportablerender.GroupRender($"{MaterialxportableCode.ProductPath.Core_Materialxportable_Fatal}", exception);
                }
            }
            else
                "false".ToString();

            return moduleResult;
        }
    }
}
