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
        [ExpectedException(typeof(IOException))]
        public void TestIOException()
        {
            var io = Substitute.For<IPictureIO>();
            io.When(x => x.savePicture(Arg.Any<Bitmap>())).Do(x => { throw new IOException("IO Exeption !"); });
            io.savePicture(null);
        }

        [TestMethod]
        public void TestSavePicture()
        {
            PictureIO io = new PictureIO();
            bool result = io.savePicture(basePicture);
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void TestOpenPicture()
        {
            PictureIO io = new PictureIO();
            Bitmap result = io.openPicture();
            Assert.AreNotEqual(result, null);
        }


    }
}
