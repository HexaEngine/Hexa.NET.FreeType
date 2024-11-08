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
	/// FT_ListNode<br/>
	/// <br/>
	/// :<br/>
	/// Many elements and objects in FreeType are listed through an <br/>
	/// _List<br/>
	/// record (see <br/>
	/// _ListRec).  As its name suggests, an FT_ListNode is a<br/>
	/// handle to a single list element.<br/>
	/// </summary>
	[NativeName(NativeNameType.Typedef, "FT_ListNode")]
	#if NET5_0_OR_GREATER
	[DebuggerDisplay("{DebuggerDisplay,nq}")]
	#endif
	public readonly partial struct FTListNode : IEquatable<FTListNode>
	{
		public FTListNode(nint handle) { Handle = handle; }
		public nint Handle { get; }
		public bool IsNull => Handle == 0;
		public static FTListNode Null => new FTListNode(0);
		public static implicit operator FTListNode(nint handle) => new FTListNode(handle);
		public static bool operator ==(FTListNode left, FTListNode right) => left.Handle == right.Handle;
		public static bool operator !=(FTListNode left, FTListNode right) => left.Handle != right.Handle;
		public static bool operator ==(FTListNode left, nint right) => left.Handle == right;
		public static bool operator !=(FTListNode left, nint right) => left.Handle != right;
		public bool Equals(FTListNode other) => Handle == other.Handle;
		/// <inheritdoc/>
		public override bool Equals(object obj) => obj is FTListNode handle && Equals(handle);
		/// <inheritdoc/>
		public override int GetHashCode() => Handle.GetHashCode();
		#if NET5_0_OR_GREATER
		private string DebuggerDisplay => string.Format("FTListNode [0x{0}]", Handle.ToString("X"));
		#endif
	}
}
