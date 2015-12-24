using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Prototype;

namespace DesignPatternsTest.Prototype
{
    [TestClass]
    public class PrototypeTest
    {
        private static VehicleCloner cloner;

        [ClassInitialize]
        public static void PrototypeTestInitialize(TestContext context)
        {
            cloner = VehicleCloner.Instance;
        }

        [ClassCleanup]
        public static void PrototypeTestCleanup()
        {
            cloner = null;
        }


        [TestMethod]
        public void TestCreatePrototype()
        {
            foreach(VehicleType vehicleType in Enum.GetValues(typeof(VehicleType)))
            {
                Vehicle clone1=cloner.CreatePrototype(vehicleType);
                Vehicle clone2 = cloner.CreatePrototype(vehicleType);
                Assert.IsFalse(Object.ReferenceEquals(clone1, clone2), 
                    "In Prototype Pattern Implemenation two objects should not have same reference/ address");
            }
            
        }
    }
}
