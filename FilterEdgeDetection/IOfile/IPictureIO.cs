using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterEdgeDetection.IOfile
{
    public interface IPictureIO
    {
        Bitmap openPicture(string path);

        void savePicture(Bitmap savedPicture);
    }
}
