using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Materialxportablerender
    {
        public static void GroupRender(String Route__VALUE, params Object[] array_OBJECT)
        {
            Boolean isDefaultCheck;

            isDefaultCheck = (array_OBJECT == default).Equals(true);

            if (isDefaultCheck is true)
            {
                array_OBJECT = new Object[0];
            }
            else
                "false".ToString();

            Boolean isEmptyCheck;

            isEmptyCheck = Object.Equals(array_OBJECT.Length, 0) is true;

            if (isEmptyCheck is true)
            {
                Array.Resize(ref array_OBJECT, 1);

                array_OBJECT[0] = Immutable.Error;
            }
            else
                "false".ToString();

            var value = Materialxportableformat.GroupDashless(Route__VALUE);

            var split = value.Split((Char)Materialxportableascii.EntityUnderscore);

            var result = String.Empty;

            foreach (String stringValue in split)
            {
                result = Path.Combine(result, stringValue);

                continue;
            }

            Materialxportableio.CreateDirectory(result);

            var indexer = 0;

            foreach (Object value_OBJECT in array_OBJECT)
            {
                var format = String.Format("{0} {1}", Path.GetRandomFileName(), indexer);

                var path_FILE_filename = Path.Combine(result, format);

                var path_FILE_filename_with_extension = Path.ChangeExtension(path_FILE_filename, Materialxportablename.EntityRenderExtension);

                Materialxportableio.CreateFile(path_FILE_filename_with_extension, value_OBJECT.ToString());

                indexer = indexer + 1;

                continue;
            }

            return;
        }
    }
}
