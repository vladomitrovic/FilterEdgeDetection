using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterEdgeDetection.IOfile
{
    interface IPictureIO
    {
        Bitmap openPicrture(string path);

        void savePicture(Bitmap savedPicture, string path);
    }
}
