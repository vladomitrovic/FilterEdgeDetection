using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterEdgeDetection.BLL
{
    public interface IPictureManipulation
    {
        Bitmap ApplyFilter(Bitmap bmp, int alpha, int red, int blue, int green);

        Bitmap BlackWhite(Bitmap bitmap);
    }
}
