namespace OpenCharts;

/// <summary>
/// ColorEx
/// </summary>
public struct OpenColor
{
    /// <summary>
    /// Initializes a new instance of the <see cref="OpenColor"/> struct.
    /// </summary>
    /// <param name="R">The r.</param>
    /// <param name="G">The g.</param>
    /// <param name="B">The b.</param>
    public OpenColor(int R, int G, int B)
    {
        this.R = R;
        this.G = G;
        this.B = B;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="OpenColor"/> struct.
    /// </summary>
    /// <param name="R">The r.</param>
    /// <param name="G">The g.</param>
    /// <param name="B">The b.</param>
    /// <param name="A">a.</param>
    public OpenColor(int R, int G, int B, int A)
    {
        this.A = A;
        this.R = R;
        this.G = G;
        this.B = B;
    }

    /// <summary>
    /// Gets or sets a.
    /// </summary>
    /// <value>
    /// a.
    /// </value>
    public int A { get; set; }

    /// <summary>
    /// Gets or sets the r.
    /// </summary>
    /// <value>
    /// The r.
    /// </value>
    public int R { get; set; }

    /// <summary>
    /// Gets or sets the g.
    /// </summary>
    /// <value>
    /// The g.
    /// </value>
    public int G { get; set; }

    /// <summary>
    /// Gets or sets the b.
    /// </summary>
    /// <value>
    /// The b.
    /// </value>
    public int B { get; set; }

    /// <summary>
    /// #F0F8FF
    /// </summary>
    public static readonly OpenColor AliceBlue = new OpenColor(240, 248, 255);

    /// <summary>
    /// #FAEBD7 
    /// </summary>
    public static readonly OpenColor AntiqueWhite = new OpenColor(250, 235, 215);

    /// <summary>
    /// #00FFFF 
    /// </summary>
    public static readonly OpenColor Aqua = new OpenColor(0, 255, 255);

    /// <summary>
    /// #7FFFD4
    /// </summary>
    public static readonly OpenColor Aquamarine = new OpenColor(127, 255, 212);

    /// <summary>
    /// #F0FFFF
    /// </summary>
    public static readonly OpenColor Azure = new OpenColor(240, 255, 255);

    /// <summary>
    /// #F5F5DC
    /// </summary>
    public static readonly OpenColor Beige = new OpenColor(245, 245, 220);

    /// <summary>
    /// #FFE4C4
    /// </summary>
    public static readonly OpenColor Bisque = new OpenColor(255, 228, 196);

    /// <summary>
    /// #000000
    /// </summary>
    public static readonly OpenColor Black = new OpenColor(0, 0, 0);

    /// <summary>
    /// #FFEBCD
    /// </summary>
    public static readonly OpenColor BlanchedAlmond = new OpenColor(255, 235, 205);

    /// <summary>
    /// #0000FF
    /// </summary>
    public static readonly OpenColor Blue = new OpenColor(0, 0, 255);

    /// <summary>
    /// #8A2BE2
    /// </summary>
    public static readonly OpenColor BlueViolet = new OpenColor(138, 43, 226);

    /// <summary>
    /// #A52A2A 
    /// </summary>
    public static readonly OpenColor Brown = new OpenColor(165, 42, 42);

    /// <summary>
    /// #DEB887
    /// </summary>
    public static readonly OpenColor BurlyWood = new OpenColor(222, 184, 135);

    /// <summary>
    /// #5F9EA0 
    /// </summary>
    public static readonly OpenColor CadetBlue = new OpenColor(95, 158, 160);

    /// <summary>
    /// #7FFF00 
    /// </summary>
    public static readonly OpenColor Chartreuse = new OpenColor(127, 255, 0);

    /// <summary>
    /// #D2691E
    /// </summary>
    public static readonly OpenColor Chocolate = new OpenColor(210, 105, 30);

    /// <summary>
    /// #FF7F50
    /// </summary>
    public static readonly OpenColor Coral = new OpenColor(255, 127, 80);

    /// <summary>
    /// #6495ED
    /// </summary>
    public static readonly OpenColor CornflowerBlue = new OpenColor(100, 149, 237);

    /// <summary>
    /// #FFF8DC
    /// </summary>
    public static readonly OpenColor Cornsilk = new OpenColor(255, 248, 220);

    /// <summary>
    /// #DC143C
    /// </summary>
    public static readonly OpenColor Crimson = new OpenColor(220, 20, 60);

    /// <summary>
    /// #00FFFF
    /// </summary>
    public static readonly OpenColor Cyan = new OpenColor(0, 255, 255);

    /// <summary>
    /// #00008B
    /// </summary>
    public static readonly OpenColor DarkBlue = new OpenColor(0, 0, 139);

    /// <summary>
    /// #008B8B
    /// </summary>
    public static readonly OpenColor DarkCyan = new OpenColor(0, 139, 139);

    /// <summary>
    /// #B8860B
    /// </summary>
    public static readonly OpenColor DarkGoldenrod = new OpenColor(184, 134, 11);

    /// <summary>
    /// #A9A9A9
    /// </summary>
    public static readonly OpenColor DarkGray = new OpenColor(169, 169, 169);

    /// <summary>
    /// #006400
    /// </summary>
    public static readonly OpenColor DarkGreen = new OpenColor(0, 100, 0);

    /// <summary>
    /// #BDB76B
    /// </summary>
    public static readonly OpenColor DarkKhaki = new OpenColor(189, 183, 107);

    /// <summary>
    /// #8B008B
    /// </summary>
    public static readonly OpenColor DarkMagenta = new OpenColor(139, 0, 139);

    /// <summary>
    /// #556B2F
    /// </summary>
    public static readonly OpenColor DarkOliveGreen = new OpenColor(85, 107, 47);

    /// <summary>
    /// #FF8C00 
    /// </summary>
    public static readonly OpenColor DarkOrange = new OpenColor(255, 140, 0);

    /// <summary>
    /// #9932CC
    /// </summary>
    public static readonly OpenColor DarkOrchid = new OpenColor(153, 50, 204);

    /// <summary>
    /// #8B0000
    /// </summary>
    public static readonly OpenColor DarkRed = new OpenColor(139, 0, 0);

    /// <summary>
    /// #E9967A
    /// </summary>
    public static readonly OpenColor DarkSalmon = new OpenColor(233, 150, 122);

    /// <summary>
    /// #8FBC8F
    /// </summary>
    public static readonly OpenColor DarkSeaGreen = new OpenColor(143, 188, 139);

    /// <summary>
    /// #483D8B
    /// </summary>
    public static readonly OpenColor DarkSlateBlue = new OpenColor(72, 61, 139);

    /// <summary>
    /// #2F4F4F
    /// </summary>
    public static readonly OpenColor DarkSlateGray = new OpenColor(47, 79, 79);

    /// <summary>
    /// #00CED1 
    /// </summary>
    public static readonly OpenColor DarkTurquoise = new OpenColor(0, 206, 209);

    /// <summary>
    /// #9400D3
    /// </summary>
    public static readonly OpenColor DarkViolet = new OpenColor(148, 0, 211);

    /// <summary>
    /// #FF1493
    /// </summary>
    public static readonly OpenColor DeepPink = new OpenColor(255, 20, 147);

    /// <summary>
    /// #00BFFF
    /// </summary>
    public static readonly OpenColor DeepSkyBlue = new OpenColor(0, 191, 255);

    /// <summary>
    /// #696969
    /// </summary>
    public static readonly OpenColor DimGray = new OpenColor(105, 105, 105);

    /// <summary>
    /// #1E90FF
    /// </summary>
    public static readonly OpenColor DodgerBlue = new OpenColor(30, 144, 255);

    /// <summary>
    /// #B22222
    /// </summary>
    public static readonly OpenColor Firebrick = new OpenColor(178, 34, 34);

    /// <summary>
    /// #FFFAF0 
    /// </summary>
    public static readonly OpenColor FloralWhite = new OpenColor(255, 250, 240);

    /// <summary>
    /// #228B22
    /// </summary>
    public static readonly OpenColor ForestGreen = new OpenColor(34, 139, 34);

    /// <summary>
    /// #FF00FF 
    /// </summary>
    public static readonly OpenColor Fuchsia = new OpenColor(255, 0, 255);

    /// <summary>
    /// #DCDCDC
    /// </summary>
    public static readonly OpenColor Gainsboro = new OpenColor(220, 220, 220);

    /// <summary>
    /// #F8F8FF
    /// </summary>
    public static readonly OpenColor GhostWhite = new OpenColor(248, 248, 255);

    /// <summary>
    /// #FFD700
    /// </summary>
    public static readonly OpenColor Gold = new OpenColor(255, 215, 0);

    /// <summary>
    /// #DAA520
    /// </summary>
    public static readonly OpenColor Goldenrod = new OpenColor(218, 165, 32);

    /// <summary>
    /// #808080
    /// </summary>
    public static readonly OpenColor Gray = new OpenColor(128, 128, 128);

    /// <summary>
    /// #008000
    /// </summary>
    public static readonly OpenColor Green = new OpenColor(0, 128, 0);

    /// <summary>
    /// #ADFF2F
    /// </summary>
    public static readonly OpenColor GreenYellow = new OpenColor(173, 255, 47);

    /// <summary>
    /// #F0FFF0
    /// </summary>
    public static readonly OpenColor Honeydew = new OpenColor(240, 255, 240);

    /// <summary>
    /// #FF69B4
    /// </summary>
    public static readonly OpenColor HotPink = new OpenColor(255, 105, 180);

    /// <summary>
    /// #CD5C5C
    /// </summary>
    public static readonly OpenColor IndianRed = new OpenColor(205, 92, 92);

    /// <summary>
    /// #4B0082
    /// </summary>
    public static readonly OpenColor Indigo = new OpenColor(75, 0, 130);

    /// <summary>
    /// #FFFFF0
    /// </summary>
    public static readonly OpenColor Ivory = new OpenColor(255, 255, 240);

    /// <summary>
    /// #F0E68C
    /// </summary>
    public static readonly OpenColor Khaki = new OpenColor(240, 230, 140);

    /// <summary>
    /// #E6E6FA
    /// </summary>
    public static readonly OpenColor Lavender = new OpenColor(230, 230, 250);

    /// <summary>
    /// #FFF0F5 
    /// </summary>
    public static readonly OpenColor LavenderBlush = new OpenColor(255, 240, 245);

    /// <summary>
    /// #7CFC00
    /// </summary>
    public static readonly OpenColor LawnGreen = new OpenColor(124, 252, 0);

    /// <summary>
    /// #FFFACD
    /// </summary>
    public static readonly OpenColor LemonChiffon = new OpenColor(255, 250, 205);

    /// <summary>
    /// #ADD8E6
    /// </summary>
    public static readonly OpenColor LightBlue = new OpenColor(173, 216, 230);

    /// <summary>
    /// #F08080
    /// </summary>
    public static readonly OpenColor LightCoral = new OpenColor(240, 128, 128);

    /// <summary>
    /// #E0FFFF
    /// </summary>
    public static readonly OpenColor LightCyan = new OpenColor(224, 255, 255);

    /// <summary>
    /// #FAFAD2
    /// </summary>
    public static readonly OpenColor LightGoldenrodYellow = new OpenColor(250, 250, 210);

    /// <summary>
    /// #D3D3D3
    /// </summary>
    public static readonly OpenColor LightGray = new OpenColor(211, 211, 211);

    /// <summary>
    /// #90EE90 
    /// </summary>
    public static readonly OpenColor LightGreen = new OpenColor(144, 238, 144);

    /// <summary>
    /// #FFB6C1
    /// </summary>
    public static readonly OpenColor LightPink = new OpenColor(255, 182, 193);

    /// <summary>
    /// #FFA07A
    /// </summary>
    public static readonly OpenColor LightSalmon = new OpenColor(255, 160, 122);

    /// <summary>
    /// #20B2AA
    /// </summary>
    public static readonly OpenColor LightSeaGreen = new OpenColor(32, 178, 170);

    /// <summary>
    /// #87CEFA 
    /// </summary>
    public static readonly OpenColor LightSkyBlue = new OpenColor(135, 206, 250);

    /// <summary>
    /// #778899
    /// </summary>
    public static readonly OpenColor LightSlateGray = new OpenColor(119, 136, 153);

    /// <summary>
    /// #B0C4DE 
    /// </summary>
    public static readonly OpenColor LightSteelBlue = new OpenColor(176, 196, 222);

    /// <summary>
    /// #FFFFE0
    /// </summary>
    public static readonly OpenColor LightYellow = new OpenColor(255, 255, 224);

    /// <summary>
    /// #00FF00
    /// </summary>
    public static readonly OpenColor Lime = new OpenColor(0, 255, 0);

    /// <summary>
    /// #32CD32
    /// </summary>
    public static readonly OpenColor LimeGreen = new OpenColor(50, 205, 50);

    /// <summary>
    /// #FAF0E6
    /// </summary>
    public static readonly OpenColor Linen = new OpenColor(250, 240, 230);

    /// <summary>
    /// #FF00FF
    /// </summary>
    public static readonly OpenColor Magenta = new OpenColor(255, 0, 255);

    /// <summary>
    /// #800000
    /// </summary>
    public static readonly OpenColor Maroon = new OpenColor(128, 0, 0);

    /// <summary>
    /// #66CDAA
    /// </summary>
    public static readonly OpenColor MediumAquamarine = new OpenColor(102, 205, 170);

    /// <summary>
    /// #0000CD
    /// </summary>
    public static readonly OpenColor MediumBlue = new OpenColor(0, 0, 205);

    /// <summary>
    /// #BA55D3
    /// </summary>
    public static readonly OpenColor MediumOrchid = new OpenColor(186, 85, 211);

    /// <summary>
    /// #9370DB
    /// </summary>
    public static readonly OpenColor MediumPurple = new OpenColor(147, 112, 219);

    /// <summary>
    /// #3CB371
    /// </summary>
    public static readonly OpenColor MediumSeaGreen = new OpenColor(60, 179, 113);

    /// <summary>
    /// #7B68EE
    /// </summary>
    public static readonly OpenColor MediumSlateBlue = new OpenColor(123, 104, 238);

    /// <summary>
    /// #00FA9A 
    /// </summary>
    public static readonly OpenColor MediumSpringGreen = new OpenColor(0, 250, 154);

    /// <summary>
    /// #48D1CC
    /// </summary>
    public static readonly OpenColor MediumTurquoise = new OpenColor(72, 209, 204);

    /// <summary>
    /// #C71585
    /// </summary>
    public static readonly OpenColor MediumVioletRed = new OpenColor(199, 21, 133);

    /// <summary>
    /// #191970
    /// </summary>
    public static readonly OpenColor MidnightBlue = new OpenColor(25, 25, 112);

    /// <summary>
    /// #F5FFFA
    /// </summary>
    public static readonly OpenColor MintCream = new OpenColor(245, 255, 250);

    /// <summary>
    /// #FFE4E1
    /// </summary>
    public static readonly OpenColor MistyRose = new OpenColor(255, 228, 225);

    /// <summary>
    /// #FFE4B5
    /// </summary>
    public static readonly OpenColor Moccasin = new OpenColor(255, 228, 181);

    /// <summary>
    /// #FFDEAD
    /// </summary>
    public static readonly OpenColor NavajoWhite = new OpenColor(255, 222, 173);

    /// <summary>
    /// #000080
    /// </summary>
    public static readonly OpenColor Navy = new OpenColor(0, 0, 128);

    /// <summary>
    /// #FDF5E6
    /// </summary>
    public static readonly OpenColor OldLace = new OpenColor(253, 245, 230);

    /// <summary>
    /// #808000 
    /// </summary>
    public static readonly OpenColor Olive = new OpenColor(128, 128, 0);

    /// <summary>
    /// #6B8E23
    /// </summary>
    public static readonly OpenColor OliveDrab = new OpenColor(107, 142, 35);

    /// <summary>
    /// #FFA500
    /// </summary>
    public static readonly OpenColor Orange = new OpenColor(255, 165, 0);

    /// <summary>
    /// #FF4500
    /// </summary>
    public static readonly OpenColor OrangeRed = new OpenColor(255, 69, 0);

    /// <summary>
    /// #DA70D6
    /// </summary>
    public static readonly OpenColor Orchid = new OpenColor(218, 112, 214);

    /// <summary>
    /// #EEE8AA 
    /// </summary>
    public static readonly OpenColor PaleGoldenrod = new OpenColor(238, 232, 170);

    /// <summary>
    /// #98FB98
    /// </summary>
    public static readonly OpenColor PaleGreen = new OpenColor(152, 251, 152);

    /// <summary>
    /// #AFEEEE
    /// </summary>
    public static readonly OpenColor PaleTurquoise = new OpenColor(175, 238, 238);

    /// <summary>
    /// #DB7093
    /// </summary>
    public static readonly OpenColor PaleVioletRed = new OpenColor(219, 112, 147);

    /// <summary>
    /// #FFEFD5 
    /// </summary>
    public static readonly OpenColor PapayaWhip = new OpenColor(255, 239, 213);

    /// <summary>
    /// #FFDAB9
    /// </summary>
    public static readonly OpenColor PeachPuff = new OpenColor(255, 218, 185);

    /// <summary>
    /// #CD853F
    /// </summary>
    public static readonly OpenColor Peru = new OpenColor(205, 133, 63);

    /// <summary>
    /// #FFC0CB
    /// </summary>
    public static readonly OpenColor Pink = new OpenColor(255, 192, 203);

    /// <summary>
    /// #DDA0DD
    /// </summary>
    public static readonly OpenColor Plum = new OpenColor(221, 160, 221);

    /// <summary>
    /// #B0E0E6
    /// </summary>
    public static readonly OpenColor PowderBlue = new OpenColor(176, 224, 230);

    /// <summary>
    /// #800080
    /// </summary>
    public static readonly OpenColor Purple = new OpenColor(128, 0, 128);

    /// <summary>
    /// #FF0000
    /// </summary>
    public static readonly OpenColor Red = new OpenColor(255, 0, 0);

    /// <summary>
    /// #BC8F8F
    /// </summary>
    public static readonly OpenColor RosyBrown = new OpenColor(188, 143, 143);

    /// <summary>
    /// #4169E1
    /// </summary>
    public static readonly OpenColor RoyalBlue = new OpenColor(65, 105, 225);

    /// <summary>
    /// #8B4513
    /// </summary>
    public static readonly OpenColor SaddleBrown = new OpenColor(139, 69, 19);

    /// <summary>
    /// #FA8072
    /// </summary>
    public static readonly OpenColor Salmon = new OpenColor(250, 128, 114);

    /// <summary>
    /// #F4A460
    /// </summary>
    public static readonly OpenColor SandyBrown = new OpenColor(244, 164, 96);

    /// <summary>
    /// #2E8B57
    /// </summary>
    public static readonly OpenColor SeaGreen = new OpenColor(46, 139, 87);

    /// <summary>
    /// #FFF5EE
    /// </summary>
    public static readonly OpenColor SeaShell = new OpenColor(255, 245, 238);

    /// <summary>
    /// #A0522D
    /// </summary>
    public static readonly OpenColor Sienna = new OpenColor(160, 82, 45);

    /// <summary>
    /// #C0C0C0 
    /// </summary>
    public static readonly OpenColor Silver = new OpenColor(192, 192, 192);

    /// <summary>
    /// #87CEEB
    /// </summary>
    public static readonly OpenColor SkyBlue = new OpenColor(135, 206, 235);

    /// <summary>
    /// #6A5ACD
    /// </summary>
    public static readonly OpenColor SlateBlue = new OpenColor(106, 90, 205);

    /// <summary>
    /// #708090
    /// </summary>
    public static readonly OpenColor SlateGray = new OpenColor(112, 128, 144);

    /// <summary>
    /// #FFFAFA
    /// </summary>
    public static readonly OpenColor Snow = new OpenColor(255, 250, 250);

    /// <summary>
    /// #00FF7F
    /// </summary>
    public static readonly OpenColor SpringGreen = new OpenColor(0, 255, 127);

    /// <summary>
    /// #4682B4
    /// </summary>
    public static readonly OpenColor SteelBlue = new OpenColor(70, 130, 180);

    /// <summary>
    /// #D2B48C
    /// </summary>
    public static readonly OpenColor Tan = new OpenColor(210, 180, 140);

    /// <summary>
    /// #008080
    /// </summary>
    public static readonly OpenColor Teal = new OpenColor(0, 128, 128);

    /// <summary>
    /// #D8BFD8
    /// </summary>
    public static readonly OpenColor Thistle = new OpenColor(216, 191, 216);

    /// <summary>
    /// #FF6347
    /// </summary>
    public static readonly OpenColor Tomato = new OpenColor(255, 99, 71);

    /// <summary>
    /// #40E0D0
    /// </summary>
    public static readonly OpenColor Turquoise = new OpenColor(64, 224, 208);

    /// <summary>
    /// #EE82EE
    /// </summary>
    public static readonly OpenColor Violet = new OpenColor(238, 130, 238);

    /// <summary>
    /// #F5DEB3
    /// </summary>
    public static readonly OpenColor Wheat = new OpenColor(245, 222, 179);

    /// <summary>
    /// #FFFFFF
    /// </summary>
    public static readonly OpenColor White = new OpenColor(255, 255, 255);

    /// <summary>
    /// #F5F5F5
    /// </summary>
    public static readonly OpenColor WhiteSmoke = new OpenColor(245, 245, 245);

    /// <summary>
    /// #FFFF00
    /// </summary>
    public static readonly OpenColor Yellow = new OpenColor(255, 255, 0);

    /// <summary>
    /// #9ACD32
    /// </summary>
    public static readonly OpenColor YellowGreen = new OpenColor(154, 205, 50);
}
