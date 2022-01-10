using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;

namespace gvrTestProject
{
    public class UnitTest1
    {
        private const string Expected = "Hello World! from GVR";
        [TestMethod]
        public void TestMethod1()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                gvrconsoleapp.Program.Main();

                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }
        }
    }
}