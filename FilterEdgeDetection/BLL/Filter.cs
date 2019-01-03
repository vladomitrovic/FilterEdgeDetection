using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterEdgeDetection.BLL
{
   public class Filter : IFilter
    {
        //Night filter
        public Bitmap ApplyFilter(Bitmap bmp, int alpha, int red, int blue, int green)
        {

            Bitmap temp = new Bitmap(bmp.Width, bmp.Height);


            for (int i = 0; i < bmp.Width; i++)
            {
                for (int x = 0; x < bmp.Height; x++)
                {
                    Color c = bmp.GetPixel(i, x);
                    Color cLayer = Color.FromArgb(c.A / alpha, c.R / red, c.G / green, c.B / blue);
                    temp.SetPixel(i, x, cLayer);
                }
            }
            return temp;
        }

        //black and white filter
        public Bitmap BlackWhite(Bitmap bmp)
        {
            Bitmap temp = new Bitmap(bmp.Width, bmp.Height);

            int rgb;
            Color c;

            for (int y = 0; y < bmp.Height; y++)
                for (int x = 0; x < bmp.Width; x++)
                {
                    c = bmp.GetPixel(x, y);
                    rgb = (int)((c.R + c.G + c.B) / 3);
                    temp.SetPixel(x, y, Color.FromArgb(rgb, rgb, rgb));
                }
            return temp;

        }
    }
}
