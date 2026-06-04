using System.Drawing;

namespace TelCo.ColorCoder
{
    public class ColorMap
    {
        public Color[] MajorColors { get; } =
        {
            Color.White, Color.Red, Color.Black, Color.Yellow, Color.Violet
        };

        public Color[] MinorColors { get; } =
        {
            Color.Blue, Color.Orange, Color.Green, Color.Brown, Color.SlateGray
        };
    }
}
``
