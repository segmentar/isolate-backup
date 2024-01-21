using Core;

namespace Core
{
    using System;

    public partial class MaterialxportablewritebuildModule
    {
        public static MaterialxportablewritebuildModule Default(String Filename_VALUE, Materialxportable[] array_MATERIALXPORTABLE, Materialxportablesavecontext value_MATERIALXPORTABLESAVECONTEXT, Materialxportablelayout value_MATERIALXPORTABLELAYOUT)
        {
            MaterialxportablewritebuildModule moduleResult = default;

            MaterialxportablewritebuildModule module;

            module = new MaterialxportablewritebuildModule();

            var inflect = new Object[4];

            inflect[0] = Filename_VALUE;

            inflect[1] = array_MATERIALXPORTABLE;

            inflect[2] = value_MATERIALXPORTABLESAVECONTEXT;

            inflect[3] = value_MATERIALXPORTABLELAYOUT;

            XZeroth zeroth;

            zeroth = new XZeroth(inflect);

            MaterialxportablewritebuildCycle.XZeroth = zeroth;

            module = module.XOne(module);

            module = module.XTwo(module);

            module = module.XThree(module);

            module = module.XFour(module);

            module = module.XFive(module);

            module = module.XSix(module);

            MaterialxportablewritebuildPort materialxportablewritebuildPort;

            materialxportablewritebuildPort = new MaterialxportablewritebuildPort();

            materialxportablewritebuildPort.Level = MaterialxportablewritebuildCycle.XPrimary.XSingle.LevelArray;

            materialxportablewritebuildPort.LevelLevel = MaterialxportablewritebuildCycle.XSecondary.XDouble.LevelArray;

            materialxportablewritebuildPort.LevelLevelLevel = MaterialxportablewritebuildCycle.XTertiary.XTriple.LevelArray;

            materialxportablewritebuildPort.LevelLevelLevelLevel = MaterialxportablewritebuildCycle.XQuatenary.XQuadruple.LevelArray;

            materialxportablewritebuildPort.LevelLevelLevelLevelLevel = MaterialxportablewritebuildCycle.XQuinary.XQuintuple.LevelArray;

            materialxportablewritebuildPort.LevelLevelLevelLevelLevelLevel = MaterialxportablewritebuildCycle.XSenary.XSextuple.LevelArray;
           
            module.MaterialxportablewritebuildPort = materialxportablewritebuildPort;

            moduleResult = module;

            return moduleResult;
        }
    }
}
