using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using exSeptSeg;

namespace UnitTest1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSegmentForm()
        {
            // Arrange
            Segment test = new Segment(segForm: '-', positionX: 2, positionY: 1, onOff: false, name: "A");
            char form = ' ';
            
            // Act
            form = test.SegForm;
            
            //Assert
            Assert.AreEqual('-', form, $"La forme du segment est {form}");

        }




    }
}
