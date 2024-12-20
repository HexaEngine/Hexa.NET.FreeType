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
	/// FT_Color_Root_Transform<br/>
	/// <br/>
	/// :<br/>
	/// An enumeration to specify whether <br/>
	/// _Get_Color_Glyph_Paint is to<br/>
	/// return a root transform to configure the client's graphics context<br/>
	/// matrix.<br/>
	/// <br/>
	/// :<br/>
	/// FT_COLOR_INCLUDE_ROOT_TRANSFORM ::<br/>
	/// Do include the root transform as the initial <br/>
	/// _COLR_Paint object.<br/>
	/// FT_COLOR_NO_ROOT_TRANSFORM ::<br/>
	/// Do not output an initial root transform.<br/>
	/// <br/>
	/// </summary>
	[NativeName(NativeNameType.Enum, "FT_Color_Root_Transform_")]
	[Flags]
	public enum FTColorRootTransform : int
	{
		[NativeName(NativeNameType.EnumItem, "FT_COLOR_INCLUDE_ROOT_TRANSFORM")]
		[NativeName(NativeNameType.Value, "0")]
		IncludeRootTransform = unchecked(0),
		[NativeName(NativeNameType.EnumItem, "FT_COLOR_NO_ROOT_TRANSFORM")]
		[NativeName(NativeNameType.Value, "1")]
		NoRootTransform = unchecked(1),
		[NativeName(NativeNameType.EnumItem, "FT_COLOR_ROOT_TRANSFORM_MAX")]
		[NativeName(NativeNameType.Value, "2")]
		Max = unchecked(2),
	}
}
