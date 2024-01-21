using Core;

namespace Core
{
    using System;

    public partial class MaterialxportablereadbuildModule
    {
        public static MaterialxportablereadbuildModule Default(String Filename_VALUE, MaterialxportablereadfilePort value_MATERIALXPORTABLEREADFILEPORT, MaterialxportablereadstreamPort value_MATERIALXPORTABLEREADSTREAMPORT)
        {
            MaterialxportablereadbuildModule moduleResult = default;

            MaterialxportablereadbuildModule module;

            module = new MaterialxportablereadbuildModule();

            var inflect = new Object[3];

            inflect[0] = Filename_VALUE;

            inflect[1] = value_MATERIALXPORTABLEREADFILEPORT;

            inflect[2] = value_MATERIALXPORTABLEREADSTREAMPORT;

            XZeroth xzeroth;

            xzeroth = new XZeroth(inflect);

            MaterialxportablereadbuildCycle.XZeroth = xzeroth;

            module = module.XOne(module);

            module = module.XTwo(module);

            module = module.XThree(module);

            module = module.XFour(module);

            MaterialxportablereadbuildPort materialxportablereadbuildPort;

            materialxportablereadbuildPort = new MaterialxportablereadbuildPort();

            materialxportablereadbuildPort.Level = MaterialxportablereadbuildCycle.XPrimary.XSingle.LevelArray;

            materialxportablereadbuildPort.LevelLevel = MaterialxportablereadbuildCycle.XSecondary.XDouble.LevelArray;

            materialxportablereadbuildPort.LevelLevelLevel = MaterialxportablereadbuildCycle.XTertiary.XTriple.LevelArray;

            materialxportablereadbuildPort.LevelLevelLevelLevel = MaterialxportablereadbuildCycle.XQuaternary.XQuadruple.LevelArray;

            materialxportablereadbuildPort.MaterialxportableArray = XZeroth.FunctionMaterialSetSurface(MaterialxportablereadbuildCycle.XQuaternary.XQuadruple.LevelArray);

            materialxportablereadbuildPort.Materialxportable = XZeroth.ForgeRoot(MaterialxportablereadbuildCycle.XQuaternary.XQuadruple.LevelArray);

            module.MaterialxportablereadbuildPort = materialxportablereadbuildPort;

            XZeroth.Build(MaterialxportablereadbuildCycle.XQuaternary.XQuadruple.LevelArray);

            moduleResult = module;

            return moduleResult;
        }
    }
}
