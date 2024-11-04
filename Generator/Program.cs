using HexaGen.Core.Mapping;
using HexaGen;
using System.Text.RegularExpressions;
using System.Text;

{
    var files = Directory.GetFiles("include", "", SearchOption.AllDirectories);
    Regex regex = new("^#include <freetype/(.*)>", RegexOptions.IgnoreCase | RegexOptions.Compiled | RegexOptions.Multiline);

    foreach (var file in files)
    {
        var content = File.ReadAllText(file);
        StringBuilder sb = new(content);
        content = sb.Replace("<ft2build.h>", "\"ft2build.h\"").ToString();
        int offset = 0;
        foreach (Match match in regex.Matches(content))
        {
            sb.Remove(match.Index + offset, match.Length);
            string replacement = $"#include \"freetype/{match.Groups[1].Value}\"";
            sb.Insert(match.Index + offset, replacement);
            offset += replacement.Length - match.Length;
        }
        File.WriteAllText(file, sb.ToString());
    }
}

{
    var file = "include/freetype/config/ftheader.h";
    Regex regex = new("<(.*)>", RegexOptions.IgnoreCase | RegexOptions.Compiled | RegexOptions.Multiline);

    var content = File.ReadAllText(file);
    StringBuilder sb = new(content);
    int offset = 0;
    foreach (Match match in regex.Matches(content))
    {
        sb.Remove(match.Index + offset, match.Length);
        string replacement = $"\"{match.Groups[1].Value}\"";
        sb.Insert(match.Index + offset, replacement);
        offset += replacement.Length - match.Length;
    }
    File.WriteAllText(file, sb.ToString());
}
CsCodeGeneratorConfig settings = CsCodeGeneratorConfig.Load("generator.json");

EnumMapping enumMappingFTGlyphFormat = new("FT_Glyph_Format_", null, null);
enumMappingFTGlyphFormat.ItemMappings.Add(new("FT_GLYPH_FORMAT_NONE", null, null, "0"));
enumMappingFTGlyphFormat.ItemMappings.Add(new("FT_GLYPH_FORMAT_COMPOSITE", null, null, "1668246896"));
enumMappingFTGlyphFormat.ItemMappings.Add(new("FT_GLYPH_FORMAT_BITMAP", null, null, "1651078259"));
enumMappingFTGlyphFormat.ItemMappings.Add(new("FT_GLYPH_FORMAT_OUTLINE", null, null, "186998492"));
enumMappingFTGlyphFormat.ItemMappings.Add(new("FT_GLYPH_FORMAT_PLOTTER", null, null, "1886154612"));
enumMappingFTGlyphFormat.ItemMappings.Add(new("FT_GLYPH_FORMAT_SVG", null, null, "1398163232"));

settings.EnumMappings.Add(enumMappingFTGlyphFormat);

EnumMapping enumMappingFTEncoding = new("FT_Encoding_", null, null);
enumMappingFTEncoding.ItemMappings.Add(new("FT_ENCODING_NONE", null, null, "0"));
enumMappingFTEncoding.ItemMappings.Add(new("FT_ENCODING_MS_SYMBOL", null, null, "1937337698"));
enumMappingFTEncoding.ItemMappings.Add(new("FT_ENCODING_UNICODE", null, null, "1970170211"));
enumMappingFTEncoding.ItemMappings.Add(new("FT_ENCODING_SJIS", null, null, "1936353651"));
enumMappingFTEncoding.ItemMappings.Add(new("FT_ENCODING_PRC", null, null, "1734484000"));
enumMappingFTEncoding.ItemMappings.Add(new("FT_ENCODING_BIG5", null, null, "1651074869"));
enumMappingFTEncoding.ItemMappings.Add(new("FT_ENCODING_WANSUNG", null, null, "2002873971"));
enumMappingFTEncoding.ItemMappings.Add(new("FT_ENCODING_JOHAB", null, null, "1785686113"));

enumMappingFTEncoding.ItemMappings.Add(new("FT_ENCODING_ADOBE_STANDARD", null, null, "1094995778"));
enumMappingFTEncoding.ItemMappings.Add(new("FT_ENCODING_ADOBE_EXPERT", null, null, "1094992453"));
enumMappingFTEncoding.ItemMappings.Add(new("FT_ENCODING_ADOBE_CUSTOM", null, null, "1094992451"));
enumMappingFTEncoding.ItemMappings.Add(new("FT_ENCODING_ADOBE_LATIN_1", null, null, "1818326065"));
enumMappingFTEncoding.ItemMappings.Add(new("FT_ENCODING_OLD_LATIN_2", null, null, "1818326066"));
enumMappingFTEncoding.ItemMappings.Add(new("FT_ENCODING_APPLE_ROMAN", null, null, "1634889070"));

settings.EnumMappings.Add(enumMappingFTEncoding);

string headerFile = "include/main.h";

CsCodeGenerator generator = new(settings);
generator.LogToConsole();
generator.Generate(headerFile, "../../../../Hexa.NET.FreeType/Generated");