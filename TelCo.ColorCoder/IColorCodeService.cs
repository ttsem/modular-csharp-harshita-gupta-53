namespace TelCo.ColorCoder
{
    public interface IColorCodeService
    {
        ColorPair GetColorFromPairNumber(int pairNumber);
        int GetPairNumberFromColor(ColorPair pair);
    }
}
