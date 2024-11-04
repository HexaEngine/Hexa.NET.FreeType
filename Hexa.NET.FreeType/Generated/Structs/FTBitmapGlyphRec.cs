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
	/// FT_BitmapGlyphRec<br/>
	/// <br/>
	/// :<br/>
	/// A structure used for bitmap glyph images.  This really is a<br/>
	/// 'sub-class' of <br/>
	/// _GlyphRec.<br/>
	/// <br/>
	/// :<br/>
	/// root ::<br/>
	/// The root fields of <br/>
	/// _Glyph.<br/>
	/// left ::<br/>
	/// The left-side bearing, i.e., the horizontal distance from the<br/>
	/// current pen position to the left border of the glyph bitmap.<br/>
	/// top ::<br/>
	/// The top-side bearing, i.e., the vertical distance from the current<br/>
	/// pen position to the top border of the glyph bitmap.  This distance<br/>
	/// is positive for upwards~y!<br/>
	/// bitmap ::<br/>
	/// A descriptor for the bitmap.<br/>
	/// <br/>
	/// The corresponding pixel buffer is always owned by <br/>
	/// _BitmapGlyph and<br/>
	/// is thus created and destroyed with it.<br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "FT_BitmapGlyphRec_")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct FTBitmapGlyphRec
	{
		[NativeName(NativeNameType.Field, "root")]
		[NativeName(NativeNameType.Type, "FT_GlyphRec")]
		public FTGlyphRec Root;
		[NativeName(NativeNameType.Field, "left")]
		[NativeName(NativeNameType.Type, "FT_Int")]
		public int Left;
		[NativeName(NativeNameType.Field, "top")]
		[NativeName(NativeNameType.Type, "FT_Int")]
		public int Top;
		[NativeName(NativeNameType.Field, "bitmap")]
		[NativeName(NativeNameType.Type, "FT_Bitmap")]
		public FTBitmap Bitmap;

		public unsafe FTBitmapGlyphRec(FTGlyphRec root = default, int left = default, int top = default, FTBitmap bitmap = default)
		{
			Root = root;
			Left = left;
			Top = top;
			Bitmap = bitmap;
		}


	}

}
