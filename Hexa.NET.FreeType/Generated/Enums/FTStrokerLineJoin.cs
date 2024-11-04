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
	/// FT_Stroker_LineJoin<br/>
	/// <br/>
	/// :<br/>
	/// These values determine how two joining lines are rendered in a<br/>
	/// stroker.<br/>
	/// <br/>
	/// :<br/>
	/// FT_STROKER_LINEJOIN_ROUND ::<br/>
	/// Used to render rounded line joins.  Circular arcs are used to join<br/>
	/// two lines smoothly.<br/>
	/// FT_STROKER_LINEJOIN_BEVEL ::<br/>
	/// Used to render beveled line joins.  The outer corner of the joined<br/>
	/// lines is filled by enclosing the triangular region of the corner<br/>
	/// with a straight line between the outer corners of each stroke.<br/>
	/// FT_STROKER_LINEJOIN_MITER_FIXED ::<br/>
	/// Used to render mitered line joins, with fixed bevels if the miter<br/>
	/// limit is exceeded.  The outer edges of the strokes for the two<br/>
	/// segments are extended until they meet at an angle.  A bevel join<br/>
	/// (see above) is used if the segments meet at too sharp an angle and<br/>
	/// the outer edges meet beyond a distance corresponding to the meter<br/>
	/// limit.  This prevents long spikes being created.<br/>
	/// `FT_STROKER_LINEJOIN_MITER_FIXED` generates a miter line join as<br/>
	/// used in PostScript and PDF.<br/>
	/// FT_STROKER_LINEJOIN_MITER_VARIABLE ::<br/>
	/// FT_STROKER_LINEJOIN_MITER ::<br/>
	/// Used to render mitered line joins, with variable bevels if the miter<br/>
	/// limit is exceeded.  The intersection of the strokes is clipped<br/>
	/// perpendicularly to the bisector, at a distance corresponding to<br/>
	/// the miter limit. This prevents long spikes being created.<br/>
	/// `FT_STROKER_LINEJOIN_MITER_VARIABLE` generates a mitered line join<br/>
	/// as used in XPS.  `FT_STROKER_LINEJOIN_MITER` is an alias for<br/>
	/// `FT_STROKER_LINEJOIN_MITER_VARIABLE`, retained for backward<br/>
	/// compatibility.<br/>
	/// </summary>
	[NativeName(NativeNameType.Enum, "FT_Stroker_LineJoin_")]
	[Flags]
	public enum FTStrokerLineJoin : int
	{
		[NativeName(NativeNameType.EnumItem, "FT_STROKER_LINEJOIN_ROUND")]
		[NativeName(NativeNameType.Value, "0")]
		Round = unchecked(0),
		[NativeName(NativeNameType.EnumItem, "FT_STROKER_LINEJOIN_BEVEL")]
		[NativeName(NativeNameType.Value, "1")]
		Bevel = unchecked(1),
		[NativeName(NativeNameType.EnumItem, "FT_STROKER_LINEJOIN_MITER_VARIABLE")]
		[NativeName(NativeNameType.Value, "2")]
		MiterVariable = unchecked(2),
		[NativeName(NativeNameType.EnumItem, "FT_STROKER_LINEJOIN_MITER")]
		[NativeName(NativeNameType.Value, "FT_STROKER_LINEJOIN_MITER_VARIABLE")]
		Miter = MiterVariable,
		[NativeName(NativeNameType.EnumItem, "FT_STROKER_LINEJOIN_MITER_FIXED")]
		[NativeName(NativeNameType.Value, "3")]
		MiterFixed = unchecked(3),
	}
}