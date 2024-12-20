// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using HexaGen.Runtime;

namespace Hexa.NET.FreeType
{
	public unsafe partial class FreeType
	{
		internal static FunctionTable funcTable;

		/// <summary>
		/// Initializes the function table, automatically called. Do not call manually, only after <see cref="FreeApi"/>.
		/// </summary>
		public static void InitApi()
		{
			funcTable = new FunctionTable(LibraryLoader.LoadLibrary(GetLibraryName, null), 129);
			funcTable.Load(0, "FT_Error_String");
			funcTable.Load(1, "FT_Init_FreeType");
			funcTable.Load(2, "FT_Done_FreeType");
			funcTable.Load(3, "FT_New_Face");
			funcTable.Load(4, "FT_New_Memory_Face");
			funcTable.Load(5, "FT_Open_Face");
			funcTable.Load(6, "FT_Attach_File");
			funcTable.Load(7, "FT_Attach_Stream");
			funcTable.Load(8, "FT_Reference_Face");
			funcTable.Load(9, "FT_Done_Face");
			funcTable.Load(10, "FT_Select_Size");
			funcTable.Load(11, "FT_Request_Size");
			funcTable.Load(12, "FT_Set_Char_Size");
			funcTable.Load(13, "FT_Set_Pixel_Sizes");
			funcTable.Load(14, "FT_Load_Glyph");
			funcTable.Load(15, "FT_Load_Char");
			funcTable.Load(16, "FT_Set_Transform");
			funcTable.Load(17, "FT_Get_Transform");
			funcTable.Load(18, "FT_Render_Glyph");
			funcTable.Load(19, "FT_Get_Kerning");
			funcTable.Load(20, "FT_Get_Track_Kerning");
			funcTable.Load(21, "FT_Select_Charmap");
			funcTable.Load(22, "FT_Set_Charmap");
			funcTable.Load(23, "FT_Get_Charmap_Index");
			funcTable.Load(24, "FT_Get_Char_Index");
			funcTable.Load(25, "FT_Get_First_Char");
			funcTable.Load(26, "FT_Get_Next_Char");
			funcTable.Load(27, "FT_Face_Properties");
			funcTable.Load(28, "FT_Get_Name_Index");
			funcTable.Load(29, "FT_Get_Glyph_Name");
			funcTable.Load(30, "FT_Get_Postscript_Name");
			funcTable.Load(31, "FT_Get_SubGlyph_Info");
			funcTable.Load(32, "FT_Get_FSType_Flags");
			funcTable.Load(33, "FT_Face_GetCharVariantIndex");
			funcTable.Load(34, "FT_Face_GetCharVariantIsDefault");
			funcTable.Load(35, "FT_Face_GetVariantSelectors");
			funcTable.Load(36, "FT_Face_GetVariantsOfChar");
			funcTable.Load(37, "FT_Face_GetCharsOfVariant");
			funcTable.Load(38, "FT_MulDiv");
			funcTable.Load(39, "FT_MulFix");
			funcTable.Load(40, "FT_DivFix");
			funcTable.Load(41, "FT_RoundFix");
			funcTable.Load(42, "FT_CeilFix");
			funcTable.Load(43, "FT_FloorFix");
			funcTable.Load(44, "FT_Vector_Transform");
			funcTable.Load(45, "FT_Library_Version");
			funcTable.Load(46, "FT_Face_CheckTrueTypePatents");
			funcTable.Load(47, "FT_Face_SetUnpatentedHinting");
			funcTable.Load(48, "FT_New_Glyph");
			funcTable.Load(49, "FT_Get_Glyph");
			funcTable.Load(50, "FT_Glyph_Copy");
			funcTable.Load(51, "FT_Glyph_Transform");
			funcTable.Load(52, "FT_Glyph_Get_CBox");
			funcTable.Load(53, "FT_Glyph_To_Bitmap");
			funcTable.Load(54, "FT_Done_Glyph");
			funcTable.Load(55, "FT_Matrix_Multiply");
			funcTable.Load(56, "FT_Matrix_Invert");
			funcTable.Load(57, "FT_Outline_Decompose");
			funcTable.Load(58, "FT_Outline_New");
			funcTable.Load(59, "FT_Outline_Done");
			funcTable.Load(60, "FT_Outline_Check");
			funcTable.Load(61, "FT_Outline_Get_CBox");
			funcTable.Load(62, "FT_Outline_Translate");
			funcTable.Load(63, "FT_Outline_Copy");
			funcTable.Load(64, "FT_Outline_Transform");
			funcTable.Load(65, "FT_Outline_Embolden");
			funcTable.Load(66, "FT_Outline_EmboldenXY");
			funcTable.Load(67, "FT_Outline_Reverse");
			funcTable.Load(68, "FT_Outline_Get_Bitmap");
			funcTable.Load(69, "FT_Outline_Render");
			funcTable.Load(70, "FT_Outline_Get_Orientation");
			funcTable.Load(71, "FT_Palette_Data_Get");
			funcTable.Load(72, "FT_Palette_Select");
			funcTable.Load(73, "FT_Palette_Set_Foreground_Color");
			funcTable.Load(74, "FT_Get_Color_Glyph_Layer");
			funcTable.Load(75, "FT_Get_Color_Glyph_Paint");
			funcTable.Load(76, "FT_Get_Color_Glyph_ClipBox");
			funcTable.Load(77, "FT_Get_Paint_Layers");
			funcTable.Load(78, "FT_Get_Colorline_Stops");
			funcTable.Load(79, "FT_Get_Paint");
			funcTable.Load(80, "FT_Bitmap_Init");
			funcTable.Load(81, "FT_Bitmap_New");
			funcTable.Load(82, "FT_Bitmap_Copy");
			funcTable.Load(83, "FT_Bitmap_Embolden");
			funcTable.Load(84, "FT_Bitmap_Convert");
			funcTable.Load(85, "FT_Bitmap_Blend");
			funcTable.Load(86, "FT_GlyphSlot_Own_Bitmap");
			funcTable.Load(87, "FT_Bitmap_Done");
			funcTable.Load(88, "FT_Get_Sfnt_Table");
			funcTable.Load(89, "FT_Load_Sfnt_Table");
			funcTable.Load(90, "FT_Sfnt_Table_Info");
			funcTable.Load(91, "FT_Get_CMap_Language_ID");
			funcTable.Load(92, "FT_Get_CMap_Format");
			funcTable.Load(93, "FT_Get_Sfnt_Name_Count");
			funcTable.Load(94, "FT_Get_Sfnt_Name");
			funcTable.Load(95, "FT_Get_Sfnt_LangTag");
			funcTable.Load(96, "FT_Outline_Get_BBox");
			funcTable.Load(97, "FT_Outline_GetInsideBorder");
			funcTable.Load(98, "FT_Outline_GetOutsideBorder");
			funcTable.Load(99, "FT_Stroker_New");
			funcTable.Load(100, "FT_Stroker_Set");
			funcTable.Load(101, "FT_Stroker_Rewind");
			funcTable.Load(102, "FT_Stroker_ParseOutline");
			funcTable.Load(103, "FT_Stroker_BeginSubPath");
			funcTable.Load(104, "FT_Stroker_EndSubPath");
			funcTable.Load(105, "FT_Stroker_LineTo");
			funcTable.Load(106, "FT_Stroker_ConicTo");
			funcTable.Load(107, "FT_Stroker_CubicTo");
			funcTable.Load(108, "FT_Stroker_GetBorderCounts");
			funcTable.Load(109, "FT_Stroker_ExportBorder");
			funcTable.Load(110, "FT_Stroker_GetCounts");
			funcTable.Load(111, "FT_Stroker_Export");
			funcTable.Load(112, "FT_Stroker_Done");
			funcTable.Load(113, "FT_Glyph_Stroke");
			funcTable.Load(114, "FT_Glyph_StrokeBorder");
			funcTable.Load(115, "FT_GlyphSlot_Embolden");
			funcTable.Load(116, "FT_GlyphSlot_AdjustWeight");
			funcTable.Load(117, "FT_GlyphSlot_Oblique");
			funcTable.Load(118, "FT_GlyphSlot_Slant");
			funcTable.Load(119, "FT_Sin");
			funcTable.Load(120, "FT_Cos");
			funcTable.Load(121, "FT_Tan");
			funcTable.Load(122, "FT_Atan2");
			funcTable.Load(123, "FT_Angle_Diff");
			funcTable.Load(124, "FT_Vector_Unit");
			funcTable.Load(125, "FT_Vector_Rotate");
			funcTable.Load(126, "FT_Vector_Length");
			funcTable.Load(127, "FT_Vector_Polarize");
			funcTable.Load(128, "FT_Vector_From_Polar");
		}

		public static void FreeApi()
		{
			funcTable.Free();
		}
	}
}
