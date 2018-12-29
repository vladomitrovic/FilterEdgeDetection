using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    public class ImageComparaison
    {
        public static void AreEqual(Bitmap image1, Bitmap image2)
        {
            for (int x = 0; x < image2.Width; x++)
            {
                for (int y = 0; y < image2.Height; y++)
                {
                    if (image1.GetPixel(x, y) != image2.GetPixel(x, y))
                        throw new AssertFailedException(
                         string.Format("The pixelCheck failed"));
                }
            }
        }

    }
}
