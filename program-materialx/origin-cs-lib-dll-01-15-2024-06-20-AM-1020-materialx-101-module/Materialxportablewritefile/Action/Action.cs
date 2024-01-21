using Core;

namespace Core
{
    using System;

    public partial class MaterialxportablewritefileModule
    {
        public static MaterialxportablewritefileModule Action(String Filename_VALUE, Materialxportable[] array_MATERIALXPORTABLE, Materialxportablesavecontext value_MATERIALXPORTABLESAVECONTEXT, Materialxportablelayout value_MATERIALXPORTABLELAYOUT, MaterialxportablewritestreamPort value_MATERIALXPORTABLEPORTUV)
        {
            MaterialxportablewritefileModule moduleResult = default;

            moduleResult = Default(Filename_VALUE, array_MATERIALXPORTABLE, value_MATERIALXPORTABLESAVECONTEXT, value_MATERIALXPORTABLELAYOUT, value_MATERIALXPORTABLEPORTUV);

            if (MaterialxportablePolicy.MaterialxportablewritefilePolicy)
            {
                try
                {
                    Materialxportablerender.GroupRender($"{MaterialxportableCode.ProductPath.Core_Materialxportable_Render}-{MaterialxportablePolicy.MaterialxportableIdentityOrdinalPolicy}x{MaterialxportablePolicy.MaterialxportableIdentityPolicy}-{nameof(MaterialxportablewritefileModule)}-0", MaterialxportablewritefileCycle.XZeroth);

                    Materialxportablerender.GroupRender($"{MaterialxportableCode.ProductPath.Core_Materialxportable_Render}-{MaterialxportablePolicy.MaterialxportableIdentityOrdinalPolicy}x{MaterialxportablePolicy.MaterialxportableIdentityPolicy}-{nameof(MaterialxportablewritefileModule)}-1", MaterialxportablewritefileCycle.XPrimary);
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
