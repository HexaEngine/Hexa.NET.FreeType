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
using System.Runtime.InteropServices;
using HexaGen.Runtime;

namespace Hexa.NET.FreeType
{
	/// <summary>
	/// ************************************************************************<br/>
	/// <br/>
	/// :<br/>
	/// FT_SvgGlyph<br/>
	/// <br/>
	/// :<br/>
	/// A handle to an object used to model an SVG glyph.  This is a<br/>
	/// 'sub-class' of <br/>
	/// _Glyph, and a pointer to <br/>
	/// _SvgGlyphRec.<br/>
	/// <br/>
	/// </summary>
	[NativeName(NativeNameType.Typedef, "FT_SvgGlyph")]
	#if NET5_0_OR_GREATER
	[DebuggerDisplay("{DebuggerDisplay,nq}")]
	#endif
	public readonly partial struct FTSvgGlyph : IEquatable<FTSvgGlyph>
	{
		public FTSvgGlyph(nint handle) { Handle = handle; }
		public nint Handle { get; }
		public bool IsNull => Handle == 0;
		public static FTSvgGlyph Null => new FTSvgGlyph(0);
		public static implicit operator FTSvgGlyph(nint handle) => new FTSvgGlyph(handle);
		public static bool operator ==(FTSvgGlyph left, FTSvgGlyph right) => left.Handle == right.Handle;
		public static bool operator !=(FTSvgGlyph left, FTSvgGlyph right) => left.Handle != right.Handle;
		public static bool operator ==(FTSvgGlyph left, nint right) => left.Handle == right;
		public static bool operator !=(FTSvgGlyph left, nint right) => left.Handle != right;
		public bool Equals(FTSvgGlyph other) => Handle == other.Handle;
		/// <inheritdoc/>
		public override bool Equals(object obj) => obj is FTSvgGlyph handle && Equals(handle);
		/// <inheritdoc/>
		public override int GetHashCode() => Handle.GetHashCode();
		#if NET5_0_OR_GREATER
		private string DebuggerDisplay => string.Format("FTSvgGlyph [0x{0}]", Handle.ToString("X"));
		#endif
	}
}
