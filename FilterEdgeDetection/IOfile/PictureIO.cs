﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilterEdgeDetection.IOfile
{
    public class PictureIO : IPictureIO
    {
        Bitmap uploadedPicture;

        public Bitmap openPicture(String path)
        {
           
                StreamReader streamReader = new StreamReader(path);
                uploadedPicture = (Bitmap)Bitmap.FromStream(streamReader.BaseStream);
                streamReader.Close();
            

            return uploadedPicture;
        }

        public void savePicture(Bitmap savedPicture)
        {
            String path;

            if (savedPicture != null)
            { 
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Specify a file name and file path";
            sfd.Filter = "Png Images(*.png)|*.png|Jpeg Images(*.jpg)|*.jpg";
            sfd.Filter += "|Bitmap Images(*.bmp)|*.bmp";

              path = sfd.FileName;

                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
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

                savedPicture = null;
            }
          }
        }


    }
}
