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
	/// FT_ColorIndex<br/>
	/// <br/>
	/// :<br/>
	/// A structure representing a `ColorIndex` value of the 'COLR' v1<br/>
	/// extensions, see 'https://github.com/googlefonts/colr-gradients-spec'.<br/>
	/// <br/>
	/// :<br/>
	/// palette_index ::<br/>
	/// The palette index into a 'CPAL' palette.<br/>
	/// alpha ::<br/>
	/// Alpha transparency value multiplied with the value from 'CPAL'.<br/>
	/// <br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "FT_ColorIndex_")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct FTColorIndex
	{
		[NativeName(NativeNameType.Field, "palette_index")]
		[NativeName(NativeNameType.Type, "FT_UInt16")]
		public ushort PaletteIndex;
		[NativeName(NativeNameType.Field, "alpha")]
		[NativeName(NativeNameType.Type, "FT_F2Dot14")]
		public short Alpha;

		public unsafe FTColorIndex(ushort paletteIndex = default, short alpha = default)
		{
			PaletteIndex = paletteIndex;
			Alpha = alpha;
		}


	}

}