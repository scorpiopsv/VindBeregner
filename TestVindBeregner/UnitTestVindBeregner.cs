using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VindBeregner;
using Xunit;


namespace TestVindBeregner
{
    [TestClass]
    public class UnitTestVindBeregner
    {
        [TestMethod]
        public void TestMaxVindstyrkeVed25ms()
        {
            VindMoellerBeregner p = new VindMoellerBeregner();

            double effekt = p.MegaWatt(25, 500);

            Xunit.Assert.Equal(500, effekt);            
        }

        [TestMethod]
        public void TestMinvindstyrkeVed4ms()
        {
            VindMoellerBeregner p = new VindMoellerBeregner();

            double effekt = p.MegaWatt(4, 500);

            Xunit.Assert.Equal(0, effekt);
        }

        [TestMethod]
        public void TestVindstyrkeVed14_5ms()
        {
            VindMoellerBeregner p = new VindMoellerBeregner();

            double effekt = p.MegaWatt(14.5, 500);

            Xunit.Assert.Equal(250, effekt);
        }

        [TestMethod]
        public void TestVindstyrkeOverMax()
        {
            VindMoellerBeregner p = new VindMoellerBeregner();

            double effekt = p.MegaWatt(30, 500);

            Xunit.Assert.Equal(0, effekt);
        }

        [TestMethod]
        public void TestVindstyrkeUnderMin()
        {
            VindMoellerBeregner p = new VindMoellerBeregner();

            double effekt = p.MegaWatt(2, 500);

            Xunit.Assert.Equal(0, effekt);
        }
    }
}
