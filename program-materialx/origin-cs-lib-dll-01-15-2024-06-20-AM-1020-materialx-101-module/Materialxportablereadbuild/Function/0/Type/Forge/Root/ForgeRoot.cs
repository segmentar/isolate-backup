using Core;

namespace Core
{
    using System;

    public partial class MaterialxportablereadbuildModule
    {
        public partial class XZeroth
        {
            public static Materialxportable ForgeRoot(MaterialxportablereadXlev_lY[] Level_ARRAY)
            {
                Materialxportable materialxportableResult = default;

                foreach (MaterialxportablereadXlev_lY Level_VALUE in Level_ARRAY)
                {
                    var reflect = (Materialxportablestringarraysafe)(Level_VALUE.Materialxportable.RouteIdentity as Object);

                    Boolean isEqualCheck, shouldContinueCheck;

                    isEqualCheck = Object.Equals(reflect.Value.Length, 1) is true;

                    shouldContinueCheck = isEqualCheck is false;

                    if (shouldContinueCheck is true)
                    {
                        continue;
                    }
                    else
                        "false".ToString();

                    var result = Level_VALUE.Materialxportable;

                    materialxportableResult = result;

                    break;
                }

                return materialxportableResult;
            }
        }
    }
}
