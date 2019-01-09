using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using FilterEdgeDetection.BLL;
using System.Drawing;

namespace UnitTest
{

[TestClass]
    public class TestFilter
    {
        //Image to convert
        static String path = System.AppDomain.CurrentDomain.BaseDirectory.ToString().Replace("bin\\Debug", "Resources/swissBase.png").Replace("\\", "/");
        Bitmap basePicture = new Bitmap(path);

        [TestMethod]
        public void TestBlackAndWhiteFilter()
        {
            var filter = Substitute.For<IFilter>();
            Filter imageFilter = new Filter();

            String path = System.AppDomain.CurrentDomain.BaseDirectory.ToString().Replace("bin\\Debug", "Resources/swissBlackW.png").Replace("\\", "/");

            Bitmap exeptedImage = new Bitmap(path);

            filter.BlackWhite(basePicture).Returns(exeptedImage);

            Assert.AreEqual(filter.BlackWhite(basePicture), exeptedImage);

            Bitmap result = imageFilter.BlackWhite(basePicture);

            ImageComparaison.AreEqual( result, exeptedImage);
        }


        [TestMethod]
        public void TestNightFilter()
        {
            var filter = Substitute.For<IFilter>();
            Filter imageFilter = new Filter();

            String path = System.AppDomain.CurrentDomain.BaseDirectory.ToString().Replace("bin\\Debug", "Resources/swissNight.png").Replace("\\", "/");

            Bitmap exeptedImage = new Bitmap(path);

            filter.ApplyFilter(basePicture, 1, 1, 1, 25).Returns(exeptedImage);

            Assert.AreEqual(filter.ApplyFilter(basePicture, 1, 1, 1, 25), exeptedImage);

            Bitmap result = imageFilter.ApplyFilter(basePicture, 1, 1, 1, 25);

            ImageComparaison.AreEqual(result, exeptedImage);
        }

        [TestMethod]
        public void TestNull()
        {
            var filter = Substitute.For<IFilter>();

            Filter imageFilter = new Filter();

            Bitmap bitmap = null;

            
            filter
                .When(x => x.BlackWhite(bitmap))
                .Do(x => { throw new Exception("Null bitmap"); });

            bitmap = imageFilter.BlackWhite(bitmap);

            Assert.AreEqual(bitmap, null);
        }
    }
}
