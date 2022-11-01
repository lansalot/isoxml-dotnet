﻿using Dev4Agriculture.ISO11783.ISOXML.IdHandling;
using Dev4Agriculture.ISO11783.ISOXML.TaskFile;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dev4Agriculture.ISO11783.ISOXML.Test
{
    [TestClass]
    public class IDListTests
    {
        [TestMethod]
        public void CanFindID()
        {
            var task = new ISOTask
            {
                TaskId = "TSK1"
            };
            var idList = new IdList("TSK");
            idList.AddObjectAndAssignIdIfNone(task);
            Assert.AreEqual(idList.FindObject("TSK1"), task);
        }


        [TestMethod]
        public void CanGenerateIds()
        {
            var idList = new IdList("TSK");

            //Valid Object
            var task1 = new ISOTask
            {
                TaskId = "TSK1",
                TaskDesignator = "Task1"
            };
            idList.ReadObject(task1);

            //Add a Task without assigning an ID
            var task3 = new ISOTask
            {
                TaskDesignator = "Task3"
            };
            idList.ReadObject(task3);

            //Add one where an ID is forced to be created
            var task2 = new ISOTask
            {
                TaskDesignator = "Task2"
            };
            idList.AddObjectAndAssignIdIfNone(task2);

            idList.CleanListFromTempEntries();

            Assert.AreEqual(((ISOTask)idList.FindObject("TSK1")).TaskId, "TSK1");
            Assert.AreEqual(((ISOTask)idList.FindObject("TSK2")).TaskId, "TSK2");
            Assert.AreEqual(((ISOTask)idList.FindObject("TSK3")).TaskId, "TSK3");

            Assert.AreEqual(((ISOTask)idList.FindObject("TSK1")).TaskDesignator, "Task1");
            Assert.AreEqual(((ISOTask)idList.FindObject("TSK2")).TaskDesignator, "Task2");
            Assert.AreEqual(((ISOTask)idList.FindObject("TSK3")).TaskDesignator, "Task3");

        }


        [TestMethod]
        public void CanGenerateIdsForDeviceElement()
        {
            var isoxml = ISOXML.Create("");
            for (var a = 1; a < 3; a++)
            {
                var device = new ISODevice();
                isoxml.IdTable.AddObjectAndAssignIdIfNone(device);
                for (var b = 0; b < 3; b++)
                {
                    var det = new ISODeviceElement();
                    isoxml.IdTable.AddObjectAndAssignIdIfNone(det);
                    device.DeviceElement.Add(det);
                }
                isoxml.Data.Device.Add(device);
            }
            Assert.IsNotNull(isoxml.IdTable.FindById("DET1"));
            Assert.IsNotNull(isoxml.IdTable.FindById("DET2"));
            Assert.IsNotNull(isoxml.IdTable.FindById("DET3"));
            Assert.IsNotNull(isoxml.IdTable.FindById("DET4"));
            Assert.IsNull(isoxml.IdTable.FindById("DET10"));
            Assert.IsNull(isoxml.IdTable.FindById("DET-1"));
        }
    }


}
