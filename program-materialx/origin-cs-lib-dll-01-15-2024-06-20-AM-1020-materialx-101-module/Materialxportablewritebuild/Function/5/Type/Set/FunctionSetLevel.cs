using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class MaterialxportablewritebuildModule
    {
        public partial class XQuintuple
        {
            public static IList<MaterialxportablewriteXleve_Y> FunctionLevelSet(MaterialxportablewriteXlev_lY[] Level_ARRAY, Materialxportablelayout value_MATERIALXPORTABLELAYOUT)
            {
                ICollection<MaterialxportablewriteXleve_Y> collectionResult = default;

                collectionResult = new Collection<MaterialxportablewriteXleve_Y>();

                var index = 0;

                index = index + value_MATERIALXPORTABLELAYOUT.StartAddressObjectTable;

                foreach (MaterialxportablewriteXlev_lY Level_VALUE in Level_ARRAY)
                {
                    Int32 x, y, u, v, w, z;

                    x = 0;

                    x = x + index;

                    y = 0;

                    y = y + index;

                    y = y + ((Byte[])Level_VALUE.RouteByteArray).Length;

                    y = y - 1;

                    u = 0;

                    u = u + y;

                    u = u + 1;

                    v = 0;

                    v = v + u;

                    v = v + ((Byte[])Level_VALUE.ObjectByteArray).Length;

                    v = v - 1;

                    w = 0;

                    w = w + v;

                    w = w + 1;

                    z = 0;

                    z = z + w;

                    z = z + ((Byte[])Level_VALUE.TypeByteArray).Length;

                    z = z - 1;

                    MaterialxportablewriteXleve_Y level;

                    level = new MaterialxportablewriteXleve_Y();

                    level.Ordinal = Level_VALUE.Ordinal;

                    level.Length = Level_VALUE.Length;

                    level.Route = Level_VALUE.Route;

                    level.RouteByteArray = Level_VALUE.RouteByteArray;

                    level.ObjectByteArray = Level_VALUE.ObjectByteArray;

                    level.TypeByteArray = Level_VALUE.TypeByteArray;

                    level.RouteStartAddress = x;

                    level.RouteEndAddress = y;

                    level.ObjectStartAddress = u;

                    level.ObjectEndAddress = v;

                    level.TypeStartAddress = w;

                    level.TypeEndAddress = z;
                    
                    level.Materialxportable = Level_VALUE.Materialxportable;

                    collectionResult.Add(level);

                    index = index + Level_VALUE.RouteByteArray.Length;

                    index = index + Level_VALUE.ObjectByteArray.Length;

                    index = index + Level_VALUE.TypeByteArray.Length;

                    continue;
                }

                return new List<MaterialxportablewriteXleve_Y>(collectionResult);
            }
        }
    }
}
