using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9Part2
{
    public static class task1
    {
        public static void task1Func(string[] args)
        {
            var colorToRGB = new Dictionary<string, (int, int, int)> {
                {"red", (255, 0, 0)},
                {"orange", (255, 165, 0)},
                {"yellow", (255, 255, 0)},
                {"green", (0, 255, 0)},
                {"blue", (0, 0, 255)},
                {"indigo", (75, 0, 130)},
                {"violet", (238, 130, 238)}
            };

            Func<string, (int, int, int)?> getRGB = (color) =>
            {
                if (colorToRGB.ContainsKey(color))
                    return colorToRGB[color];
                else
                    return null;
            };

            string[] testColors = new string[] { "red", "green", "blue", "indigo", "violet", "unknown" };

            foreach (var color in testColors)
            {
                var rgb = getRGB(color);
                if (rgb.HasValue)
                {
                    Console.WriteLine($"The RGB value of {color} is ({rgb.Value.Item1}, {rgb.Value.Item2}, {rgb.Value.Item3})");
                }
                else
                {
                    Console.WriteLine($"There's no RGB value for {color}");
                }
            }
        }
    }
}
