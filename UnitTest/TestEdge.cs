using System;
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
            Edge imageEdge = new Edge();

            String path = System.AppDomain.CurrentDomain.BaseDirectory.ToString().Replace("bin\\Debug", "Resources/swissKirsch.png").Replace("\\", "/");

            Bitmap exeptedImage = new Bitmap(path);

            Bitmap result = imageEdge.KirschFilter(basePicture);

            ImageComparaison.AreEqual(result, exeptedImage);
        }


        [TestMethod]
        public void TestPrewittFilter()
        {
            Edge imageEdge = new Edge();

            String path = System.AppDomain.CurrentDomain.BaseDirectory.ToString().Replace("bin\\Debug", "Resources/swissPrewitt.png").Replace("\\", "/");

            Bitmap exeptedImage = new Bitmap(path);

            Bitmap result = imageEdge.PrewittFilter(basePicture);

            ImageComparaison.AreEqual(result, exeptedImage);
        }

        [TestMethod]
        public void TestCopyToSquare()
        {
            Edge imageEdge = new Edge();

            Bitmap result = imageEdge.CopyToSquareCanvas(basePicture, 200);

            Assert.AreEqual(result.Width, 200);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void TestPrewittFilterNull()
        {
            Edge imageEdge = new Edge();

            Bitmap bitmamNull = null;
            Bitmap result = imageEdge.PrewittFilter(bitmamNull);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void TestKirschEdgeNull()
        {
            Edge imageEdge = new Edge();

            Bitmap bitmamNull = null;
            Bitmap result = imageEdge.PrewittFilter(bitmamNull);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void TestExeption()
        {

            var filterEdge = Substitute.For<IEdge>();
            //generate the exception 
            filterEdge.When(x => x.PrewittFilter(null)).Do(x => { throw new NullReferenceException("Image is null"); });

            filterEdge.PrewittFilter(null);
        }
    }
}
