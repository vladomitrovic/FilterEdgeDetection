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
            Filter imageFilter = new Filter();

            String path = System.AppDomain.CurrentDomain.BaseDirectory.ToString().Replace("bin\\Debug", "Resources/swissBlackW.png").Replace("\\", "/");

            Bitmap exeptedImage = new Bitmap(path);

            Bitmap result = imageFilter.BlackWhite(basePicture);

            ImageComparaison.AreEqual( result, exeptedImage);
        }


        [TestMethod]
        public void TestNightFilter()
        {
            Filter imageFilter = new Filter();

            String path = System.AppDomain.CurrentDomain.BaseDirectory.ToString().Replace("bin\\Debug", "Resources/swissNight.png").Replace("\\", "/");

            Bitmap exeptedImage = new Bitmap(path);

            Bitmap result = imageFilter.ApplyFilter(basePicture, 1, 1, 1, 25);

            ImageComparaison.AreEqual(result, exeptedImage);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void TestBlackAndWhiteFilterNull()
        {
            Filter imageFilter = new Filter();

            Bitmap bitmamNull = null;
            Bitmap result = imageFilter.BlackWhite(bitmamNull);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void TestNightFilterNull()
        {
            Filter imageFilter = new Filter();

            Bitmap bitmamNull = null;
            Bitmap result = imageFilter.ApplyFilter(bitmamNull, 1, 1, 1, 25);
        }


        [TestMethod]
        public void TestNull()
        {
            var filter = Substitute.For<IFilter>();

            Filter imageFilter = new Filter();

            Bitmap bitmap = null;

            //When we call the GetFilterName() method, we force to throw an exception 
            filter.When(x => x.BlackWhite(null)).Do(x => { throw new NullReferenceException("Image is null"); });

            bitmap = imageFilter.BlackWhite(bitmap);

            Assert.AreEqual(bitmap, null);
        }

    }
}
