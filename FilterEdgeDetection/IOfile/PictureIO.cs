using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterEdgeDetection.IOfile
{
    class PictureIO
    {
        

        public Bitmap openPicrture(string path)
        {
            Bitmap uploadedPicture;

            StreamReader streamReader = new StreamReader(path);
            uploadedPicture = (Bitmap)Bitmap.FromStream(streamReader.BaseStream);
            streamReader.Close();

            return uploadedPicture;
        }

        public void savePicture(Bitmap savedPicture, string path)
        {

            string fileExtension = Path.GetExtension(path).ToUpper();
            ImageFormat imgFormat = ImageFormat.Png;

            if (fileExtension == "BMP")
            {
                imgFormat = ImageFormat.Bmp;
            }
            else if (fileExtension == "JPG")
            {
                imgFormat = ImageFormat.Jpeg;
            }

            
            StreamWriter streamWriter = new StreamWriter(path, false);
            savedPicture.Save(streamWriter.BaseStream, imgFormat);
            streamWriter.Flush();
            streamWriter.Close();
        }


    }
}
