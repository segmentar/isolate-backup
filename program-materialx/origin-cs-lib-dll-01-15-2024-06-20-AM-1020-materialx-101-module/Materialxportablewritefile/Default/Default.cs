using Core;

namespace Core
{
    using System;

    public partial class MaterialxportablewritefileModule
    {
        public static MaterialxportablewritefileModule Default(String Filename_VALUE, Materialxportable[] array_MATERIALXPORTABLE, Materialxportablesavecontext value_MATERIALXPORTABLESAVECONTEXT, Materialxportablelayout value_MATERIALXPORTABLELAYOUT, MaterialxportablewritestreamPort value_MATERIALXPORTABLEPORTUV)
        {
            MaterialxportablewritefileModule moduleResult = default;

            MaterialxportablewritefileModule module;

            module = new MaterialxportablewritefileModule();

            var inflect = new Object[5];

            inflect[0] = Filename_VALUE;

            inflect[1] = array_MATERIALXPORTABLE;

            inflect[2] = value_MATERIALXPORTABLESAVECONTEXT;

            inflect[3] = value_MATERIALXPORTABLELAYOUT;

            inflect[4] = value_MATERIALXPORTABLEPORTUV;

            XZeroth xzeroth;

            xzeroth = new XZeroth(inflect);

            MaterialxportablewritefileCycle.XZeroth = xzeroth;

            module = module.XOne(module);

            module = module.XTwo(module);

            var array = MaterialxportablewritefileCycle.XSecondary.XDouble.MemoryStream.ToArray();

            MaterialxportablewritefileCycle.XPrimary.XSingle.FileStream.Write(array, 0, array.Length);

            MaterialxportablewritefilePort materialxportablewritefilePortxy;

            materialxportablewritefilePortxy = new MaterialxportablewritefilePort();

            materialxportablewritefilePortxy.FileStream = MaterialxportablewritefileCycle.XPrimary.XSingle.FileStream;

            materialxportablewritefilePortxy.MemoryStream = MaterialxportablewritefileCycle.XSecondary.XDouble.MemoryStream;

            module.MaterialxportablewritefilePortxy = materialxportablewritefilePortxy;

            moduleResult = module;

            return moduleResult;
        }
    }
}
