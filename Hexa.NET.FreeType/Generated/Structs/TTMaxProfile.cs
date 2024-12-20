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
	/// TT_MaxProfile<br/>
	/// <br/>
	/// :<br/>
	/// The maximum profile ('maxp') table contains many max values, which can<br/>
	/// be used to pre-allocate arrays for speeding up glyph loading and<br/>
	/// hinting.<br/>
	/// <br/>
	/// :<br/>
	/// version ::<br/>
	/// The version number.<br/>
	/// numGlyphs ::<br/>
	/// The number of glyphs in this TrueType font.<br/>
	/// maxPoints ::<br/>
	/// The maximum number of points in a non-composite TrueType glyph.  See<br/>
	/// also `maxCompositePoints`.<br/>
	/// maxContours ::<br/>
	/// The maximum number of contours in a non-composite TrueType glyph.<br/>
	/// See also `maxCompositeContours`.<br/>
	/// maxCompositePoints ::<br/>
	/// The maximum number of points in a composite TrueType glyph.  See<br/>
	/// also `maxPoints`.<br/>
	/// maxCompositeContours ::<br/>
	/// The maximum number of contours in a composite TrueType glyph.  See<br/>
	/// also `maxContours`.<br/>
	/// maxZones ::<br/>
	/// The maximum number of zones used for glyph hinting.<br/>
	/// maxTwilightPoints ::<br/>
	/// The maximum number of points in the twilight zone used for glyph<br/>
	/// hinting.<br/>
	/// maxStorage ::<br/>
	/// The maximum number of elements in the storage area used for glyph<br/>
	/// hinting.<br/>
	/// maxFunctionDefs ::<br/>
	/// The maximum number of function definitions in the TrueType bytecode<br/>
	/// for this font.<br/>
	/// maxInstructionDefs ::<br/>
	/// The maximum number of instruction definitions in the TrueType<br/>
	/// bytecode for this font.<br/>
	/// maxStackElements ::<br/>
	/// The maximum number of stack elements used during bytecode<br/>
	/// interpretation.<br/>
	/// maxSizeOfInstructions ::<br/>
	/// The maximum number of TrueType opcodes used for glyph hinting.<br/>
	/// maxComponentElements ::<br/>
	/// The maximum number of simple (i.e., non-composite) glyphs in a<br/>
	/// composite glyph.<br/>
	/// maxComponentDepth ::<br/>
	/// The maximum nesting depth of composite glyphs.<br/>
	/// <br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "TT_MaxProfile_")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct TTMaxProfile
	{
		[NativeName(NativeNameType.Field, "version")]
		[NativeName(NativeNameType.Type, "FT_Fixed")]
		public int Version;
		[NativeName(NativeNameType.Field, "numGlyphs")]
		[NativeName(NativeNameType.Type, "FT_UShort")]
		public ushort NumGlyphs;
		[NativeName(NativeNameType.Field, "maxPoints")]
		[NativeName(NativeNameType.Type, "FT_UShort")]
		public ushort MaxPoints;
		[NativeName(NativeNameType.Field, "maxContours")]
		[NativeName(NativeNameType.Type, "FT_UShort")]
		public ushort MaxContours;
		[NativeName(NativeNameType.Field, "maxCompositePoints")]
		[NativeName(NativeNameType.Type, "FT_UShort")]
		public ushort MaxCompositePoints;
		[NativeName(NativeNameType.Field, "maxCompositeContours")]
		[NativeName(NativeNameType.Type, "FT_UShort")]
		public ushort MaxCompositeContours;
		[NativeName(NativeNameType.Field, "maxZones")]
		[NativeName(NativeNameType.Type, "FT_UShort")]
		public ushort MaxZones;
		[NativeName(NativeNameType.Field, "maxTwilightPoints")]
		[NativeName(NativeNameType.Type, "FT_UShort")]
		public ushort MaxTwilightPoints;
		[NativeName(NativeNameType.Field, "maxStorage")]
		[NativeName(NativeNameType.Type, "FT_UShort")]
		public ushort MaxStorage;
		[NativeName(NativeNameType.Field, "maxFunctionDefs")]
		[NativeName(NativeNameType.Type, "FT_UShort")]
		public ushort MaxFunctionDefs;
		[NativeName(NativeNameType.Field, "maxInstructionDefs")]
		[NativeName(NativeNameType.Type, "FT_UShort")]
		public ushort MaxInstructionDefs;
		[NativeName(NativeNameType.Field, "maxStackElements")]
		[NativeName(NativeNameType.Type, "FT_UShort")]
		public ushort MaxStackElements;
		[NativeName(NativeNameType.Field, "maxSizeOfInstructions")]
		[NativeName(NativeNameType.Type, "FT_UShort")]
		public ushort MaxSizeOfInstructions;
		[NativeName(NativeNameType.Field, "maxComponentElements")]
		[NativeName(NativeNameType.Type, "FT_UShort")]
		public ushort MaxComponentElements;
		[NativeName(NativeNameType.Field, "maxComponentDepth")]
		[NativeName(NativeNameType.Type, "FT_UShort")]
		public ushort MaxComponentDepth;

		public unsafe TTMaxProfile(int version = default, ushort numGlyphs = default, ushort maxPoints = default, ushort maxContours = default, ushort maxCompositePoints = default, ushort maxCompositeContours = default, ushort maxZones = default, ushort maxTwilightPoints = default, ushort maxStorage = default, ushort maxFunctionDefs = default, ushort maxInstructionDefs = default, ushort maxStackElements = default, ushort maxSizeOfInstructions = default, ushort maxComponentElements = default, ushort maxComponentDepth = default)
		{
			Version = version;
			NumGlyphs = numGlyphs;
			MaxPoints = maxPoints;
			MaxContours = maxContours;
			MaxCompositePoints = maxCompositePoints;
			MaxCompositeContours = maxCompositeContours;
			MaxZones = maxZones;
			MaxTwilightPoints = maxTwilightPoints;
			MaxStorage = maxStorage;
			MaxFunctionDefs = maxFunctionDefs;
			MaxInstructionDefs = maxInstructionDefs;
			MaxStackElements = maxStackElements;
			MaxSizeOfInstructions = maxSizeOfInstructions;
			MaxComponentElements = maxComponentElements;
			MaxComponentDepth = maxComponentDepth;
		}


	}

}
