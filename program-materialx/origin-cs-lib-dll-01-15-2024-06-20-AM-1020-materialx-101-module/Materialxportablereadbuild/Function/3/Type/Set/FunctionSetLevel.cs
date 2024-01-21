using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class MaterialxportablereadbuildModule
    {
        public partial class XTriple
        {
            public static IList<MaterialxportablereadXle_elY> FunctionLevelSet(MaterialxportablereadXl_velY[] Level_ARRAY)
            {
                ICollection<MaterialxportablereadXle_elY> collectionResult = default;

                collectionResult = new Collection<MaterialxportablereadXle_elY>();

                foreach (MaterialxportablereadXl_velY Level_VALUE in Level_ARRAY)
                {
                    var data = Materialxportableconfigure.ReaderEncoding.GetString(Level_VALUE.RouteByteArray);

                    var inflect = new Object[2];

                    inflect[0] = Materialxportableremoteout.RemoteType(Level_VALUE.TypeByteArray);

                    inflect[1] = Materialxportableremoteout.Remote(Level_VALUE.ObjectByteArray, (Type)inflect[0]);

                    MaterialxportablereadXle_elY level;

                    level = new MaterialxportablereadXle_elY();

                    level.Ordinal = Level_VALUE.Ordinal;

                    level.Length = Level_VALUE.Length;

                    level.RouteStartAddress = Level_VALUE.RouteStartAddress;

                    level.RouteEndAddress = Level_VALUE.RouteEndAddress;

                    level.ObjectStartAddress = Level_VALUE.ObjectStartAddress;

                    level.ObjectEndAddress = Level_VALUE.ObjectEndAddress;

                    level.TypeStartAddress = Level_VALUE.TypeStartAddress;

                    level.TypeEndAddress = Level_VALUE.TypeEndAddress;

                    level.RouteByteArray = Level_VALUE.RouteByteArray;

                    level.ObjectByteArray = Level_VALUE.ObjectByteArray;

                    level.TypeByteArray = Level_VALUE.TypeByteArray;

                    level.Route = data;

                    level.Object = (Object)inflect[1];

                    level.Type = (Type)inflect[0];

                    collectionResult.Add(level);

                    continue;
                }

                return new List<MaterialxportablereadXle_elY>(collectionResult);
            }
        }
    }
}
