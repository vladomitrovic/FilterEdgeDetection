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
        [TestMethod]
        public void TestBlackAndWhiteFilter()
        {
            var filter = Substitute.For<IFilter>();
            Bitmap baseImage = new Bitmap("C:/Users/vlado/source/repos/FilterEdgeDetection/UnitTest/Resources/swissBase.png");
            Bitmap exeptedImage = new Bitmap("C:/Users/vlado/source/repos/FilterEdgeDetection/UnitTest/Resources/swissBlackW.png");

            baseImage = filter.BlackWhite(baseImage);

            ImageComparaison.AreEqual(baseImage, exeptedImage);
        }
    }
}
