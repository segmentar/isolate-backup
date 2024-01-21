using Core;

namespace Core
{
    using System;

    public partial class MaterialxportablereadstreamModule
    {
        public static MaterialxportablereadstreamModule Action(String Filename_VALUE, MaterialxportablereadfilePort value_MATERIALXPORTABLEREADFILEPORT)
        {
            MaterialxportablereadstreamModule moduleResult = default;

            moduleResult = Default(Filename_VALUE, value_MATERIALXPORTABLEREADFILEPORT);

            if (MaterialxportablePolicy.MaterialxportablereadstreamPolicy is true)
            {
                try
                {
                    Materialxportablerender.GroupRender($"{MaterialxportableCode.ProductPath.Core_Materialxportable_Render}-{MaterialxportablePolicy.MaterialxportableIdentityOrdinalPolicy}x{MaterialxportablePolicy.MaterialxportableIdentityPolicy}-{nameof(MaterialxportablereadstreamModule)}-0", MaterialxportablereadstreamCycle.XZeroth);

                    Materialxportablerender.GroupRender($"{MaterialxportableCode.ProductPath.Core_Materialxportable_Render}-{MaterialxportablePolicy.MaterialxportableIdentityOrdinalPolicy}x{MaterialxportablePolicy.MaterialxportableIdentityPolicy}-{nameof(MaterialxportablereadstreamModule)}-1", MaterialxportablereadstreamCycle.XPrimary.XSingle);
                }
                catch (Exception exception)
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
