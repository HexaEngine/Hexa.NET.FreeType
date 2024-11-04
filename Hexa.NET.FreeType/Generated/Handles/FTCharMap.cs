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
	/// FT_CharMap<br/>
	/// <br/>
	/// :<br/>
	/// A handle to a character map (usually abbreviated to 'charmap').  A<br/>
	/// charmap is used to translate character codes in a given encoding into<br/>
	/// glyph indexes for its parent's face.  Some font formats may provide<br/>
	/// several charmaps per font.<br/>
	/// Each face object owns zero or more charmaps, but only one of them can<br/>
	/// be 'active', providing the data used by <br/>
	/// _Get_Char_Index or<br/>
	/// <br/>
	/// _Load_Char.<br/>
	/// The list of available charmaps in a face is available through the<br/>
	/// `face->num_charmaps` and `face->charmaps` fields of <br/>
	/// _FaceRec.<br/>
	/// The currently active charmap is available as `face->charmap`.  You<br/>
	/// should call <br/>
	/// _Set_Charmap to change it.<br/>
	/// <br/>
	/// <br/>
	/// :<br/>
	/// See <br/>
	/// _CharMapRec for the publicly accessible fields of a given<br/>
	/// character map.<br/>
	/// </summary>
	[NativeName(NativeNameType.Typedef, "FT_CharMap")]
	#if NET5_0_OR_GREATER
	[DebuggerDisplay("{DebuggerDisplay,nq}")]
	#endif
	public readonly partial struct FTCharMap : IEquatable<FTCharMap>
	{
		public FTCharMap(nint handle) { Handle = handle; }
		public nint Handle { get; }
		public bool IsNull => Handle == 0;
		public static FTCharMap Null => new FTCharMap(0);
		public static implicit operator FTCharMap(nint handle) => new FTCharMap(handle);
		public static bool operator ==(FTCharMap left, FTCharMap right) => left.Handle == right.Handle;
		public static bool operator !=(FTCharMap left, FTCharMap right) => left.Handle != right.Handle;
		public static bool operator ==(FTCharMap left, nint right) => left.Handle == right;
		public static bool operator !=(FTCharMap left, nint right) => left.Handle != right;
		public bool Equals(FTCharMap other) => Handle == other.Handle;
		/// <inheritdoc/>
		public override bool Equals(object obj) => obj is FTCharMap handle && Equals(handle);
		/// <inheritdoc/>
		public override int GetHashCode() => Handle.GetHashCode();
		#if NET5_0_OR_GREATER
		private string DebuggerDisplay => string.Format("FTCharMap [0x{0}]", Handle.ToString("X"));
		#endif
	}
}
