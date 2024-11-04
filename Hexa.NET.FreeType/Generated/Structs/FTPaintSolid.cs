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
	/// FT_PaintSolid<br/>
	/// <br/>
	/// :<br/>
	/// A structure representing a `PaintSolid` value of the 'COLR' v1<br/>
	/// extensions, see 'https://github.com/googlefonts/colr-gradients-spec'.<br/>
	/// Using a `PaintSolid` value means that the glyph layer filled with<br/>
	/// this paint is solid-colored and does not contain a gradient.<br/>
	/// <br/>
	/// :<br/>
	/// color ::<br/>
	/// The color information for this solid paint, see <br/>
	/// _ColorIndex.<br/>
	/// <br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "FT_PaintSolid_")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct FTPaintSolid
	{
		[NativeName(NativeNameType.Field, "color")]
		[NativeName(NativeNameType.Type, "FT_ColorIndex")]
		public FTColorIndex Color;

		public unsafe FTPaintSolid(FTColorIndex color = default)
		{
			Color = color;
		}


	}

}
