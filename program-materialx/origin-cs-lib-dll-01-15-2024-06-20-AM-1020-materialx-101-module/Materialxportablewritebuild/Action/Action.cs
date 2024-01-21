using Core;

namespace Core
{
    using System;

    public partial class MaterialxportablewritebuildModule
    {
        public static MaterialxportablewritebuildModule Action(String Filename_VALUE, Materialxportable[] array_MATERIALXPORTABLE, Materialxportablesavecontext value_MATERIALXPORTABLESAVECONTEXT, Materialxportablelayout value_MATERIALXPORTABLELAYOUT)
        {
            MaterialxportablewritebuildModule moduleResult = default;

            moduleResult = Default(Filename_VALUE, array_MATERIALXPORTABLE, value_MATERIALXPORTABLESAVECONTEXT, value_MATERIALXPORTABLELAYOUT);

            if (MaterialxportablePolicy.MaterialxportablewritebuildPolicy is true)
            {
                try
                {
                    Materialxportablerender.GroupRender($"{MaterialxportableCode.ProductPath.Core_Materialxportable_Render}-{MaterialxportablePolicy.MaterialxportableIdentityOrdinalPolicy}x{MaterialxportablePolicy.MaterialxportableIdentityPolicy}-{nameof(MaterialxportablewritebuildModule)}-0", MaterialxportablewritebuildCycle.XZeroth);

                    Materialxportablerender.GroupRender($"{MaterialxportableCode.ProductPath.Core_Materialxportable_Render}-{MaterialxportablePolicy.MaterialxportableIdentityOrdinalPolicy}x{MaterialxportablePolicy.MaterialxportableIdentityPolicy}-{nameof(MaterialxportablewritebuildModule)}-1", MaterialxportablewritebuildCycle.XPrimary.XSingle);

                    Materialxportablerender.GroupRender($"{MaterialxportableCode.ProductPath.Core_Materialxportable_Render}-{MaterialxportablePolicy.MaterialxportableIdentityOrdinalPolicy}x{MaterialxportablePolicy.MaterialxportableIdentityPolicy}-{nameof(MaterialxportablewritebuildModule)}-2", MaterialxportablewritebuildCycle.XSecondary.XDouble);

                    Materialxportablerender.GroupRender($"{MaterialxportableCode.ProductPath.Core_Materialxportable_Render}-{MaterialxportablePolicy.MaterialxportableIdentityOrdinalPolicy}x{MaterialxportablePolicy.MaterialxportableIdentityPolicy}-{nameof(MaterialxportablewritebuildModule)}-3", MaterialxportablewritebuildCycle.XTertiary.XTriple);

                    Materialxportablerender.GroupRender($"{MaterialxportableCode.ProductPath.Core_Materialxportable_Render}-{MaterialxportablePolicy.MaterialxportableIdentityOrdinalPolicy}x{MaterialxportablePolicy.MaterialxportableIdentityPolicy}-{nameof(MaterialxportablewritebuildModule)}-4", MaterialxportablewritebuildCycle.XQuatenary.XQuadruple);

                    Materialxportablerender.GroupRender($"{MaterialxportableCode.ProductPath.Core_Materialxportable_Render}-{MaterialxportablePolicy.MaterialxportableIdentityOrdinalPolicy}x{MaterialxportablePolicy.MaterialxportableIdentityPolicy}-{nameof(MaterialxportablewritebuildModule)}-5", MaterialxportablewritebuildCycle.XQuinary.XQuintuple);

                    Materialxportablerender.GroupRender($"{MaterialxportableCode.ProductPath.Core_Materialxportable_Render}-{MaterialxportablePolicy.MaterialxportableIdentityOrdinalPolicy}x{MaterialxportablePolicy.MaterialxportableIdentityPolicy}-{nameof(MaterialxportablewritebuildModule)}-6", MaterialxportablewritebuildCycle.XSenary.XSextuple);
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
