using System;
using System.Diagnostics;
using System.Drawing;

namespace TelCo.ColorCoder
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new ColorCodeService(new ColorMap());

            var pair = service.GetColorFromPairNumber(4);
            Console.WriteLine(pair);
            Debug.Assert(pair.MajorColor == Color.White);
            Debug.Assert(pair.MinorColor == Color.Brown);

            var testPair = new ColorPair
            {
                MajorColor = Color.Yellow,
                MinorColor = Color.Green
            };

            int number = service.GetPairNumberFromColor(testPair);
            Console.WriteLine(number);
            Debug.Assert(number == 18);
        }
    }
}
