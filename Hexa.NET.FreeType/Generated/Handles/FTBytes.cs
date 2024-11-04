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
	/// FT_Bytes<br/>
	/// <br/>
	/// :<br/>
	/// A typedef for constant memory areas.<br/>
	/// </summary>
	[NativeName(NativeNameType.Typedef, "FT_Bytes")]
	#if NET5_0_OR_GREATER
	[DebuggerDisplay("{DebuggerDisplay,nq}")]
	#endif
	public readonly partial struct FTBytes : IEquatable<FTBytes>
	{
		public FTBytes(nint handle) { Handle = handle; }
		public nint Handle { get; }
		public bool IsNull => Handle == 0;
		public static FTBytes Null => new FTBytes(0);
		public static implicit operator FTBytes(nint handle) => new FTBytes(handle);
		public static bool operator ==(FTBytes left, FTBytes right) => left.Handle == right.Handle;
		public static bool operator !=(FTBytes left, FTBytes right) => left.Handle != right.Handle;
		public static bool operator ==(FTBytes left, nint right) => left.Handle == right;
		public static bool operator !=(FTBytes left, nint right) => left.Handle != right;
		public bool Equals(FTBytes other) => Handle == other.Handle;
		/// <inheritdoc/>
		public override bool Equals(object obj) => obj is FTBytes handle && Equals(handle);
		/// <inheritdoc/>
		public override int GetHashCode() => Handle.GetHashCode();
		#if NET5_0_OR_GREATER
		private string DebuggerDisplay => string.Format("FTBytes [0x{0}]", Handle.ToString("X"));
		#endif
	}
}
