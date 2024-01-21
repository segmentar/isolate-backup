using Core;

namespace Core
{
    using System;

    public partial class Materialxportable
    {
        static Materialxportable()
        {
            return;
        }

        public static void Procedure()
        {
            MaterialxportablePolicy.MaterialxportableDebugPolicy = true;

            MaterialxportablePolicy.MaterialxportableInfoPolicy = true;

            return;
        }

        public static void Manual()
        {
            Materialxportableconfigure.Import(Materialxportableconfigure.Data());

            return;
        }
       
        public static void Raise()
        {
            if (MaterialxportablePolicy.MaterialxportableInfoPolicy is true)
            {
                Materialxportablerender.GroupRender($"{MaterialxportableCode.RenderPath.Core_Materialxportable_Info}", String.Join('\n'.ToString(), Materialxportablemagic.MaterialxportablemagicArrayListCastDispenser(MaterialxportablePolicy.MaterialxportableArrayList)));
            }
            else
                "false".ToString();

            return;
        }

        public static void Bundle()
        {
            Procedure();

            Manual();

            Raise();

            return;
        }
    }
}
