using System;

namespace TelCo.ColorCoder
{
    public class ColorCodeService : IColorCodeService
    {
        private readonly ColorMap _colorMap;

        public ColorCodeService(ColorMap colorMap)
        {
            _colorMap = colorMap;
        }

        public ColorPair GetColorFromPairNumber(int pairNumber)
        {
            int minorSize = _colorMap.MinorColors.Length;
            int max = minorSize * _colorMap.MajorColors.Length;

            if (pairNumber < 1 || pairNumber > max)
                throw new ArgumentOutOfRangeException(nameof(pairNumber));

            int index = pairNumber - 1;
            int majorIndex = index / minorSize;
            int minorIndex = index % minorSize;

            return new ColorPair
            {
                MajorColor = _colorMap.MajorColors[majorIndex],
                MinorColor = _colorMap.MinorColors[minorIndex]
            };
        }

        public int GetPairNumberFromColor(ColorPair pair)
        {
            int majorIndex = Array.IndexOf(_colorMap.MajorColors, pair.MajorColor);
            int minorIndex = Array.IndexOf(_colorMap.MinorColors, pair.MinorColor);

            if (majorIndex < 0 || minorIndex < 0)
                throw new ArgumentException("Invalid color");

            return (majorIndex * _colorMap.MinorColors.Length) + (minorIndex + 1);
        }
    }
}
