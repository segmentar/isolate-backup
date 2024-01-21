using Core;

namespace Core
{
    using System;

    public partial class MaterialxportablewritestreamModule
    {
        public static MaterialxportablewritestreamModule Action(String Filename_VALUE, Materialxportable[] array_MATERIALXPORTABLE, Materialxportablesavecontext value_MATERIALXPORTABLESAVECONTEXT, Materialxportablelayout value_MATERIALXPORTABLELAYOUT, MaterialxportablewritebuildPort value_MATERIALXPORTABLEWRITEBUILDPORT)
        {
            MaterialxportablewritestreamModule moduleResult = default;

            moduleResult = Default(Filename_VALUE, array_MATERIALXPORTABLE, value_MATERIALXPORTABLESAVECONTEXT, value_MATERIALXPORTABLELAYOUT, value_MATERIALXPORTABLEWRITEBUILDPORT);

            if (MaterialxportablePolicy.MaterialxportablewritestreamPolicy is true)
            {
                try
                {
                    Materialxportablerender.GroupRender($"{MaterialxportableCode.ProductPath.Core_Materialxportable_Render}-{MaterialxportablePolicy.MaterialxportableIdentityOrdinalPolicy}x{MaterialxportablePolicy.MaterialxportableIdentityPolicy}-{nameof(MaterialxportablewritestreamModule)}-0", MaterialxportablewritestreamCycle.XZeroth);

                    Materialxportablerender.GroupRender($"{MaterialxportableCode.ProductPath.Core_Materialxportable_Render}-{MaterialxportablePolicy.MaterialxportableIdentityOrdinalPolicy}x{MaterialxportablePolicy.MaterialxportableIdentityPolicy}-{nameof(MaterialxportablewritestreamModule)}-1", MaterialxportablewritestreamCycle.XPrimary.XSingle);

                    Materialxportablerender.GroupRender($"{MaterialxportableCode.ProductPath.Core_Materialxportable_Render}-{MaterialxportablePolicy.MaterialxportableIdentityOrdinalPolicy}x{MaterialxportablePolicy.MaterialxportableIdentityPolicy}-{nameof(MaterialxportablewritestreamModule)}-2", MaterialxportablewritestreamCycle.XSecondary.XDouble);
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
