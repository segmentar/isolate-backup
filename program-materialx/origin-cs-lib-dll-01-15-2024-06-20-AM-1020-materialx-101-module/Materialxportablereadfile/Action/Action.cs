using Core;

namespace Core
{
    using System;

    public partial class MaterialxportablereadfileModule
    {
        public static MaterialxportablereadfileModule Action(String Filename_VALUE)
        {
            MaterialxportablereadfileModule moduleResult = default;

            moduleResult = Default(Filename_VALUE);

            if (MaterialxportablePolicy.MaterialxportablereadfilePolicy is true)
            {
                try
                {
                    Materialxportablerender.GroupRender($"{MaterialxportableCode.ProductPath.Core_Materialxportable_Render}-{MaterialxportablePolicy.MaterialxportableIdentityOrdinalPolicy}x{MaterialxportablePolicy.MaterialxportableIdentityPolicy}-{nameof(MaterialxportablereadfileModule)}-0", MaterialxportablereadfileCycle.XZeroth);

                    Materialxportablerender.GroupRender($"{MaterialxportableCode.ProductPath.Core_Materialxportable_Render}-{MaterialxportablePolicy.MaterialxportableIdentityOrdinalPolicy}x{MaterialxportablePolicy.MaterialxportableIdentityPolicy}-{nameof(MaterialxportablereadfileModule)}-1", MaterialxportablereadfileCycle.XPrimary.XSingle);
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
