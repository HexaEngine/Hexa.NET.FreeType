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
	/// FT_Size_RequestRec<br/>
	/// <br/>
	/// :<br/>
	/// A structure to model a size request.<br/>
	/// <br/>
	/// :<br/>
	/// type ::<br/>
	/// See <br/>
	/// _Size_Request_Type.<br/>
	/// width ::<br/>
	/// The desired width, given as a 26.6 fractional point value (with 72pt<br/>
	/// = 1in).<br/>
	/// height ::<br/>
	/// The desired height, given as a 26.6 fractional point value (with<br/>
	/// 72pt = 1in).<br/>
	/// horiResolution ::<br/>
	/// The horizontal resolution (dpi, i.e., pixels per inch).  If set to<br/>
	/// zero, `width` is treated as a 26.6 fractional **pixel** value, which<br/>
	/// gets internally rounded to an integer.<br/>
	/// vertResolution ::<br/>
	/// The vertical resolution (dpi, i.e., pixels per inch).  If set to<br/>
	/// zero, `height` is treated as a 26.6 fractional **pixel** value,<br/>
	/// which gets internally rounded to an integer.<br/>
	/// <br/>
	/// If `type` is `FT_SIZE_REQUEST_TYPE_SCALES`, `width` and `height` are<br/>
	/// interpreted directly as 16.16 fractional scaling values, without any<br/>
	/// further modification, and both `horiResolution` and `vertResolution`<br/>
	/// are ignored.<br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "FT_Size_RequestRec_")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct FTSizeRequestRec
	{
		[NativeName(NativeNameType.Field, "type")]
		[NativeName(NativeNameType.Type, "FT_Size_Request_Type")]
		public FTSizeRequestType Type;
		[NativeName(NativeNameType.Field, "width")]
		[NativeName(NativeNameType.Type, "FT_Long")]
		public int Width;
		[NativeName(NativeNameType.Field, "height")]
		[NativeName(NativeNameType.Type, "FT_Long")]
		public int Height;
		[NativeName(NativeNameType.Field, "horiResolution")]
		[NativeName(NativeNameType.Type, "FT_UInt")]
		public uint HoriResolution;
		[NativeName(NativeNameType.Field, "vertResolution")]
		[NativeName(NativeNameType.Type, "FT_UInt")]
		public uint VertResolution;

		public unsafe FTSizeRequestRec(FTSizeRequestType type = default, int width = default, int height = default, uint horiResolution = default, uint vertResolution = default)
		{
			Type = type;
			Width = width;
			Height = height;
			HoriResolution = horiResolution;
			VertResolution = vertResolution;
		}


	}

}
