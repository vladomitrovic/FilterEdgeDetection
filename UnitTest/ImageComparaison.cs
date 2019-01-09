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
        public static void AreEqual(Bitmap bitmap, Bitmap bitmapResult)
        {
            //loop that take every pixel
            for (int i = 0; i < bitmapResult.Width; i++)
            {
                //loop that take every pixel
                for (int j = 0; j < bitmapResult.Height; j++)
                {
                    //Compares the pixels and throw a fail if they are differents
                    if (bitmapResult.GetPixel(i, j) != bitmap.GetPixel(i, j))
                    {
                        throw new AssertFailedException(
                         string.Format("The pixel check failed"));
                    }
                }
            }
        }

    }
}
