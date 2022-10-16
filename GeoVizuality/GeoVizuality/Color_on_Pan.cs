using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoVizuality
{
    class Color_on_Pan
    {

        //public static Color[] Colors;
 
        public Color[] GetPaletteColor(Color[] color_on_pan)
        {
            byte step = 25;
            byte r = 0, g = 0, b = 0;
            color_on_pan = new Color[48];
            for (int i = 0; i < 48; i++)
            {
                if (i == 0)
                {
                    color_on_pan[i] = Color.FromArgb(255, 0, 0, 255);
                }
                if (i > 0 && i <= 10)
                {
                    g += step;
                    r = 255;
                    color_on_pan[i] = Color.FromArgb(255, 0, g, 255);
                }
                if (i >= 10 && i <= 20)
                {
                    g = 255;
                    r = 0;
                    b -= step;
                    color_on_pan[i] = Color.FromArgb(255, r, g, b);
                }
                if (i >= 20 && i <= 30)
                {
                    r += step;
                    g = 255;
                    b = 0;
                    color_on_pan[i] = Color.FromArgb(255, r, g, b);
                }
                if (i >= 30 && i <= 40)
                {
                    r = 255;
                    g -= step;
                    b = 0;
                    color_on_pan[i] = Color.FromArgb(255, r, g, b);
                }
                if (i >= 40 && i <= 46)
                {
                    b = 255;
                    g += step;
                    color_on_pan[i] = Color.FromArgb(255, r, g, b);
                }
                if (i == 47)
                {
                    color_on_pan[i] = Color.FromArgb(255, 255, 255, 255);
                }
            }
            return color_on_pan;
        }
    }
}
