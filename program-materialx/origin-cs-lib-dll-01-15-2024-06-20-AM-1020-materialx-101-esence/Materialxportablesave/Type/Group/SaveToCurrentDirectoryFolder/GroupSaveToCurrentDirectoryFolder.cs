using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Materialxportablesave
    {
        public static void GroupSaveToCurrentDirectoryFolder(Materialxportable value_MATERIALXPORTABLE, Materialxportablesavecontext value_MATERIALXPORTABLESAVECONTEXT, Materialxportablewriteclose value_MATERIALXPORTABLEWRITECLOSE, String FolderName__VALUE, String FileName__VALUE)
        {
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

            GroupSave(value_MATERIALXPORTABLE, value_MATERIALXPORTABLESAVECONTEXT, value_MATERIALXPORTABLEWRITECLOSE, path_FILE_filename_with_extension);

            return;
        }
    }
}
