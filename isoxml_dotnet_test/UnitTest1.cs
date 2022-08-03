using Dev4ag.ISO11783.TaskFile;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Xml.Serialization;

namespace Dev4ag
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void LoadSimpleTaskData()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(ISO11783TaskDataFile));
            string text = File.ReadAllText("./testdata/devices/TASKDATA_Devices.XML");
            using ( StringReader reader = new StringReader(text))
            {
                var output = (ISO11783TaskDataFile)serializer.Deserialize(reader);
                var subElements = output.Device;
                foreach(var codingData in subElements)
                {
                 Console.WriteLine("Device Found: " + codingData.DeviceDesignator);
                }
            }
        }

        [TestMethod]
        public void LoadSimpleDeviceDescription()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Device));
            string text = File.ReadAllText("./testdata/devices/Device_description.xml");
            using ( StringReader reader = new StringReader(text))
            {
                try {
                    var device = (Device)serializer.Deserialize(reader);
                    Console.WriteLine("Device Name: " + device.DeviceDesignator);
                    Console.WriteLine("Device Id: " + device.DeviceId);
                } catch (Exception ex) {
                    Console.WriteLine(ex.ToString());
                }
            }
        }
    }
}
