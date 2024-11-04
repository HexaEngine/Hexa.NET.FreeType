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
	/// FT_Orientation<br/>
	/// <br/>
	/// :<br/>
	/// A list of values used to describe an outline's contour orientation.<br/>
	/// The TrueType and PostScript specifications use different conventions<br/>
	/// to determine whether outline contours should be filled or unfilled.<br/>
	/// <br/>
	/// :<br/>
	/// FT_ORIENTATION_TRUETYPE ::<br/>
	/// According to the TrueType specification, clockwise contours must be<br/>
	/// filled, and counter-clockwise ones must be unfilled.<br/>
	/// FT_ORIENTATION_POSTSCRIPT ::<br/>
	/// According to the PostScript specification, counter-clockwise<br/>
	/// contours must be filled, and clockwise ones must be unfilled.<br/>
	/// FT_ORIENTATION_FILL_RIGHT ::<br/>
	/// This is identical to <br/>
	/// _ORIENTATION_TRUETYPE, but is used to<br/>
	/// remember that in TrueType, everything that is to the right of the<br/>
	/// drawing direction of a contour must be filled.<br/>
	/// FT_ORIENTATION_FILL_LEFT ::<br/>
	/// This is identical to <br/>
	/// _ORIENTATION_POSTSCRIPT, but is used to<br/>
	/// remember that in PostScript, everything that is to the left of the<br/>
	/// drawing direction of a contour must be filled.<br/>
	/// FT_ORIENTATION_NONE ::<br/>
	/// The orientation cannot be determined.  That is, different parts of<br/>
	/// the glyph have different orientation.<br/>
	/// <br/>
	/// </summary>
	[NativeName(NativeNameType.Enum, "FT_Orientation_")]
	[Flags]
	public enum FTOrientation : int
	{
		[NativeName(NativeNameType.EnumItem, "FT_ORIENTATION_TRUETYPE")]
		[NativeName(NativeNameType.Value, "0")]
		Truetype = unchecked(0),
		[NativeName(NativeNameType.EnumItem, "FT_ORIENTATION_POSTSCRIPT")]
		[NativeName(NativeNameType.Value, "1")]
		Postscript = unchecked(1),
		[NativeName(NativeNameType.EnumItem, "FT_ORIENTATION_FILL_RIGHT")]
		[NativeName(NativeNameType.Value, "FT_ORIENTATION_TRUETYPE")]
		FillRight = Truetype,
		[NativeName(NativeNameType.EnumItem, "FT_ORIENTATION_FILL_LEFT")]
		[NativeName(NativeNameType.Value, "FT_ORIENTATION_POSTSCRIPT")]
		FillLeft = Postscript,
		[NativeName(NativeNameType.EnumItem, "FT_ORIENTATION_NONE")]
		[NativeName(NativeNameType.Value, "2")]
		None = unchecked(2),
	}
}
