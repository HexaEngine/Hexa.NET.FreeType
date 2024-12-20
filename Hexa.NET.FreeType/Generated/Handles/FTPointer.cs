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
	/// FT_Pointer<br/>
	/// <br/>
	/// :<br/>
	/// A simple typedef for a typeless pointer.<br/>
	/// </summary>
	[NativeName(NativeNameType.Typedef, "FT_Pointer")]
	#if NET5_0_OR_GREATER
	[DebuggerDisplay("{DebuggerDisplay,nq}")]
	#endif
	public readonly partial struct FTPointer : IEquatable<FTPointer>
	{
		public FTPointer(nint handle) { Handle = handle; }
		public nint Handle { get; }
		public bool IsNull => Handle == 0;
		public static FTPointer Null => new FTPointer(0);
		public static implicit operator FTPointer(nint handle) => new FTPointer(handle);
		public static bool operator ==(FTPointer left, FTPointer right) => left.Handle == right.Handle;
		public static bool operator !=(FTPointer left, FTPointer right) => left.Handle != right.Handle;
		public static bool operator ==(FTPointer left, nint right) => left.Handle == right;
		public static bool operator !=(FTPointer left, nint right) => left.Handle != right;
		public bool Equals(FTPointer other) => Handle == other.Handle;
		/// <inheritdoc/>
		public override bool Equals(object obj) => obj is FTPointer handle && Equals(handle);
		/// <inheritdoc/>
		public override int GetHashCode() => Handle.GetHashCode();
		#if NET5_0_OR_GREATER
		private string DebuggerDisplay => string.Format("FTPointer [0x{0}]", Handle.ToString("X"));
		#endif
	}
}
