// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using HexaGen.Runtime;

namespace Hexa.NET.FreeType
{
	/// <summary>
	/// ************************************************************************<br/>
	/// <br/>
	/// FT_Bitmap<br/>
	/// <br/>
	/// :<br/>
	/// A structure used to describe a bitmap or pixmap to the raster.  Note<br/>
	/// that we now manage pixmaps of various depths through the `pixel_mode`<br/>
	/// field.<br/>
	/// <br/>
	/// :<br/>
	/// rows ::<br/>
	/// The number of bitmap rows.<br/>
	/// width ::<br/>
	/// The number of pixels in bitmap row.<br/>
	/// pitch ::<br/>
	/// The pitch's absolute value is the number of bytes taken by one<br/>
	/// bitmap row, including padding.  However, the pitch is positive when<br/>
	/// the bitmap has a 'down' flow, and negative when it has an 'up' flow.<br/>
	/// In all cases, the pitch is an offset to add to a bitmap pointer in<br/>
	/// order to go down one row.<br/>
	/// Note that 'padding' means the alignment of a bitmap to a byte<br/>
	/// border, and FreeType functions normally align to the smallest<br/>
	/// possible integer value.<br/>
	/// For the B/W rasterizer, `pitch` is always an even number.<br/>
	/// To change the pitch of a bitmap (say, to make it a multiple of 4),<br/>
	/// use <br/>
	/// _Bitmap_Convert.  Alternatively, you might use callback<br/>
	/// functions to directly render to the application's surface; see the<br/>
	/// file `example2.cpp` in the tutorial for a demonstration.<br/>
	/// buffer ::<br/>
	/// A typeless pointer to the bitmap buffer.  This value should be<br/>
	/// aligned on 32-bit boundaries in most cases.<br/>
	/// num_grays ::<br/>
	/// This field is only used with <br/>
	/// _PIXEL_MODE_GRAY; it gives the<br/>
	/// number of gray levels used in the bitmap.<br/>
	/// pixel_mode ::<br/>
	/// The pixel mode, i.e., how pixel bits are stored.  See <br/>
	/// _Pixel_Mode<br/>
	/// for possible values.<br/>
	/// palette_mode ::<br/>
	/// This field is intended for paletted pixel modes; it indicates how<br/>
	/// the palette is stored.  Not used currently.<br/>
	/// palette ::<br/>
	/// A typeless pointer to the bitmap palette; this field is intended for<br/>
	/// paletted pixel modes.  Not used currently.<br/>
	/// <br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "FT_Bitmap_")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct FTBitmap
	{
		[NativeName(NativeNameType.Field, "rows")]
		[NativeName(NativeNameType.Type, "unsigned int")]
		public uint Rows;
		[NativeName(NativeNameType.Field, "width")]
		[NativeName(NativeNameType.Type, "unsigned int")]
		public uint Width;
		[NativeName(NativeNameType.Field, "pitch")]
		[NativeName(NativeNameType.Type, "int")]
		public int Pitch;
		[NativeName(NativeNameType.Field, "buffer")]
		[NativeName(NativeNameType.Type, "unsigned char *")]
		public unsafe byte* Buffer;
		[NativeName(NativeNameType.Field, "num_grays")]
		[NativeName(NativeNameType.Type, "unsigned short")]
		public ushort NumGrays;
		[NativeName(NativeNameType.Field, "pixel_mode")]
		[NativeName(NativeNameType.Type, "unsigned char")]
		public byte PixelMode;
		[NativeName(NativeNameType.Field, "palette_mode")]
		[NativeName(NativeNameType.Type, "unsigned char")]
		public byte PaletteMode;
		[NativeName(NativeNameType.Field, "palette")]
		[NativeName(NativeNameType.Type, "void *")]
		public unsafe void* Palette;

		public unsafe FTBitmap(uint rows = default, uint width = default, int pitch = default, byte* buffer = default, ushort numGrays = default, byte pixelMode = default, byte paletteMode = default, void* palette = default)
		{
			Rows = rows;
			Width = width;
			Pitch = pitch;
			Buffer = buffer;
			NumGrays = numGrays;
			PixelMode = pixelMode;
			PaletteMode = paletteMode;
			Palette = palette;
		}


	}

}
