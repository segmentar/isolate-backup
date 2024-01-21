using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Materialxportableload
    {
        public static Materialxportable GroupLoadFromCurrentDirectoryFolder(Materialxportableloadcontext value_MATERIALXPORTABLELOADCONTEXT, Materialxportablereadclose value_MATERIALXPORTABLEREADCLOSE, String FolderName__VALUE, String FileName__VALUE)
        {
            Materialxportable materialxportableResult = default;

            var CurrentDirectory__PATH = Directory.GetCurrentDirectory();

            var path_DIRECTORY_full_name = Path.Combine(CurrentDirectory__PATH, FolderName__VALUE);

            if (Directory.Exists(path_DIRECTORY_full_name) is false)
            {
                DirectoryInfo directoryInfo;

                directoryInfo = Directory.CreateDirectory(path_DIRECTORY_full_name);

                path_DIRECTORY_full_name = directoryInfo.FullName;
            }
            else
                "false".ToString();

            var path_FILE_filename = Path.Combine(path_DIRECTORY_full_name, FileName__VALUE);

            var path_FILE_filename_with_extension = Path.ChangeExtension(path_FILE_filename, Materialxportablename.EntityMaterialExtension);

            var array = GroupLoad(value_MATERIALXPORTABLELOADCONTEXT, value_MATERIALXPORTABLEREADCLOSE, path_FILE_filename_with_extension);

            var reflect = (MaterialxportablereadbuildModule)(array[2] as Object);

            var result = reflect.MaterialxportablereadbuildPort.Materialxportable;

            materialxportableResult = result;

            return materialxportableResult;
        }
    }
}
