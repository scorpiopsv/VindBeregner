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
    }
}
