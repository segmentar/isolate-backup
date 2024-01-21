using Core;

namespace Core
{
    using System;

    public partial class MaterialxportablereadstreamModule
    {
        public static MaterialxportablereadstreamModule Default(String Filename_VALUE, MaterialxportablereadfilePort value_MATERIALXPORTABLEREADFILEPORT)
        {
            MaterialxportablereadstreamModule moduleResult = default;

            MaterialxportablereadstreamModule module;

            module = new MaterialxportablereadstreamModule();

            var inflect = new Object[2];

            inflect[0] = Filename_VALUE;

            inflect[1] = value_MATERIALXPORTABLEREADFILEPORT;

            XZeroth xzeroth;

            xzeroth = new XZeroth(inflect);

            MaterialxportablereadstreamCycle.XZeroth = xzeroth;

            module = module.XOne(module);

            MaterialxportablereadstreamPort materialxportablereadstreamPort;

            materialxportablereadstreamPort = new MaterialxportablereadstreamPort();

            materialxportablereadstreamPort.Materialxportablelayout = MaterialxportablereadstreamCycle.XPrimary.XSingle.Materialxportablelayout;

            module.MaterialxportablereadstreamPort = materialxportablereadstreamPort;

            moduleResult = module;

            return moduleResult;
        }
    }
}
