﻿using Dev4Agriculture.ISO11783.ISOXML.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dev4Agriculture.ISO11783.ISOXML.Test
{
    [TestClass]
    public class WSMTest
    {

        [TestMethod]
        public void CanReadValidWSM()
        {
            var clientName = "A00E84000DE0DB4B";//This mostly comes from a Device.D Attribute (Device.ClientName)
            var wsm = new WSM(clientName);
            Assert.AreEqual(wsm.ManufacturerCode, 111);
            Assert.AreEqual(wsm.DeviceClass, DeviceClass.Harvesters);
        }


        [TestMethod]
        public void CanReadValidLowerCaseWSM()
        {
            var clientName = "a00e84000de0db4b";//This mostly comes from a Device.D Attribute (Device.ClientName)
            var wsm = new WSM(clientName);
            Assert.AreEqual(wsm.ManufacturerCode, 111);
            Assert.AreEqual(wsm.DeviceClass, DeviceClass.Harvesters);
        }


        [TestMethod]
        public void CanThrowErrors()
        {
            Assert.ThrowsException<ClientNameTooLongException>(() => new WSM("abcdefdafdaffaefafeaefafaffaefaefef"));
            Assert.ThrowsException<ClientNameTooShortException>(() => new WSM("abcd"));
        }

    }
}
