namespace Example
{
    using Hexa.NET.FreeType;
    using System.Runtime.InteropServices;

    internal unsafe class Program
    {
        private static int Main(string[] args)
        {
            FTError error;
            FTLibrary library = default;
            error = FreeType.InitFreeType(ref library);

            if (error != FTError.Ok)
            {
                Console.WriteLine($"Failed to initialize library, {error}");
                return 1;
            }

            int major = 0, minor = 0, patch = 0;
            library.Version(ref major, ref minor, ref patch);

            Console.WriteLine($"FreeType {major}.{minor}.{patch}");

            FTFace faceHandle = default;

            error = FreeType.NewFace(library, "arial.ttf", 0, ref faceHandle);
            if (error != FTError.Ok)
            {
                Console.WriteLine($"Failed to load font file, {error}");
                return 1;
            }

            FTFaceRec* face = (FTFaceRec*)faceHandle.Handle;

            Console.WriteLine($"Font Family: {Marshal.PtrToStringUTF8((nint)face->FamilyName)}");
            Console.WriteLine($"Font Style: {Marshal.PtrToStringUTF8((nint)face->StyleName)}");
            Console.WriteLine($"Num Glyphs: {face->NumGlyphs}");

            faceHandle.DoneFace();
            FreeType.DoneFreeType(library);
            return 0;
        }
    }
}