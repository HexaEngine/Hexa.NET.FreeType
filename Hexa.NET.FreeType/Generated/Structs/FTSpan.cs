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
	/// FT_Span<br/>
	/// <br/>
	/// :<br/>
	/// A structure to model a single span of consecutive pixels when<br/>
	/// rendering an anti-aliased bitmap.<br/>
	/// <br/>
	/// :<br/>
	/// x ::<br/>
	/// The span's horizontal start position.<br/>
	/// len ::<br/>
	/// The span's length in pixels.<br/>
	/// coverage ::<br/>
	/// The span color/coverage, ranging from 0 (background) to 255<br/>
	/// (foreground).<br/>
	/// <br/>
	/// The anti-aliased rasterizer produces coverage values from 0 to 255,<br/>
	/// that is, from completely transparent to completely opaque.<br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "FT_Span_")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct FTSpan
	{
		[NativeName(NativeNameType.Field, "x")]
		[NativeName(NativeNameType.Type, "short")]
		public short X;
		[NativeName(NativeNameType.Field, "len")]
		[NativeName(NativeNameType.Type, "unsigned short")]
		public ushort Len;
		[NativeName(NativeNameType.Field, "coverage")]
		[NativeName(NativeNameType.Type, "unsigned char")]
		public byte Coverage;

		public unsafe FTSpan(short x = default, ushort len = default, byte coverage = default)
		{
			X = x;
			Len = len;
			Coverage = coverage;
		}


	}

}
