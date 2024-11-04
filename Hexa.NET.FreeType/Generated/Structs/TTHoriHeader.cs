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
	/// TT_HoriHeader<br/>
	/// <br/>
	/// :<br/>
	/// A structure to model a TrueType horizontal header, the 'hhea' table,<br/>
	/// as well as the corresponding horizontal metrics table, 'hmtx'.<br/>
	/// <br/>
	/// :<br/>
	/// Version ::<br/>
	/// The table version.<br/>
	/// Ascender ::<br/>
	/// The font's ascender, i.e., the distance from the baseline to the<br/>
	/// top-most of all glyph points found in the font.<br/>
	/// This value is invalid in many fonts, as it is usually set by the<br/>
	/// font designer, and often reflects only a portion of the glyphs found<br/>
	/// in the font (maybe ASCII).<br/>
	/// You should use the `sTypoAscender` field of the 'OS/2' table instead<br/>
	/// if you want the correct one.<br/>
	/// Descender ::<br/>
	/// The font's descender, i.e., the distance from the baseline to the<br/>
	/// bottom-most of all glyph points found in the font.  It is negative.<br/>
	/// This value is invalid in many fonts, as it is usually set by the<br/>
	/// font designer, and often reflects only a portion of the glyphs found<br/>
	/// in the font (maybe ASCII).<br/>
	/// You should use the `sTypoDescender` field of the 'OS/2' table<br/>
	/// instead if you want the correct one.<br/>
	/// Line_Gap ::<br/>
	/// The font's line gap, i.e., the distance to add to the ascender and<br/>
	/// descender to get the BTB, i.e., the baseline-to-baseline distance<br/>
	/// for the font.<br/>
	/// advance_Width_Max ::<br/>
	/// This field is the maximum of all advance widths found in the font.<br/>
	/// It can be used to compute the maximum width of an arbitrary string<br/>
	/// of text.<br/>
	/// min_Left_Side_Bearing ::<br/>
	/// The minimum left side bearing of all glyphs within the font.<br/>
	/// min_Right_Side_Bearing ::<br/>
	/// The minimum right side bearing of all glyphs within the font.<br/>
	/// xMax_Extent ::<br/>
	/// The maximum horizontal extent (i.e., the 'width' of a glyph's<br/>
	/// bounding box) for all glyphs in the font.<br/>
	/// caret_Slope_Rise ::<br/>
	/// The rise coefficient of the cursor's slope of the cursor<br/>
	/// (slope=rise/run).<br/>
	/// caret_Slope_Run ::<br/>
	/// The run coefficient of the cursor's slope.<br/>
	/// caret_Offset ::<br/>
	/// The cursor's offset for slanted fonts.<br/>
	/// Reserved ::<br/>
	/// 8~reserved bytes.<br/>
	/// metric_Data_Format ::<br/>
	/// Always~0.<br/>
	/// number_Of_HMetrics ::<br/>
	/// Number of HMetrics entries in the 'hmtx' table -- this value can be<br/>
	/// smaller than the total number of glyphs in the font.<br/>
	/// long_metrics ::<br/>
	/// A pointer into the 'hmtx' table.<br/>
	/// short_metrics ::<br/>
	/// A pointer into the 'hmtx' table.<br/>
	/// <br/>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "TT_HoriHeader_")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct TTHoriHeader
	{
		[NativeName(NativeNameType.Field, "Version")]
		[NativeName(NativeNameType.Type, "FT_Fixed")]
		public int Version;
		[NativeName(NativeNameType.Field, "Ascender")]
		[NativeName(NativeNameType.Type, "FT_Short")]
		public short Ascender;
		[NativeName(NativeNameType.Field, "Descender")]
		[NativeName(NativeNameType.Type, "FT_Short")]
		public short Descender;
		[NativeName(NativeNameType.Field, "Line_Gap")]
		[NativeName(NativeNameType.Type, "FT_Short")]
		public short LineGap;
		/// <summary>
		/// advance width maximum <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "advance_Width_Max")]
		[NativeName(NativeNameType.Type, "FT_UShort")]
		public ushort AdvanceWidthMax;

		/// <summary>
		/// minimum left-sb       <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "min_Left_Side_Bearing")]
		[NativeName(NativeNameType.Type, "FT_Short")]
		public short MinLeftSideBearing;

		/// <summary>
		/// minimum right-sb      <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "min_Right_Side_Bearing")]
		[NativeName(NativeNameType.Type, "FT_Short")]
		public short MinRightSideBearing;

		/// <summary>
		/// xmax extents          <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "xMax_Extent")]
		[NativeName(NativeNameType.Type, "FT_Short")]
		public short XMaxExtent;

		[NativeName(NativeNameType.Field, "caret_Slope_Rise")]
		[NativeName(NativeNameType.Type, "FT_Short")]
		public short CaretSlopeRise;
		[NativeName(NativeNameType.Field, "caret_Slope_Run")]
		[NativeName(NativeNameType.Type, "FT_Short")]
		public short CaretSlopeRun;
		[NativeName(NativeNameType.Field, "caret_Offset")]
		[NativeName(NativeNameType.Type, "FT_Short")]
		public short CaretOffset;
		[NativeName(NativeNameType.Field, "Reserved")]
		[NativeName(NativeNameType.Type, "FT_Short[4]")]
		public short Reserved_0;
		public short Reserved_1;
		public short Reserved_2;
		public short Reserved_3;
		[NativeName(NativeNameType.Field, "metric_Data_Format")]
		[NativeName(NativeNameType.Type, "FT_Short")]
		public short MetricDataFormat;
		[NativeName(NativeNameType.Field, "number_Of_HMetrics")]
		[NativeName(NativeNameType.Type, "FT_UShort")]
		public ushort NumberOfHMetrics;
		/// <summary>
		/// The following fields are not defined by the OpenType specification <br/>
		/// but they are used to connect the metrics header to the relevant    <br/>
		/// 'hmtx' table.                                                      <br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "long_metrics")]
		[NativeName(NativeNameType.Type, "void *")]
		public unsafe void* LongMetrics;

		[NativeName(NativeNameType.Field, "short_metrics")]
		[NativeName(NativeNameType.Type, "void *")]
		public unsafe void* ShortMetrics;

		public unsafe TTHoriHeader(int version = default, short ascender = default, short descender = default, short lineGap = default, ushort advanceWidthMax = default, short minLeftSideBearing = default, short minRightSideBearing = default, short xmaxExtent = default, short caretSlopeRise = default, short caretSlopeRun = default, short caretOffset = default, short* reserved = default, short metricDataFormat = default, ushort numberOfHmetrics = default, void* longMetrics = default, void* shortMetrics = default)
		{
			Version = version;
			Ascender = ascender;
			Descender = descender;
			LineGap = lineGap;
			AdvanceWidthMax = advanceWidthMax;
			MinLeftSideBearing = minLeftSideBearing;
			MinRightSideBearing = minRightSideBearing;
			XMaxExtent = xmaxExtent;
			CaretSlopeRise = caretSlopeRise;
			CaretSlopeRun = caretSlopeRun;
			CaretOffset = caretOffset;
			if (reserved != default(short*))
			{
				Reserved_0 = reserved[0];
				Reserved_1 = reserved[1];
				Reserved_2 = reserved[2];
				Reserved_3 = reserved[3];
			}
			MetricDataFormat = metricDataFormat;
			NumberOfHMetrics = numberOfHmetrics;
			LongMetrics = longMetrics;
			ShortMetrics = shortMetrics;
		}

		public unsafe TTHoriHeader(int version = default, short ascender = default, short descender = default, short lineGap = default, ushort advanceWidthMax = default, short minLeftSideBearing = default, short minRightSideBearing = default, short xmaxExtent = default, short caretSlopeRise = default, short caretSlopeRun = default, short caretOffset = default, Span<short> reserved = default, short metricDataFormat = default, ushort numberOfHmetrics = default, void* longMetrics = default, void* shortMetrics = default)
		{
			Version = version;
			Ascender = ascender;
			Descender = descender;
			LineGap = lineGap;
			AdvanceWidthMax = advanceWidthMax;
			MinLeftSideBearing = minLeftSideBearing;
			MinRightSideBearing = minRightSideBearing;
			XMaxExtent = xmaxExtent;
			CaretSlopeRise = caretSlopeRise;
			CaretSlopeRun = caretSlopeRun;
			CaretOffset = caretOffset;
			if (reserved != default(Span<short>))
			{
				Reserved_0 = reserved[0];
				Reserved_1 = reserved[1];
				Reserved_2 = reserved[2];
				Reserved_3 = reserved[3];
			}
			MetricDataFormat = metricDataFormat;
			NumberOfHMetrics = numberOfHmetrics;
			LongMetrics = longMetrics;
			ShortMetrics = shortMetrics;
		}


	}

}
