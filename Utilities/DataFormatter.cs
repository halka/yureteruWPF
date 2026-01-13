using System;
using System.Windows.Media;

namespace YureteruWPF.Utilities;

/// <summary>
/// Data formatting utilities (ported from formatting.js)
/// </summary>
public static class DataFormatter
{
    /// <summary>
    /// Get color based on JMA (Japan Meteorological Agency) seismic intensity scale
    /// </summary>
    public static Color GetJMAColor(double value)
    {
        // Follow JMA legend strictly. Thresholds use standard measured-intensity bins:
        // 0: <0.5, 1: [0.5,1.5), 2: [1.5,2.5), 3: [2.5,3.5), 4: [3.5,4.5), 5-: [4.5,5.0), 5+: [5.0,5.5), 6-: [5.5,6.0), 6+: [6.0,6.5), 7: >=6.5
        if (value < 0.5) return Colors.White;                    // 0
        if (value < 1.5) return Colors.White;                    // 1: white
        if (value < 2.5) return Color.FromRgb(0x00, 0xD2, 0xFF); // 2: light blue
        if (value < 3.5) return Color.FromRgb(0xFA, 0xFA, 0x00); // 3: light yellow
        if (value < 4.5) return Color.FromRgb(0xFF, 0xD2, 0x00); // 4: yellow
        if (value < 5.0) return Color.FromRgb(0xFF, 0x99, 0x00); // 5-: orange
        if (value < 5.5) return Color.FromRgb(0xFF, 0x5F, 0x00); // 5+: dark orange
        if (value < 6.0) return Color.FromRgb(0xFF, 0x00, 0x00); // 6-: red
        if (value < 6.5) return Color.FromRgb(0xA5, 0x00, 0x00); // 6+: dark red
        return Color.FromRgb(0xB4, 0x00, 0x68);                  // 7: purple
    }

    /// <summary>
    /// Get color based on Gal (acceleration) value
    /// </summary>
    public static Color GetGalColor(double value)
    {
        if (value < 5.0) return Colors.Gray;
        if (value < 20.0) return Color.FromRgb(0x66, 0xcc, 0xff);
        if (value < 50.0) return Color.FromRgb(0x00, 0xff, 0x99);
        if (value < 100.0) return Color.FromRgb(0xff, 0xff, 0x00);
        if (value < 200.0) return Color.FromRgb(0xff, 0x99, 0x00);
        if (value < 400.0) return Color.FromRgb(0xff, 0x00, 0x00);
        return Color.FromRgb(0xaa, 0x00, 0x00);
    }

    /// <summary>
    /// Format date time to standard string
    /// </summary>
    public static string FormatDateTime(DateTime date)
    {
        return date.ToString("yyyy-MM-dd HH:mm:ss.fff");
    }
}
