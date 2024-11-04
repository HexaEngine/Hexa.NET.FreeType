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
	/// FT_ColorStopIterator<br/>
	/// <br/>
	/// :<br/>
	/// This iterator object is needed for <br/>
	/// _Get_Colorline_Stops.  It keeps<br/>
	/// state while iterating over the stops of an <br/>
	/// _ColorLine, representing<br/>
	/// the `ColorLine` struct of the v1 extensions to 'COLR', see<br/>
	/// 'https://github.com/googlefonts/colr-gradients-spec'.  Do not manually<br/>
	/// modify fields of this iterator.<br/>
	/// <br/>
	/// :<br/>
	/// num_color_stops ::<br/>
	/// The number of color stops for the requested glyph index.  Set by<br/>
	/// <br/>
	/// _Get_Paint.<br/>
	/// current_color_stop ::<br/>
	/// The current color stop.  Set by <br/>
	/// _Get_Colorline_Stops.<br/>
	/// p ::<br/>
	/// An opaque pointer into 'COLR' table data.  Set by <br/>
	/// _Get_Paint.<br/>
	/// Updated by <br/>
	/// _Get_Colorline_Stops.<br/>
	/// read_variable ::<br/>
	/// A boolean keeping track of whether variable color lines are to be<br/>
	/// read.  Set by <br/>
	/// _Get_Paint.<br/>
	/// <br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "FT_ColorStopIterator_")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct FTColorStopIterator
	{
		[NativeName(NativeNameType.Field, "num_color_stops")]
		[NativeName(NativeNameType.Type, "FT_UInt")]
		public uint NumColorStops;
		[NativeName(NativeNameType.Field, "current_color_stop")]
		[NativeName(NativeNameType.Type, "FT_UInt")]
		public uint CurrentColorStop;
		[NativeName(NativeNameType.Field, "p")]
		[NativeName(NativeNameType.Type, "FT_Byte *")]
		public unsafe byte* P;
		[NativeName(NativeNameType.Field, "read_variable")]
		[NativeName(NativeNameType.Type, "FT_Bool")]
		public byte ReadVariable;

		public unsafe FTColorStopIterator(uint numColorStops = default, uint currentColorStop = default, byte* p = default, byte readVariable = default)
		{
			NumColorStops = numColorStops;
			CurrentColorStop = currentColorStop;
			P = p;
			ReadVariable = readVariable;
		}


	}

}
