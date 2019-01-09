using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FilterEdgeDetection.IOfile;
using System.Drawing;
using NSubstitute;
using System.IO;

namespace UnitTest
{


    [TestClass]
    public class TestIOpicture
    {
        //Base Picture
        static String path = System.AppDomain.CurrentDomain.BaseDirectory.ToString().Replace("bin\\Debug", "Resources/swissBase.png").Replace("\\", "/");
        Bitmap basePicture = new Bitmap(path);

        [TestMethod]
        public void OpenSaveDialog_WriteImage__IOException()
        {
            var io = Substitute.For<IPictureIO>();
            var pictureIO = new PictureIO();
            io.When(x => x.savePicture(Arg.Any<Bitmap>())).Do(x => { throw new IOException("IO Exeption !"); });
           
        }


    }
}
