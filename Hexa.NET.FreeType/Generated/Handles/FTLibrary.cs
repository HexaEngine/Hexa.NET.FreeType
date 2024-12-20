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
	/// FT_Library<br/>
	/// <br/>
	/// :<br/>
	/// A handle to a FreeType library instance.  Each 'library' is completely<br/>
	/// independent from the others; it is the 'root' of a set of objects like<br/>
	/// fonts, faces, sizes, etc.<br/>
	/// It also embeds a memory manager (see <br/>
	/// _Memory), as well as a<br/>
	/// scan-line converter object (see <br/>
	/// _Raster).<br/>
	/// [Since 2.5.6] In multi-threaded applications it is easiest to use one<br/>
	/// `FT_Library` object per thread.  In case this is too cumbersome, a<br/>
	/// single `FT_Library` object across threads is possible also, as long as<br/>
	/// a mutex lock is used around <br/>
	/// _New_Face and <br/>
	/// _Done_Face.<br/>
	/// <br/>
	/// </summary>
	[NativeName(NativeNameType.Typedef, "FT_Library")]
	#if NET5_0_OR_GREATER
	[DebuggerDisplay("{DebuggerDisplay,nq}")]
	#endif
	public readonly partial struct FTLibrary : IEquatable<FTLibrary>
	{
		public FTLibrary(nint handle) { Handle = handle; }
		public nint Handle { get; }
		public bool IsNull => Handle == 0;
		public static FTLibrary Null => new FTLibrary(0);
		public static implicit operator FTLibrary(nint handle) => new FTLibrary(handle);
		public static bool operator ==(FTLibrary left, FTLibrary right) => left.Handle == right.Handle;
		public static bool operator !=(FTLibrary left, FTLibrary right) => left.Handle != right.Handle;
		public static bool operator ==(FTLibrary left, nint right) => left.Handle == right;
		public static bool operator !=(FTLibrary left, nint right) => left.Handle != right;
		public bool Equals(FTLibrary other) => Handle == other.Handle;
		/// <inheritdoc/>
		public override bool Equals(object obj) => obj is FTLibrary handle && Equals(handle);
		/// <inheritdoc/>
		public override int GetHashCode() => Handle.GetHashCode();
		#if NET5_0_OR_GREATER
		private string DebuggerDisplay => string.Format("FTLibrary [0x{0}]", Handle.ToString("X"));
		#endif
	}
}
