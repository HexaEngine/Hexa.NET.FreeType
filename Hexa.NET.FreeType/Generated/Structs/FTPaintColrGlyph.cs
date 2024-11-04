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
	/// FT_PaintColrGlyph<br/>
	/// <br/>
	/// :<br/>
	/// A structure representing a 'COLR' v1 `PaintColorGlyph` paint table.<br/>
	/// <br/>
	/// :<br/>
	/// glyphID ::<br/>
	/// The glyph ID from the `BaseGlyphV1List` table that is drawn for<br/>
	/// this paint.<br/>
	/// <br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "FT_PaintColrGlyph_")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct FTPaintColrGlyph
	{
		[NativeName(NativeNameType.Field, "glyphID")]
		[NativeName(NativeNameType.Type, "FT_UInt")]
		public uint GlyphID;

		public unsafe FTPaintColrGlyph(uint glyphID = default)
		{
			GlyphID = glyphID;
		}


	}

}