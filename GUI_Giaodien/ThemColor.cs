using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Giaodien
{
    public class ThemColor
    {
        public static List<string> colorList = new List<string>()
        {
            "#00FFFF",
            "#66FFCC",
            "#00FF99",
            "#CC99FF",
            "#FF9966",
            "#00AA00",
            "#F5A89A",
            "#F3C246",
            "#00B2BF",
            "#8C63A4",
            "#E8D3E3"
        };

        public static Color ChangcolorBrightness(Color color, double corection)
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;
            if (corection < 0)
            {
                corection = 1 + corection;
                red *= corection;
                green *= corection;
                blue *= corection;
            }
            else
            {
                red = (255 - red) * corection + red;
                green = (255 - green) * corection + green;
                blue = (255 - blue) * corection + blue;
            }

            return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);
        }
    }
}
