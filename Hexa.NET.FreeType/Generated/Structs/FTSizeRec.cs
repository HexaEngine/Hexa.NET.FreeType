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
	/// FT_SizeRec<br/>
	/// <br/>
	/// :<br/>
	/// FreeType root size class structure.  A size object models a face<br/>
	/// object at a given size.<br/>
	/// <br/>
	/// :<br/>
	/// face ::<br/>
	/// Handle to the parent face object.<br/>
	/// generic ::<br/>
	/// A typeless pointer, unused by the FreeType library or any of its<br/>
	/// drivers.  It can be used by client applications to link their own<br/>
	/// data to each size object.<br/>
	/// metrics ::<br/>
	/// Metrics for this size object.  This field is read-only.<br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "FT_SizeRec_")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct FTSizeRec
	{
		/// <summary>
		/// parent face object              <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "face")]
		[NativeName(NativeNameType.Type, "FT_FaceRec_ *")]
		public unsafe FTFaceRec* Face;

		/// <summary>
		/// generic pointer for client uses <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "generic")]
		[NativeName(NativeNameType.Type, "FT_Generic")]
		public FTGeneric Generic;

		/// <summary>
		/// size metrics                    <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "metrics")]
		[NativeName(NativeNameType.Type, "FT_Size_Metrics_")]
		public FTSizeMetrics Metrics;

		[NativeName(NativeNameType.Field, "internal")]
		[NativeName(NativeNameType.Type, "FT_Size_InternalRec_ *")]
		public unsafe FTSizeInternalRec* Internal;

		public unsafe FTSizeRec(FTFaceRec* face = default, FTGeneric generic = default, FTSizeMetrics metrics = default, FTSizeInternalRec* @internal = default)
		{
			Face = face;
			Generic = generic;
			Metrics = metrics;
			Internal = @internal;
		}


	}

}