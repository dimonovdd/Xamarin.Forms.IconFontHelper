using System;

namespace IconFontHelper
{
    public static class Helper
    {
        public static string IconToString(object obj) => obj is Enum val ? $"{Convert.ToChar(val)}" : null;
    }
}

