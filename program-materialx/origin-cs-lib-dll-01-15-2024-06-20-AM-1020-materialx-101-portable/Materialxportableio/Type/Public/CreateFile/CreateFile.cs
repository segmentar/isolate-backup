using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Materialxportableio
    {
        public static String CreateFile(String Path_VALUE, String Content_VALUE)
        {
            String stringResult = default;

            if (File.Exists(Path_VALUE) is true)
            {
                File.Delete(Path_VALUE);
            }
            else
                "false".ToString();

            if (File.Exists(Path_VALUE) is false)
            {
                File.WriteAllText(Path_VALUE, Content_VALUE);
            }
            else
                "false".ToString();

            var result = Path_VALUE;

            stringResult = result;

            return stringResult;
        }
    }
}
