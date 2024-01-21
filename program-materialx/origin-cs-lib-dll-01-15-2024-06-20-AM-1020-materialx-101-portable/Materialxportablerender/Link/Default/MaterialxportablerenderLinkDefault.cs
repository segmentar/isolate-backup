using Core;

namespace Core
{
    using System;

    public partial class MaterialxportablerenderDefault
    {
        public static String ErrorDefault;

        static MaterialxportablerenderDefault()
        {
            ErrorDefault = String.Concat("Sorry, this object just so happened to be null" + '.' + ' ' + ":(");

            return;
        }
    }
}
