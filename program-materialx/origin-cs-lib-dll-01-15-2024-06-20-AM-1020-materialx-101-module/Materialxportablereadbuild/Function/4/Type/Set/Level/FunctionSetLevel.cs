using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class MaterialxportablereadbuildModule
    {
        public partial class XQuadruple
        {
            public static IList<MaterialxportablereadXlev_lY> FunctionLevelSet(MaterialxportablereadXle_elY[] Level_ARRAY)
            {
                ICollection<MaterialxportablereadXlev_lY> collectionResult = default;

                collectionResult = new Collection<MaterialxportablereadXlev_lY>();

                foreach (MaterialxportablereadXle_elY Level_VALUE in Level_ARRAY)
                {
                    var separator = new Char[1];

                    separator[0] = (Char)Materialxportableascii.EntityNull;

                    var split = Level_VALUE.Route.Split(separator, StringSplitOptions.RemoveEmptyEntries);

                    var aoth = split.Length;

                    var zee = (aoth + 1);

                    var array = new String[zee];

                    split.CopyTo(array, 1);

                    array[0] = Materialxportablename.EntityRoot;
                    
                    Materialxportable materialxportable;

                    materialxportable = new MaterialxportableSimple(array).Result;

                    materialxportable.ObjectIdentity = Level_VALUE.Object;

                    MaterialxportablereadXlev_lY level;

                    level = new MaterialxportablereadXlev_lY();

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

                    level.Route = Level_VALUE.Route;

                    level.Object = Level_VALUE.Object;

                    level.Type = Level_VALUE.Type;

                    level.Materialxportable = materialxportable;

                    collectionResult.Add(level);

                    continue;
                }

                return new List<MaterialxportablereadXlev_lY>(collectionResult);
            }
        }
    }
}
