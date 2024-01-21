using Core;

namespace Core
{
    using System;

    public partial class MaterialxportablewritestreamModule
    {
        public static MaterialxportablewritestreamModule Default(String Filename_VALUE, Materialxportable[] array_MATERIALXPORTABLE, Materialxportablesavecontext value_MATERIALXPORTABLESAVECONTEXT, Materialxportablelayout value_MATERIALXPORTABLELAYOUT, MaterialxportablewritebuildPort value_MATERIALXPORTABLEWRITEBUILDPORT)
        {
            MaterialxportablewritestreamModule moduleResult = default;

            MaterialxportablewritestreamModule module;

            module = new MaterialxportablewritestreamModule();

            var inflect = new Object[6];

            inflect[1] = Filename_VALUE;

            inflect[2] = array_MATERIALXPORTABLE;

            inflect[3] = value_MATERIALXPORTABLESAVECONTEXT;

            inflect[4] = value_MATERIALXPORTABLELAYOUT;

            inflect[5] = value_MATERIALXPORTABLEWRITEBUILDPORT;

            XZeroth xzeroth;

            xzeroth = new XZeroth(inflect);

            MaterialxportablewritestreamCycle.XZeroth = xzeroth;

            module = module.XOne(module);

            module = module.XTwo(module);

            module = module.XThree(module);

            MaterialxportablewritestreamPort materialxportablewritestreamPortxy;

            materialxportablewritestreamPortxy = new MaterialxportablewritestreamPort();

            materialxportablewritestreamPortxy.HeaderTableMemoryStream = MaterialxportablewritestreamCycle.XPrimary.XSingle.MemoryStream;

            materialxportablewritestreamPortxy.SubjectTableMemoryStream = MaterialxportablewritestreamCycle.XSecondary.XDouble.MemoryStream;

            materialxportablewritestreamPortxy.ObjectTableMemoryStream = MaterialxportablewritestreamCycle.XTertiary.XTriple.MemoryStream;

            materialxportablewritestreamPortxy.HeaderTableByteArray = MaterialxportablewritestreamCycle.XPrimary.XSingle.ByteArray;

            materialxportablewritestreamPortxy.SubjectTableByteArray = MaterialxportablewritestreamCycle.XSecondary.XDouble.ByteArray;

            materialxportablewritestreamPortxy.ObjectTableByteArray = MaterialxportablewritestreamCycle.XTertiary.XTriple.ByteArray;

            module.MaterialxportablewritestreamPortxy = materialxportablewritestreamPortxy;

            moduleResult = module;

            return moduleResult;
        }
    }
}
