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
	/// FT_GlyphRec<br/>
	/// <br/>
	/// :<br/>
	/// The root glyph structure contains a given glyph image plus its advance<br/>
	/// width in 16.16 fixed-point format.<br/>
	/// <br/>
	/// :<br/>
	/// library ::<br/>
	/// A handle to the FreeType library object.<br/>
	/// clazz ::<br/>
	/// A pointer to the glyph's class.  Private.<br/>
	/// format ::<br/>
	/// The format of the glyph's image.<br/>
	/// advance ::<br/>
	/// A 16.16 vector that gives the glyph's advance width.<br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "FT_GlyphRec_")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct FTGlyphRec
	{
		[NativeName(NativeNameType.Field, "library")]
		[NativeName(NativeNameType.Type, "FT_Library")]
		public FTLibrary Library;
		[NativeName(NativeNameType.Field, "clazz")]
		[NativeName(NativeNameType.Type, "FT_Glyph_Class const *")]
		public unsafe FTGlyphClass* Clazz;
		[NativeName(NativeNameType.Field, "format")]
		[NativeName(NativeNameType.Type, "FT_Glyph_Format")]
		public FTGlyphFormat Format;
		[NativeName(NativeNameType.Field, "advance")]
		[NativeName(NativeNameType.Type, "FT_Vector")]
		public FTVector Advance;

		public unsafe FTGlyphRec(FTLibrary library = default, FTGlyphClass* clazz = default, FTGlyphFormat format = default, FTVector advance = default)
		{
			Library = library;
			Clazz = clazz;
			Format = format;
			Advance = advance;
		}


	}

}
