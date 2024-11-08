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
	/// FT_Kerning_Mode<br/>
	/// <br/>
	/// :<br/>
	/// An enumeration to specify the format of kerning values returned by<br/>
	/// <br/>
	/// _Get_Kerning.<br/>
	/// <br/>
	/// :<br/>
	/// FT_KERNING_DEFAULT ::<br/>
	/// Return grid-fitted kerning distances in 26.6 fractional pixels.<br/>
	/// FT_KERNING_UNFITTED ::<br/>
	/// Return un-grid-fitted kerning distances in 26.6 fractional pixels.<br/>
	/// FT_KERNING_UNSCALED ::<br/>
	/// Return the kerning vector in original font units.<br/>
	/// <br/>
	/// Both `FT_KERNING_DEFAULT` and `FT_KERNING_UNFITTED` use the current<br/>
	/// horizontal scaling factor (as set e.g. with <br/>
	/// _Set_Char_Size) to<br/>
	/// convert font units to pixels.<br/>
	/// </summary>
	[NativeName(NativeNameType.Enum, "FT_Kerning_Mode_")]
	[Flags]
	public enum FTKerningMode : int
	{
		[NativeName(NativeNameType.EnumItem, "FT_KERNING_DEFAULT")]
		[NativeName(NativeNameType.Value, "0")]
		Default = unchecked(0),
		[NativeName(NativeNameType.EnumItem, "FT_KERNING_UNFITTED")]
		[NativeName(NativeNameType.Value, "1")]
		Unfitted = unchecked(1),
		[NativeName(NativeNameType.EnumItem, "FT_KERNING_UNSCALED")]
		[NativeName(NativeNameType.Value, "2")]
		Unscaled = unchecked(2),
	}
}
