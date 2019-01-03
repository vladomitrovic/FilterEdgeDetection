using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;
using NSubstitute;
using FilterEdgeDetection.BLL;

namespace UnitTest
{

    [TestClass]
    public class TestEdge
    { 
        //Image to convert
        static String path = System.AppDomain.CurrentDomain.BaseDirectory.ToString().Replace("bin\\Debug", "Resources/swissBase.png").Replace("\\","/");
        Bitmap basePicture = new Bitmap(path);


        [TestMethod]
        public void TestKirschEdge()
        {
            var edge = Substitute.For<IEdge>();
            Edge imageEdge = new Edge();

            String path = System.AppDomain.CurrentDomain.BaseDirectory.ToString().Replace("bin\\Debug", "Resources/swissKirsch.png").Replace("\\", "/");

            Bitmap exeptedImage = new Bitmap(path);

            edge.KirschFilter(basePicture).Returns(exeptedImage);

            Assert.AreEqual(edge.KirschFilter(basePicture), exeptedImage);

            Bitmap result = imageEdge.KirschFilter(basePicture);

            ImageComparaison.AreEqual(result, exeptedImage);
        }


        [TestMethod]
        public void TestNightFilter()
        {
            var edge = Substitute.For<IEdge>();
            Edge imageEdge = new Edge();

            String path = System.AppDomain.CurrentDomain.BaseDirectory.ToString().Replace("bin\\Debug", "Resources/swissPrewitt.png").Replace("\\", "/");

            Bitmap exeptedImage = new Bitmap(path);

            edge.PrewittFilter(basePicture).Returns(exeptedImage);

            Assert.AreEqual(edge.PrewittFilter(basePicture), exeptedImage);

            Bitmap result = imageEdge.PrewittFilter(basePicture);

            ImageComparaison.AreEqual(result, exeptedImage);
        }
    }
}
