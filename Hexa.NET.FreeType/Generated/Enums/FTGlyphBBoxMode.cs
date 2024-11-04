// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using HexaGen.Runtime;

namespace Hexa.NET.FreeType
{
	/// <summary>
	/// ************************************************************************<br/>
	/// <br/>
	/// FT_Glyph_BBox_Mode<br/>
	/// <br/>
	/// :<br/>
	/// The mode how the values of <br/>
	/// _Glyph_Get_CBox are returned.<br/>
	/// <br/>
	/// :<br/>
	/// FT_GLYPH_BBOX_UNSCALED ::<br/>
	/// Return unscaled font units.<br/>
	/// FT_GLYPH_BBOX_SUBPIXELS ::<br/>
	/// Return unfitted 26.6 coordinates.<br/>
	/// FT_GLYPH_BBOX_GRIDFIT ::<br/>
	/// Return grid-fitted 26.6 coordinates.<br/>
	/// FT_GLYPH_BBOX_TRUNCATE ::<br/>
	/// Return coordinates in integer pixels.<br/>
	/// FT_GLYPH_BBOX_PIXELS ::<br/>
	/// Return grid-fitted pixel coordinates.<br/>
	/// </summary>
	[NativeName(NativeNameType.Enum, "FT_Glyph_BBox_Mode_")]
	[Flags]
	public enum FTGlyphBBoxMode : int
	{
		[NativeName(NativeNameType.EnumItem, "FT_GLYPH_BBOX_UNSCALED")]
		[NativeName(NativeNameType.Value, "0")]
		Unscaled = unchecked(0),
		[NativeName(NativeNameType.EnumItem, "FT_GLYPH_BBOX_SUBPIXELS")]
		[NativeName(NativeNameType.Value, "0")]
		Subpixels = unchecked(0),
		[NativeName(NativeNameType.EnumItem, "FT_GLYPH_BBOX_GRIDFIT")]
		[NativeName(NativeNameType.Value, "1")]
		Gridfit = unchecked(1),
		[NativeName(NativeNameType.EnumItem, "FT_GLYPH_BBOX_TRUNCATE")]
		[NativeName(NativeNameType.Value, "2")]
		Truncate = unchecked(2),
		[NativeName(NativeNameType.EnumItem, "FT_GLYPH_BBOX_PIXELS")]
		[NativeName(NativeNameType.Value, "3")]
		Pixels = unchecked(3),
	}
}