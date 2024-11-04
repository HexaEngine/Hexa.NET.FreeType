namespace Hexa.NET.FreeType
{
    using System.Runtime.InteropServices;

    public static unsafe partial class FreeType
    {
        static FreeType()
        {
            InitApi();
        }

        public static string GetLibraryName()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                return "freetype";
            }

            return "libfreetype";
        }
    }
}