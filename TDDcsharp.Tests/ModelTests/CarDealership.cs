using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDcsharp;

namespace TDDcsharp.Tests
{
    [TestClass]
    public class CarDealershipTests
    {
        [TestMethod]
        public void isCar_StringEqualCarThing_True()
        {
            CarDealership testCarDealership = new CarDealership();
            Assert.AreEqual(true, testCarDealership.isCar("4 wheels"));
        }

        [TestMethod]
        public void isCar_StringNotEqualCarThings_False()
        {
            CarDealership testCarDealership = new CarDealership();
            Assert.AreEqual(false, testCarDealership.isCar("horse"));
        }
    }
}