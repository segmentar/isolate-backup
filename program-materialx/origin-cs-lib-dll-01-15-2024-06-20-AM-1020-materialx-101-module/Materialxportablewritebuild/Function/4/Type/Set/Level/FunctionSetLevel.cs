using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class MaterialxportablewritebuildModule
    {
        public static IList<MaterialxportablewriteXlev_lY> FunctionLevelSet(MaterialxportablewriteXle_elY[] Level_ARRAY)
        {
            ICollection<MaterialxportablewriteXlev_lY> collectionResult = default;

            collectionResult = new Collection<MaterialxportablewriteXlev_lY>();

            foreach (MaterialxportablewriteXle_elY Level_VALUE in Level_ARRAY)
            {
                Boolean isDefaultContagentCheck;

                isDefaultContagentCheck = (Level_VALUE.Materialxportable.Type == default).Equals(true);

                String stringValue;

                if (isDefaultContagentCheck)
                {
                    stringValue = String.Empty;
                }
                else
                {
                    stringValue = Level_VALUE.Materialxportable.Type.FullName;
                }

                var inflect = new Object[3];

                inflect[0] = Materialxportableconfigure.WriterEncoding.GetBytes(Level_VALUE.Route);

                inflect[1] = Level_VALUE.Materialxportable.RemoteArrayObject;

                inflect[2] = Materialxportableconfigure.WriterEncoding.GetBytes(stringValue);

                MaterialxportablewriteXlev_lY level;

                level = new MaterialxportablewriteXlev_lY();

                level.Ordinal = Level_VALUE.Ordinal;

                level.Length = Level_VALUE.Length;

                level.Route = Level_VALUE.Route;

                level.RouteByteArray = (Byte[])inflect[0];

                level.ObjectByteArray = (Byte[])inflect[1];

                level.TypeByteArray = (Byte[])inflect[2];

                level.Materialxportable = Level_VALUE.Materialxportable;

                collectionResult.Add(level);

                continue;
            }

            return new List<MaterialxportablewriteXlev_lY>(collectionResult);
        }
    }
}
