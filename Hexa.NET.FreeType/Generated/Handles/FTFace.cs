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
	/// FT_Face<br/>
	/// <br/>
	/// :<br/>
	/// A handle to a typographic face object.  A face object models a given<br/>
	/// typeface, in a given style.<br/>
	/// <br/>
	/// Use <br/>
	/// _New_Face or <br/>
	/// _Open_Face to create a new face object from a<br/>
	/// given filepath or a custom input stream.<br/>
	/// Use <br/>
	/// _Done_Face to destroy it (along with its slot and sizes).<br/>
	/// An `FT_Face` object can only be safely used from one thread at a time.<br/>
	/// Similarly, creation and destruction of `FT_Face` with the same<br/>
	/// <br/>
	/// _Library object can only be done from one thread at a time.  On the<br/>
	/// other hand, functions like <br/>
	/// _Load_Glyph and its siblings are<br/>
	/// thread-safe and do not need the lock to be held as long as the same<br/>
	/// `FT_Face` object is not used from multiple threads at the same time.<br/>
	/// <br/>
	/// :<br/>
	/// See <br/>
	/// _FaceRec for the publicly accessible fields of a given face<br/>
	/// object.<br/>
	/// </summary>
	[NativeName(NativeNameType.Typedef, "FT_Face")]
	#if NET5_0_OR_GREATER
	[DebuggerDisplay("{DebuggerDisplay,nq}")]
	#endif
	public readonly partial struct FTFace : IEquatable<FTFace>
	{
		public FTFace(nint handle) { Handle = handle; }
		public nint Handle { get; }
		public bool IsNull => Handle == 0;
		public static FTFace Null => new FTFace(0);
		public static implicit operator FTFace(nint handle) => new FTFace(handle);
		public static bool operator ==(FTFace left, FTFace right) => left.Handle == right.Handle;
		public static bool operator !=(FTFace left, FTFace right) => left.Handle != right.Handle;
		public static bool operator ==(FTFace left, nint right) => left.Handle == right;
		public static bool operator !=(FTFace left, nint right) => left.Handle != right;
		public bool Equals(FTFace other) => Handle == other.Handle;
		/// <inheritdoc/>
		public override bool Equals(object obj) => obj is FTFace handle && Equals(handle);
		/// <inheritdoc/>
		public override int GetHashCode() => Handle.GetHashCode();
		#if NET5_0_OR_GREATER
		private string DebuggerDisplay => string.Format("FTFace [0x{0}]", Handle.ToString("X"));
		#endif
	}
}
