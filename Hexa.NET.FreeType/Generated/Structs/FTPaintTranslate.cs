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
	/// FT_PaintTranslate<br/>
	/// <br/>
	/// :<br/>
	/// A structure representing a 'COLR' v1 `PaintTranslate` paint table.<br/>
	/// Used for translating downstream paints by a given x and y~delta.<br/>
	/// <br/>
	/// :<br/>
	/// paint ::<br/>
	/// An <br/>
	/// _OpaquePaint object referencing the paint that is to be<br/>
	/// rotated.<br/>
	/// dx ::<br/>
	/// Translation in x~direction in font units represented as a<br/>
	/// 16.16 fixed-point value.<br/>
	/// dy ::<br/>
	/// Translation in y~direction in font units represented as a<br/>
	/// 16.16 fixed-point value.<br/>
	/// <br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "FT_PaintTranslate_")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct FTPaintTranslate
	{
		[NativeName(NativeNameType.Field, "paint")]
		[NativeName(NativeNameType.Type, "FT_OpaquePaint")]
		public FTOpaquePaint Paint;
		[NativeName(NativeNameType.Field, "dx")]
		[NativeName(NativeNameType.Type, "FT_Fixed")]
		public int Dx;
		[NativeName(NativeNameType.Field, "dy")]
		[NativeName(NativeNameType.Type, "FT_Fixed")]
		public int Dy;

		public unsafe FTPaintTranslate(FTOpaquePaint paint = default, int dx = default, int dy = default)
		{
			Paint = paint;
			Dx = dx;
			Dy = dy;
		}


	}

}
