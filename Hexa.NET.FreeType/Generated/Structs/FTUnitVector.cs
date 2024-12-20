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
	/// FT_UnitVector<br/>
	/// <br/>
	/// :<br/>
	/// A simple structure used to store a 2D vector unit vector.  Uses<br/>
	/// FT_F2Dot14 types.<br/>
	/// <br/>
	/// :<br/>
	/// x ::<br/>
	/// Horizontal coordinate.<br/>
	/// y ::<br/>
	/// Vertical coordinate.<br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "FT_UnitVector_")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct FTUnitVector
	{
		[NativeName(NativeNameType.Field, "x")]
		[NativeName(NativeNameType.Type, "FT_F2Dot14")]
		public short X;
		[NativeName(NativeNameType.Field, "y")]
		[NativeName(NativeNameType.Type, "FT_F2Dot14")]
		public short Y;

		public unsafe FTUnitVector(short x = default, short y = default)
		{
			X = x;
			Y = y;
		}


	}

}
