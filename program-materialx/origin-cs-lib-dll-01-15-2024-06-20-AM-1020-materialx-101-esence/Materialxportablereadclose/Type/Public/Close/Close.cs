using Core;

namespace Core
{
    using System;

    public partial struct Materialxportablereadclose
    {
        public static void Close(Materialxportablereadclose value_MATERIALXPORTABLEREADCLOSE, Object[] array_OBJECT)
        {
            if (value_MATERIALXPORTABLEREADCLOSE.FileStreamCloseShould is true)
            {
                using (var stream = ((MaterialxportablereadfileModule)array_OBJECT[0]).MaterialxportablereadfilePort.FileStream)
                {
                    stream.Close();

                    stream.Dispose();
                }                    
            }
            else
                "false".ToString();

            if (value_MATERIALXPORTABLEREADCLOSE.MemoryStreamCloseShould is true)
            {
                using (var stream = ((MaterialxportablereadfileModule)array_OBJECT[0]).MaterialxportablereadfilePort.MemoryStream)
                {
                    stream.Close();

                    stream.Dispose();
                }
            }
            else
                "false".ToString();

            return;
        }
    }
}
