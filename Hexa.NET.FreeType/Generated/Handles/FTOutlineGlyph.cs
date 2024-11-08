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
	/// FT_OutlineGlyph<br/>
	/// <br/>
	/// :<br/>
	/// A handle to an object used to model an outline glyph image.  This is a<br/>
	/// 'sub-class' of <br/>
	/// _Glyph, and a pointer to <br/>
	/// _OutlineGlyphRec.<br/>
	/// </summary>
	[NativeName(NativeNameType.Typedef, "FT_OutlineGlyph")]
	#if NET5_0_OR_GREATER
	[DebuggerDisplay("{DebuggerDisplay,nq}")]
	#endif
	public readonly partial struct FTOutlineGlyph : IEquatable<FTOutlineGlyph>
	{
		public FTOutlineGlyph(nint handle) { Handle = handle; }
		public nint Handle { get; }
		public bool IsNull => Handle == 0;
		public static FTOutlineGlyph Null => new FTOutlineGlyph(0);
		public static implicit operator FTOutlineGlyph(nint handle) => new FTOutlineGlyph(handle);
		public static bool operator ==(FTOutlineGlyph left, FTOutlineGlyph right) => left.Handle == right.Handle;
		public static bool operator !=(FTOutlineGlyph left, FTOutlineGlyph right) => left.Handle != right.Handle;
		public static bool operator ==(FTOutlineGlyph left, nint right) => left.Handle == right;
		public static bool operator !=(FTOutlineGlyph left, nint right) => left.Handle != right;
		public bool Equals(FTOutlineGlyph other) => Handle == other.Handle;
		/// <inheritdoc/>
		public override bool Equals(object obj) => obj is FTOutlineGlyph handle && Equals(handle);
		/// <inheritdoc/>
		public override int GetHashCode() => Handle.GetHashCode();
		#if NET5_0_OR_GREATER
		private string DebuggerDisplay => string.Format("FTOutlineGlyph [0x{0}]", Handle.ToString("X"));
		#endif
	}
}
