using Core;

namespace Core
{
    using System;

    using System.Linq;

    public partial class MaterialxportablereadbuildModule
    {
        public partial class XZeroth
        {
            public static void Build(MaterialxportablereadXlev_lY[] Level_ARRAY)
            {
                foreach (MaterialxportablereadXlev_lY Item_VALUE in Level_ARRAY)
                {
                    var reflect_ITEM = (Materialxportablestringarraysafe)(Item_VALUE.Materialxportable.RouteIdentity as Object);

                    foreach (MaterialxportablereadXlev_lY Entry_VALUE in Level_ARRAY)
                    {
                        var reflect_ENTRY = (Materialxportablestringarraysafe)(Entry_VALUE.Materialxportable.RouteIdentity as Object);

                        var aoth = reflect_ENTRY.Value.Length;

                        var roth = (aoth - 1);

                        var array = new String[roth];

                        Array.Copy(reflect_ENTRY.Value, 0, array, 0, roth);

                        var value = reflect_ENTRY.Value[roth];

                        Boolean isEqualCheck, shouldContinueCheck;

                        isEqualCheck = reflect_ITEM.Value.SequenceEqual<String>(array) is true;

                        shouldContinueCheck = isEqualCheck is false;

                        if (shouldContinueCheck is true)
                        {
                            continue;
                        }
                        else
                            "false".ToString();

                        var reflect = (Materialxportable[])(Item_VALUE.Materialxportable.SegmentArrayObject as Object);

                        switch (value)
                        {
                            case Materialxportablename.EntityKAI:
                                reflect[0] = Entry_VALUE.Materialxportable;
                                break;

                            case Materialxportablename.EntitySAJ:
                                reflect[1] = Entry_VALUE.Materialxportable;
                                break;

                            case Materialxportablename.EntityTAK:
                                reflect[2] = Entry_VALUE.Materialxportable;
                                break;

                            case Materialxportablename.EntityNAL:
                                reflect[3] = Entry_VALUE.Materialxportable;
                                break;

                            case Materialxportablename.EntityHAM:
                                reflect[4] = Entry_VALUE.Materialxportable;
                                break;

                            case Materialxportablename.EntityMAN:
                                reflect[5] = Entry_VALUE.Materialxportable;
                                break;

                            default:
                                break;
                        }

                        continue;
                    }

                    continue;
                }

                return;
            }
        }
    }
}
