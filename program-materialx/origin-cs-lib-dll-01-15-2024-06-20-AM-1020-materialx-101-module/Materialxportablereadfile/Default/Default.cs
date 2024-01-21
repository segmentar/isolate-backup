using Core;

namespace Core
{
    using System;

    public partial class MaterialxportablereadfileModule
    {
        public static MaterialxportablereadfileModule Default(String Filename_VALUE)
        {
            MaterialxportablereadfileModule moduleResult = default;

            MaterialxportablereadfileModule module;

            module = new MaterialxportablereadfileModule();

            var inflect = new Object[1];

            inflect[0] = Filename_VALUE;

            XZeroth xzeroth;

            xzeroth = new XZeroth(inflect);

            MaterialxportablereadfileCycle.XZeroth = xzeroth;

            module = module.XOne(module);

            MaterialxportablereadfilePort materialxportablereadfilePort;

            materialxportablereadfilePort = new MaterialxportablereadfilePort();

            materialxportablereadfilePort.FileStream = MaterialxportablereadfileCycle.XPrimary.XSingle.FileStream;

            materialxportablereadfilePort.MemoryStream = MaterialxportablereadfileCycle.XPrimary.XSingle.MemoryStream;

            materialxportablereadfilePort.ByteArray = MaterialxportablereadfileCycle.XPrimary.XSingle.ByteArray;

            module.MaterialxportablereadfilePort = materialxportablereadfilePort;

            moduleResult = module;

            return moduleResult;
        }
    }
}
