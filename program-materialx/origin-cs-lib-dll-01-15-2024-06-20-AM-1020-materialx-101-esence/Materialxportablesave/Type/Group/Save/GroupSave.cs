using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Materialxportablesave
    {
        public static Object[] GroupSave(Materialxportable value_MATERIALXPORTABLE, Materialxportablesavecontext value_MATERIALXPORTABLESAVECONTEXT, Materialxportablewriteclose value_MATERIALXPORTABLEWRITECLOSE, String Filename_VALUE)
        {
            Object[] arrayResult = default;

            var array = Materialxportableall.MaterialxportableallAllSetSurface(value_MATERIALXPORTABLE, true);

            if (value_MATERIALXPORTABLESAVECONTEXT.ShouldRemote is true)
            {
                Materialxportableremotein.RemoteType(array);

                Materialxportableremotein.Remote(array);
            }
            else
                "false".ToString();

            if (value_MATERIALXPORTABLESAVECONTEXT.ShouldDebug is true)
            {
                MaterialxportablePolicy.MaterialxportableIdentityPolicy = Path.GetRandomFileName();

                MaterialxportablePolicy.MaterialxportableIdentityOrdinalPolicy = MaterialxportablePolicy.MaterialxportableIdentityOrdinalPolicy + 1;
            }
            else
                "false".ToString();

            Int32 x, y, z;

            x = 0;

            x = x + array.Length;

            y = 0;

            y = y + Materialxportableconfigure.StartAddress;

            z = 0;

            z = z + array.Length;

            z = z * Materialxportableconfigure.ChunkSize;

            z = z + Materialxportableconfigure.StartAddress;

            Materialxportablelayout materialxportablelayout;

            materialxportablelayout = new Materialxportablelayout();

            materialxportablelayout.MaterialCount = x;

            materialxportablelayout.StartAddressSubjectTable = y;

            materialxportablelayout.StartAddressObjectTable = z;

            MaterialxportablewritebuildModule materialxportablewritebuildModule = MaterialxportablewritebuildModule.Action(Filename_VALUE, array, value_MATERIALXPORTABLESAVECONTEXT, materialxportablelayout);

            MaterialxportablewritestreamModule materialxportablewritestreamModule = MaterialxportablewritestreamModule.Action(Filename_VALUE, array, value_MATERIALXPORTABLESAVECONTEXT, materialxportablelayout, materialxportablewritebuildModule.MaterialxportablewritebuildPort);

            MaterialxportablewritefileModule materialxportablewritefileModule = MaterialxportablewritefileModule.Action(Filename_VALUE, array, value_MATERIALXPORTABLESAVECONTEXT, materialxportablelayout, materialxportablewritestreamModule.MaterialxportablewritestreamPortxy);

            var inflect = new Object[3];

            inflect[0] = materialxportablewritebuildModule;

            inflect[1] = materialxportablewritestreamModule;

            inflect[2] = materialxportablewritefileModule;

            Materialxportablewriteclose.Close(value_MATERIALXPORTABLEWRITECLOSE, inflect);

            var result = inflect;

            arrayResult = result;

            return arrayResult;
        }
    }
}
