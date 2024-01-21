using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;


    public partial class MaterialxportablewritebuildModule
    {
        public partial class XSextuple
        {
            public static IList<MaterialxportablewriteU_evelV> FunctionLevelSet(MaterialxportablewriteXleve_Y[] Level_ARRAY)
            {
                ICollection<MaterialxportablewriteU_evelV> collectionResult = default;

                collectionResult = new Collection<MaterialxportablewriteU_evelV>();

                foreach (MaterialxportablewriteXleve_Y Level_VALUE in Level_ARRAY)
                {
                    MaterialxportablewriteU_evelV level;

                    level = new MaterialxportablewriteU_evelV();

                    level.Ordinal = Level_VALUE.Ordinal;

                    level.Length = Level_VALUE.Length;

                    level.Route = Level_VALUE.Route;

                    level.RouteByteArray = Level_VALUE.RouteByteArray;

                    level.ObjectByteArray = Level_VALUE.ObjectByteArray;

                    level.TypeByteArray = Level_VALUE.TypeByteArray;

                    level.RouteStartAddress = Level_VALUE.RouteStartAddress;

                    level.RouteEndAddress = Level_VALUE.RouteEndAddress;

                    level.ObjectStartAddress = Level_VALUE.ObjectStartAddress;

                    level.ObjectEndAddress = Level_VALUE.ObjectEndAddress;

                    level.TypeStartAddress = Level_VALUE.TypeStartAddress;

                    level.TypeEndAddress = Level_VALUE.TypeEndAddress;

                    collectionResult.Add(level);

                    continue;
                }

                return new List<MaterialxportablewriteU_evelV>(collectionResult);
            }
        }

    }
}
