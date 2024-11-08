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
	/// FT_PaintTransform<br/>
	/// <br/>
	/// :<br/>
	/// A structure representing a 'COLR' v1 `PaintTransform` paint table.<br/>
	/// <br/>
	/// :<br/>
	/// paint ::<br/>
	/// An opaque paint that is subject to being transformed.<br/>
	/// affine ::<br/>
	/// A 2x3 transformation matrix in <br/>
	/// _Affine23 format containing<br/>
	/// 16.16 fixed-point values.<br/>
	/// <br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "FT_PaintTransform_")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct FTPaintTransform
	{
		[NativeName(NativeNameType.Field, "paint")]
		[NativeName(NativeNameType.Type, "FT_OpaquePaint")]
		public FTOpaquePaint Paint;
		[NativeName(NativeNameType.Field, "affine")]
		[NativeName(NativeNameType.Type, "FT_Affine23")]
		public FTAffine23 Affine;

		public unsafe FTPaintTransform(FTOpaquePaint paint = default, FTAffine23 affine = default)
		{
			Paint = paint;
			Affine = affine;
		}


	}

}
