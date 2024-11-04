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
	/// TT_Header<br/>
	/// <br/>
	/// :<br/>
	/// A structure to model a TrueType font header table.  All fields follow<br/>
	/// the OpenType specification.  The 64-bit timestamps are stored in<br/>
	/// two-element arrays `Created` and `Modified`, first the upper then<br/>
	/// the lower 32~bits.<br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "TT_Header_")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct TTHeader
	{
		[NativeName(NativeNameType.Field, "Table_Version")]
		[NativeName(NativeNameType.Type, "FT_Fixed")]
		public int TableVersion;
		[NativeName(NativeNameType.Field, "Font_Revision")]
		[NativeName(NativeNameType.Type, "FT_Fixed")]
		public int FontRevision;
		[NativeName(NativeNameType.Field, "CheckSum_Adjust")]
		[NativeName(NativeNameType.Type, "FT_Long")]
		public int CheckSumAdjust;
		[NativeName(NativeNameType.Field, "Magic_Number")]
		[NativeName(NativeNameType.Type, "FT_Long")]
		public int MagicNumber;
		[NativeName(NativeNameType.Field, "Flags")]
		[NativeName(NativeNameType.Type, "FT_UShort")]
		public ushort Flags;
		[NativeName(NativeNameType.Field, "Units_Per_EM")]
		[NativeName(NativeNameType.Type, "FT_UShort")]
		public ushort UnitsPerEM;
		[NativeName(NativeNameType.Field, "Created")]
		[NativeName(NativeNameType.Type, "FT_ULong[2]")]
		public uint Created_0;
		public uint Created_1;
		[NativeName(NativeNameType.Field, "Modified")]
		[NativeName(NativeNameType.Type, "FT_ULong[2]")]
		public uint Modified_0;
		public uint Modified_1;
		[NativeName(NativeNameType.Field, "xMin")]
		[NativeName(NativeNameType.Type, "FT_Short")]
		public short XMin;
		[NativeName(NativeNameType.Field, "yMin")]
		[NativeName(NativeNameType.Type, "FT_Short")]
		public short YMin;
		[NativeName(NativeNameType.Field, "xMax")]
		[NativeName(NativeNameType.Type, "FT_Short")]
		public short XMax;
		[NativeName(NativeNameType.Field, "yMax")]
		[NativeName(NativeNameType.Type, "FT_Short")]
		public short YMax;
		[NativeName(NativeNameType.Field, "Mac_Style")]
		[NativeName(NativeNameType.Type, "FT_UShort")]
		public ushort MacStyle;
		[NativeName(NativeNameType.Field, "Lowest_Rec_PPEM")]
		[NativeName(NativeNameType.Type, "FT_UShort")]
		public ushort LowestRecPPEM;
		[NativeName(NativeNameType.Field, "Font_Direction")]
		[NativeName(NativeNameType.Type, "FT_Short")]
		public short FontDirection;
		[NativeName(NativeNameType.Field, "Index_To_Loc_Format")]
		[NativeName(NativeNameType.Type, "FT_Short")]
		public short IndexToLocFormat;
		[NativeName(NativeNameType.Field, "Glyph_Data_Format")]
		[NativeName(NativeNameType.Type, "FT_Short")]
		public short GlyphDataFormat;

		public unsafe TTHeader(int tableVersion = default, int fontRevision = default, int checksumAdjust = default, int magicNumber = default, ushort flags = default, ushort unitsPerEm = default, uint* created = default, uint* modified = default, short xMin = default, short yMin = default, short xMax = default, short yMax = default, ushort macStyle = default, ushort lowestRecPpem = default, short fontDirection = default, short indexToLocFormat = default, short glyphDataFormat = default)
		{
			TableVersion = tableVersion;
			FontRevision = fontRevision;
			CheckSumAdjust = checksumAdjust;
			MagicNumber = magicNumber;
			Flags = flags;
			UnitsPerEM = unitsPerEm;
			if (created != default(uint*))
			{
				Created_0 = created[0];
				Created_1 = created[1];
			}
			if (modified != default(uint*))
			{
				Modified_0 = modified[0];
				Modified_1 = modified[1];
			}
			XMin = xMin;
			YMin = yMin;
			XMax = xMax;
			YMax = yMax;
			MacStyle = macStyle;
			LowestRecPPEM = lowestRecPpem;
			FontDirection = fontDirection;
			IndexToLocFormat = indexToLocFormat;
			GlyphDataFormat = glyphDataFormat;
		}

		public unsafe TTHeader(int tableVersion = default, int fontRevision = default, int checksumAdjust = default, int magicNumber = default, ushort flags = default, ushort unitsPerEm = default, Span<uint> created = default, Span<uint> modified = default, short xMin = default, short yMin = default, short xMax = default, short yMax = default, ushort macStyle = default, ushort lowestRecPpem = default, short fontDirection = default, short indexToLocFormat = default, short glyphDataFormat = default)
		{
			TableVersion = tableVersion;
			FontRevision = fontRevision;
			CheckSumAdjust = checksumAdjust;
			MagicNumber = magicNumber;
			Flags = flags;
			UnitsPerEM = unitsPerEm;
			if (created != default(Span<uint>))
			{
				Created_0 = created[0];
				Created_1 = created[1];
			}
			if (modified != default(Span<uint>))
			{
				Modified_0 = modified[0];
				Modified_1 = modified[1];
			}
			XMin = xMin;
			YMin = yMin;
			XMax = xMax;
			YMax = yMax;
			MacStyle = macStyle;
			LowestRecPPEM = lowestRecPpem;
			FontDirection = fontDirection;
			IndexToLocFormat = indexToLocFormat;
			GlyphDataFormat = glyphDataFormat;
		}


	}

}
